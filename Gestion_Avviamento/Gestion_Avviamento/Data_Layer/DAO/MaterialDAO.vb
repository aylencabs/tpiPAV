Public Class MaterialDAO


    Public Function getAll(Optional ByVal cod As Long = -1, Optional ByVal descrip As String = "", Optional ByVal prov As Integer = -1, Optional ByVal vol As Integer = -1) As List(Of Material)
        Dim oMaterial As Material
        Dim mats As New List(Of Material)
        Dim strSQL = "SELECT a.id_mat as id_mat, a.descrip as descrip, a.tipo_vol as tipo_vol," & _
        " a.habilitado as habilitado, c.id_prov as cod_proveedor, b.razon_social as razon_social, " & _
        "d.descripcion as descr_vol " & _
        "FROM Material a, Proveedor b, Prov_X_Mat c, Tipo_Volumen d " & _
        "where a.id_mat = c.id_mat " & _
        "AND c.id_prov = b.cod_proveedor " & _
        "AND a.tipo_vol = d.id " & _
        "AND a.habilitado = 0 " & _
        "AND b.habilitado = 0 "


        If cod <> -1 Then
            strSQL += "AND a.id_mat LIKE '%" + cod.ToString + "%' "
        End If
        If Not String.IsNullOrEmpty(descrip.ToString) Then
            strSQL += "AND a.descrip LIKE '%" + descrip + "%' "
        End If
        If prov > 0 Then
            strSQL += "AND b.cod_proveedor = " + prov.ToString + " "
        End If
        If vol > 0 Then
            strSQL += "AND a.tipo_vol =" + vol.ToString + " "
        End If

        strSQL += " UNION SELECT e.id_mat as id_mat, e.descrip as descrip, e.tipo_vol as tipo_vol, " & _
            "e.habilitado as habilitado, 0 as cod_proveedor, '' as razon_social, f.descripcion as descr_vol " & _
            "FROM Material e, Tipo_Volumen f, Prov_X_Mat g WHERE e.tipo_vol = f.id AND e.id_mat NOT IN (Select distinct id_mat from prov_x_mat) AND e.habilitado = 0 "

        If cod <> -1 Then
            strSQL += "AND e.id_mat LIKE '%" + cod.ToString + "%' "
        End If
        If Not String.IsNullOrEmpty(descrip.ToString) Then
            strSQL += "AND e.descrip LIKE '%" + descrip + "%' "
        End If
        If vol > 0 Then
            strSQL += "AND e.tipo_vol =" + vol.ToString + " "
        End If

        strSQL += "ORDER by 1,6 ASC"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Supplier a partir de los datos de la/s filas de la tabla Supplier

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oMaterial = New Material()
            'oSupplier.codigo = Convert.ToInt32(row.Item("cod_proveedor").ToString)
            With oMaterial
                .id_mat = Long.Parse(row.Item("id_mat").ToString)
                .descripcion = row.Item("descrip").ToString
                .tipo_vol = Integer.Parse(row.Item("tipo_vol").ToString)
                .habilitado = Integer.Parse(row.Item("habilitado").ToString)
                .id_prov = Integer.Parse(row.Item("cod_proveedor").ToString)
                .prov = row.Item("razon_social").ToString
                .descr_vol = row.Item("descr_vol").ToString
            End With
            mats.Add(oMaterial)
        Next

        Return mats
    End Function

    Public Function update(ByVal mat As Material, ByVal supps As List(Of Integer)) As Integer
        Dim strSQL = "UPDATE Material SET descrip = '"
        strSQL += mat.descripcion.ToString + "', tipo_vol = "
        strSQL += mat.tipo_vol.ToString + " , habilitado = "
        strSQL += mat.habilitado.ToString
        strSQL += " WHERE id_mat = " + mat.id_mat.ToString + "; "

        strSQL += " DELETE FROM Prov_X_Mat WHERE id_mat = " + mat.id_mat.ToString + "; "

        If supps.Count <> 0 Then
            For i As Integer = 0 To supps.Count() - 1
                strSQL += " INSERT INTO Prov_X_Mat (id_mat, id_prov) VALUES (" + mat.id_mat.ToString + ", " + supps(i).ToString + "); "
            Next
        End If
        Return BDHelper.getDBHelper.EjecutarTRANS(strSQL)
    End Function

    Public Function delete(ByVal id_mat As Long) As Integer
        Dim strSQL = "UPDATE Material SET habilitado = 1 WHERE id_mat = " + id_mat.ToString
        Return BDHelper.getDBHelper.EjecutarSQL(strSQL)
    End Function

    Public Function add_rel(ByVal id_mat As Long, ByVal id_prov As List(Of Integer)) As Integer
        Dim strSQL = "DELETE FROM Prov_X_Mat WHERE id_mat = " + id_mat.ToString + "; "

        For i As Integer = 0 To id_prov.Count() - 1
            strSQL += "INSERT INTO Prov_X_Mat (id_mat, id_prov) VALUES (" + id_mat.ToString + ", " + id_prov(i).ToString + "); "
        Next
        Return BDHelper.getDBHelper.EjecutarTRANS(strSQL)
    End Function

    Public Function insert_Mat(ByVal mat As Material, ByVal supps As List(Of Integer)) As Integer
        Dim strSQL = "DECLARE @ident int; "
        strSQL += "INSERT INTO Material (descrip, tipo_vol, habilitado) VALUES ('" + mat.descripcion + "', "
        strSQL += mat.tipo_vol.ToString + ", " + mat.habilitado.ToString + "); "
        strSQL += " SELECT @ident = @@identity; "
        If supps.Count <> 0 Then
            For i As Integer = 0 To supps.Count() - 1
                strSQL += " INSERT INTO Prov_X_Mat (id_mat, id_prov) VALUES (@ident, " + supps(i).ToString + "); "
            Next
        End If
        Return BDHelper.getDBHelper.EjecutarTRANS(strSQL)
    End Function

    Public Function getRels(ByVal cod_mat As Long) As List(Of Supplier)
        Dim oSupplier As Supplier
        Dim sups As New List(Of Supplier)
        Dim strSQL = "SELECT a.cod_proveedor, a.razon_social, a.cuit, a.pais as id_pais, c.descripcion as pais, a.contacto, a.email, a.habilitado as checked " & _
            " FROM PROV_X_MAT b, Proveedor a, Paises c " & _
            "WHERE b.ID_PROV = a.COD_PROVEEDOR AND a.pais = c.id AND a.habilitado = 0 AND b.ID_MAT = " + cod_mat.ToString + " ORDER BY 1 ASC"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Supplier a partir de los datos de la/s filas de la tabla Supplier

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oSupplier = New Supplier()

            With oSupplier
                .codigo = Integer.Parse(row.Item("cod_proveedor").ToString)
                .razon_social = row.Item("razon_social").ToString
                .cuit = Long.Parse(row.Item("cuit").ToString)
                .contacto = row.Item("contacto").ToString
                .email = row.Item("email").ToString
                .habilitado = row.Item("checked")
                .id_pais = Integer.Parse(row.Item("id_pais").ToString)
                .pais = row.Item("pais").ToString
            End With
            sups.Add(oSupplier)
        Next

        Return sups
    End Function

    Public Function getAll_nonREl(ByVal id_mat As Long) As List(Of Supplier)
        Dim oSupplier As Supplier
        Dim supps As New List(Of Supplier)
        Dim strSQL = "SELECT distinct a.cod_proveedor, a.razon_social, a.cuit, a.pais as id_pais, b.descripcion as pais, a.contacto, a.email, a.habilitado "
        strSQL += "from proveedor a, paises b, prov_x_mat c WHERE a.pais = b.id AND a.cod_proveedor = c.id_prov and a.habilitado = 0 "
        strSQL += "and a.cod_proveedor NOT IN (select distinct id_prov from prov_x_mat where id_mat = " + id_mat.ToString + ")"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Supplier a partir de los datos de la/s filas de la tabla Supplier

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oSupplier = New Supplier()
            oSupplier.codigo = Convert.ToInt32(row.Item("cod_proveedor").ToString)
            oSupplier.contacto = row.Item("contacto").ToString
            oSupplier.cuit = Long.Parse(row.Item("cuit").ToString)
            oSupplier.email = row.Item("email").ToString
            oSupplier.id_pais = Integer.Parse(row.Item("id_pais").ToString)
            oSupplier.pais = row.Item("pais").ToString
            oSupplier.razon_social = row.Item("razon_social").ToString
            oSupplier.habilitado = row.Item("habilitado")
            supps.Add(oSupplier)
        Next

        Return supps
    End Function

End Class