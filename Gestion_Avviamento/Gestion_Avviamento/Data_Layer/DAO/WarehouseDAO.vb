Imports System.Data.SqlClient

Public Class WarehouseDAO
    Public Function get_All(ByVal nro As Integer, ByVal descrip As String, ByVal llena As Integer) As List(Of calle)
        Dim ubicacion As New Ubicacion

        Dim street As calle
        Dim streets As New List(Of calle)
        Dim strSQL = "SELECT a.id_calle as id_calle, a.decrip as descripcion, a.habilitada as activa, a.llena as llena, a.tipo_volumen as id_vol, b.descripcion as tipo_volumen" & _
        " FROM Calle a, Tipo_Volumen b WHERE a.tipo_volumen = b.id "
        Dim ubi As Ubicacion = Nothing

        If nro <> -1 Then
            strSQL += " AND a.id_calle = " + nro.ToString
        End If
        If Not String.IsNullOrEmpty(descrip.ToString) Then
            strSQL += " AND a.decrip LIKE '%" + descrip + "%'"
        End If
        If llena <> -1 Then
            strSQL += " AND a.llena = " + llena.ToString
        End If

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            street = New calle()
            Dim ubis As New List(Of Ubicacion)

            With street
                .descripcion = row.Item("descripcion").ToString
                .habilitada = Integer.Parse(row.Item("activa").ToString)
                .id_volumen = Integer.Parse(row.Item("id_vol").ToString)
                .llena = Integer.Parse(row.Item("llena").ToString)
                .nro_calle = Integer.Parse(row.Item("id_calle").ToString)
                .tipo_volumen = row.Item("tipo_volumen").ToString
            End With
            Dim strSQLU = "SELECT id_ubicacion, id_calle, nro, habilitada, ocupada FROM Ubicacion WHERE habilitada = 0 and id_calle = " + street.nro_calle.ToString
            For Each fila As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQLU).Rows
                ubi = New Ubicacion
                With ubi
                    .id_ubic = Integer.Parse(fila.Item("id_ubicacion").ToString)
                    .habilitada = Integer.Parse(fila.Item("habilitada").ToString)
                    .nro = Integer.Parse(fila.Item("nro").ToString)
                    .ocupada = Integer.Parse(fila.Item("ocupada").ToString)
                End With
                ubis.Add(ubi)
            Next
            street.ubicaciones = ubis
            streets.Add(street)
        Next
        Return streets
    End Function
    Public Function get_one(ByVal id_calle As Integer) As calle
        Dim street As calle = Nothing
        Dim oTable As DataTable
        Dim oLoc As Ubicacion
        Dim strSQL = "SELECT a.id_calle as id_calle, a.decrip as descripcion, a.habilitada as activa, a.llena as llena, a.tipo_volumen as id_vol b.descripcion as tipo_volumen" & _
       "FROM Calle a, Tipo_Volumen b WHERE a.tipo_volumen = b.id AND a.id_calle = " + id_calle.ToString
        Dim strSQLU = "SELECT id_ubicacion, id_calle, nro, habilitada, ocupada FROM Ubicacion WHERE habilitada = 0 and id_calle = " + id_calle.ToString
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)

        If oTable.Rows.Count > 0 Then
            With street
                .descripcion = oTable.Rows(0).Item("descripcion").ToString
                .habilitada = Integer.Parse(oTable.Rows(0).Item("activa").ToString)
                .id_volumen = Integer.Parse(oTable.Rows(0).Item("id_vol").ToString)
                .llena = Integer.Parse(oTable.Rows(0).Item("llena").ToString)
                .nro_calle = Integer.Parse(oTable.Rows(0).Item("id_calle").ToString)
                .tipo_volumen = oTable.Rows(0).Item("tipo_volumen").ToString
            End With

            For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQLU).Rows
                oLoc = New Ubicacion()

                With oLoc
                    .id_ubic = Integer.Parse(row.Item("id_ubicacion").ToString)
                    .habilitada = Integer.Parse(row.Item("habilitada").ToString)
                    .nro = Integer.Parse(row.Item("nro").ToString)
                    .ocupada = Integer.Parse(row.Item("ocupada").ToString)
                End With
                street.ubicaciones.Add(oLoc)
            Next

        End If
        Return street
    End Function

    Public Function add_street(ByVal calle As calle, ByVal cant As Integer) As Integer
        Dim strSQL As String = "DECLARE @ident int; "
        strSQL += "INSERT INTO Calle (decrip, habilitada, llena, tipo_volumen) VALUES ('" + calle.descripcion.ToString + "', " + calle.habilitada.ToString + ",0,1); "
        strSQL += "SELECT @ident = @@identity; "

        'inserto todas las ubicaciones
        For i As Integer = 0 To cant - 1
            Dim id As Integer = i + 1
            strSQL += "INSERT INTO Ubicacion (id_calle, nro, habilitada, ocupada) values (@ident, " + id.ToString + ",0,0); "
        Next
        Return BDHelper.getDBHelper.EjecutarTRANS(strSQL)
    End Function

    Public Function edit_street(ByVal calle As calle, ByVal cant As Integer) As Integer
        Dim strSQL = "UPDATE Calle set decrip= '" + calle.descripcion.ToString + "', " + "habilitada = " + calle.habilitada.ToString + ", tipo_volumen = " + calle.id_volumen.ToString + " WHERE ID_CALLE = " + calle.nro_calle.ToString
        Dim status = 0
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim trans As SqlTransaction = Nothing

        Try
            conexion.ConnectionString = "Data Source=AYLÉN-PC\AYLEN;Initial Catalog=TPI;User ID=avisuales; Password=instance"

            conexion.Open()

            trans = conexion.BeginTransaction()

            'inserto la nueva calle
            cmd = New SqlCommand(strSQL, conexion, trans)
            cmd.ExecuteNonQuery()
            If cant <> -1 Then
                'borro las ubicaciones
                cmd = New SqlCommand("DELETE FROM Ubicacion WHERE id_calle = " + calle.nro_calle.ToString, conexion, trans)
                cmd.ExecuteNonQuery()
                'inserto las nuevas ubicaciones
                For i As Integer = 0 To cant - 1
                    Dim id As Integer = i + 1
                    Dim SQL = "INSERT INTO Ubicacion (id_calle, nro, habilitada, ocupada) values (" + calle.nro_calle.ToString + "," + id.ToString + ",0,0)"
                    cmd = New SqlCommand(SQL, conexion, trans)
                    cmd.ExecuteNonQuery()
                Next
            End If
            'hago commit a la transacción
            trans.Commit()
            status = 1
        Catch sql As SqlException
            status = 0
            trans.Rollback()
        Catch ex As Exception

        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function
    Public Function delete_calle(ByVal nro_calle As Integer) As Integer
        Dim strSQL As String = " DELETE FROM CALLE WHERE id_calle = " + nro_calle.ToString
        Dim SQL As String = "SELECT COUNT(ID_UBICACION) FROM UBICACION WHERE ID_CALLE = " + nro_calle.ToString + " AND OCUPADA <> 0"
        Dim table As DataTable = BDHelper.getDBHelper.ConsultaSQL(SQL)
        Dim status As Integer = 0

        If table.Rows(0).Item(0) <> 0 Then
            status = 2
        Else
            Dim conexion As New SqlConnection
            Dim command As New SqlCommand
            Dim trans As SqlTransaction = Nothing

            Try
                conexion.ConnectionString = "Data Source=AYLÉN-PC\AYLEN;Initial Catalog=TPI;User ID=avisuales; Password=instance"

                conexion.Open()

                trans = conexion.BeginTransaction()

                command = New SqlCommand("DELETE UBICACION WHERE ID_CALLE = " + nro_calle.ToString, conexion, trans)
                command.ExecuteNonQuery()
                command = New SqlCommand(strSQL, conexion, trans)
                command.ExecuteNonQuery()
                
                'hago commit a la transacción
                trans.Commit()
                status = 1
            Catch sql_ex As SqlException
                status = 0
                trans.Rollback()
            Catch ex As Exception

            Finally
                conexion.Close()
                conexion.Dispose()
            End Try
        End If
        Return status
    End Function

End Class
