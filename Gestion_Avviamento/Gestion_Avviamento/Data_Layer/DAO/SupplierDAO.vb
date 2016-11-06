Public Class SupplierDAO

    '------------------------> Inicio Modificación <------------------------
    'Versión inicial
    'cbaigorria
    '06-09-2016
    '-----------------------------------------------------------------------

    Public Function getAll() As List(Of Supplier)
        Dim oSupplier As Supplier
        Dim supps As New List(Of Supplier)
        Dim strSQL = "SELECT a.cod_proveedor, a.razon_social, a.cuit, a.pais as id_pais, b.descripcion as pais, a.contacto, a.email, a.habilitado " & _
        "FROM Proveedor a, Paises b " & _
        "WHERE(a.pais = b.id) " & _
        "ORDER BY 1 ASC"

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

    Public Function update(ByVal supp As Supplier) As Integer
        Dim strSQL = "UPDATE Proveedor SET razon_social = '"
        strSQL += supp.razon_social.ToString + "', contacto = '"
        strSQL += supp.contacto.ToString + "', cuit = "
        strSQL += supp.cuit.ToString + ", habilitado = "
        strSQL += supp.habilitado.ToString + ", email = '"
        strSQL += supp.email.ToString + "', pais = '"
        strSQL += supp.id_pais.ToString + "' WHERE cod_proveedor = " + supp.codigo.ToString

        Return BDHelper.getDBHelper.EjecutarSQL(strSQL)
    End Function

    Public Function insert_Supplier(ByVal supp As Supplier) As Integer
        Dim strSQL = "INSERT INTO Proveedor (razon_social, cuit, pais, contacto, email, habilitado) "
        strSQL += "VALUES ('"
        strSQL += supp.razon_social + "', "
        strSQL += supp.cuit.ToString + ", "
        strSQL += supp.id_pais.ToString + ", '"
        strSQL += supp.contacto + "', '"
        strSQL += supp.email + "', "
        strSQL += supp.habilitado.ToString + ")"

        Return BDHelper.getDBHelper.EjecutarSQL(strSQL)
    End Function

    Public Function delete_supplier(ByVal supp As Supplier) As Integer
        Dim strSQL = "UPDATE Proveedor SET activo = 1 WHERE cod_proveedor = " + supp.codigo.ToString
        Return BDHelper.getDBHelper.EjecutarSQL(strSql)
    End Function

    '--------------------------> Fin Modificación <-------------------------
    'Versión inicial
    'cbaigorria
    '06-09-2016
    '-----------------------------------------------------------------------

    Public Function get_one(ByVal codigo As Integer) As Supplier
        Dim oSupplier As Supplier = Nothing
        Dim oTable As DataTable

        'Armamos el query para ejecutar a la base
        Dim strSQL = "SELECT a.cod_proveedor, a.razon_social, a.cuit, a.pais as id_pais, b.descripcion as pais, a.contacto, a.email, a.habilitado " & _
        "FROM Proveedor a, Paises b " & _
        "WHERE(a.pais = b.id) AND cod_proveedor = " + codigo.ToString

        'Delegamos la ejecución del comando SQL al Helper
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        'Con la tabla devuelta por el Helper creamos un OBJETO User a partir de los datos de fila de la tabla Users
        If oTable.Rows.Count > 0 Then
            oSupplier = New Supplier()
            oSupplier.codigo = oTable.Rows(0).Item("cod_proveedor").ToString
            oSupplier.contacto = oTable.Rows(0).Item("contacto").ToString
            oSupplier.cuit = oTable.Rows(0).Item("cuit").ToString
            oSupplier.email = oTable.Rows(0).Item("email").ToString
            If Not IsDBNull(oTable.Rows(0).Item("habilitado")) Then
                oSupplier.habilitado = 1
            Else
                oSupplier.habilitado = 0
            End If
            oSupplier.pais = oTable.Rows(0).Item("pais").ToString
            oSupplier.id_pais = oTable.Rows(0).Item("id_pais").ToString
            oSupplier.razon_social = oTable.Rows(0).Item("razon_social").ToString
        End If
        Return oSupplier
    End Function


    Public Function getAll_active() As List(Of Supplier)
        Dim oSupplier As Supplier
        Dim supps As New List(Of Supplier)
        Dim strSQL = "SELECT a.cod_proveedor, a.razon_social, a.cuit, a.pais as id_pais, b.descripcion as pais, a.contacto, a.email, a.habilitado " & _
        "FROM Proveedor a, Paises b " & _
        "WHERE(a.pais = b.id) " & _
        "AND habilitado = 0 " & _
        "ORDER BY 1 ASC"

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
