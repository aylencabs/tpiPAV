Public Class WarehouseDAO
    Public Function get_All(ByVal nro As Integer, ByVal descrip As String, ByVal llena As Integer) As List(Of calle)
        Dim ubicacion As New Ubicacion
        Dim street As calle
        Dim streets As New List(Of calle)
        Dim strSQL = "SELECT a.id_calle as id_calle, a.decrip as descripcion, a.habilitada as activa, a.llena as llena, a.tipo_volumen as id_vol, b.descripcion as tipo_volumen" & _
        " FROM Calle a, Tipo_Volumen b WHERE a.tipo_volumen = b.id "
        Dim strSQLU = "SELECT id_ubicacion, id_calle, nro, habilitada, ocupada FROM Ubicacion WHERE habilitada = 0 and id_calle = "
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

            With street
                .descripcion = row.Item("descripcion").ToString
                .habilitada = Integer.Parse(row.Item("activa").ToString)
                .id_volumen = Integer.Parse(row.Item("id_vol").ToString)
                .llena = Integer.Parse(row.Item("llena").ToString)
                .nro_calle = Integer.Parse(row.Item("id_calle").ToString)
                .tipo_volumen = row.Item("tipo_volumen").ToString
            End With
            strSQLU += street.nro_calle.ToString
            For Each fila As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQLU).Rows
                ubi = New Ubicacion
                With ubi
                    .id_ubic = Integer.Parse(fila.Item("id_ubicacion").ToString)
                    .habilitada = Integer.Parse(fila.Item("habilitada").ToString)
                    .nro = Integer.Parse(fila.Item("nro").ToString)
                    .ocupada = Integer.Parse(fila.Item("ocupada").ToString)
                End With
                street.ubicaciones.Add(ubi)
            Next
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

End Class
