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

    Public Function add_street(ByVal calle As calle, ByVal cant As Integer) As Integer
        Return oCalleDAO.add_street(calle, cant)
    End Function

    Public Function edit_street(ByVal calle As calle, ByVal cant As Integer) As Integer
        Return oCalleDAO.edit_street(calle, cant)
    End Function

End Class
