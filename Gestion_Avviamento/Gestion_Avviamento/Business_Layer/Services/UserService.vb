Public Class UserService
    '------------------------> Inicio Modificación <------------------------
    'Versión inicial
    'cbaigorria
    '07-09-2016
    '-----------------------------------------------------------------------
    Private oUserDAO As UserDAO

    Public Sub New()
        oUserDAO = New UserDAO()
    End Sub

    Public Function validarUsuario(ByVal user As String, ByVal pass As String) As User
        Return oUserDAO.getUser(user, pass)
    End Function

    '--------------------------> Fin Modificación <-------------------------
    'Versión inicial
    'cbaigorria
    '07-09-2016
    '-----------------------------------------------------------------------

End Class
