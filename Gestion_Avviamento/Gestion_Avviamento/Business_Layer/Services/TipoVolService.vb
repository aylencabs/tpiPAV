Public Class TipoVolService
    Private oVolDAO As VolDAO

    Public Sub New()
        oVolDAO = New VolDAO()
    End Sub

    Public Function getAll() As List(Of Tipo_Volumen)
        Return oVolDAO.getAll()
    End Function
End Class
