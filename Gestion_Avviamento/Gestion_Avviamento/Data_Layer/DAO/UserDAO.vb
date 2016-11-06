Public Class UserDAO

    'Permite obtener un usuario a partir de un nombre de usuario y password
    Public Function getUser(ByVal usuario, ByVal pass)
        Dim oUser As User = Nothing
        Dim oTable As DataTable

        'Armamos el query para ejecutar a la base
        Dim strSQL As String = "SELECT * from Usuario WHERE activo = 0 AND nombre = '" + usuario + "' AND password = '" + pass + "'"
        'Delegamos la ejecución del comando SQL al Helper
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        'Con la tabla devuelta por el Helper creamos un OBJETO User a partir de los datos de fila de la tabla Users
        If oTable.Rows.Count > 0 Then
            oUser = New User()
            oUser.nombre = oTable.Rows(0).Item("nombre").ToString
            oUser.password = oTable.Rows(0).Item("password").ToString
            oUser.id = Integer.Parse(oTable.Rows(0).Item("id").ToString)
            oUser.apellido = oTable.Rows(0).Item("apellido").ToString
            oUser.activo = 0
            oUser.matricula = Integer.Parse(oTable.Rows(0).Item("matricula").ToString)
            oUser.email = oTable.Rows(0).Item("email").ToString
        End If

        Return oUser
    End Function
End Class
