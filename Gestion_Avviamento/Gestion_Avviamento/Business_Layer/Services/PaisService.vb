Public Class PaisService
    Private oPaisDAO
    Public Sub New()
        oPaisDAO = New PaisDAO()
    End Sub

    Public Function get_all() As List(Of Pais)
        Return oPaisDAO.getAll()
    End Function
End Class
