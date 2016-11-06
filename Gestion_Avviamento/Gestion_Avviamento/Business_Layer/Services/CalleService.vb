Public Class CalleService
    Private oCalleDAO As WarehouseDAO

    Public Sub New()
        oCalleDAO = New WarehouseDAO()
    End Sub

    Public Function get_all(Optional ByVal nro As Integer = -1, Optional ByVal descripcion As String = "", Optional ByVal llena As Integer = -1) As List(Of calle)
        Return oCalleDAO.get_All(nro, descripcion, llena)
    End Function

    Public Function get_one(ByVal id_calle As Integer) As calle
        Return oCalleDAO.get_one(id_calle)
    End Function
End Class
