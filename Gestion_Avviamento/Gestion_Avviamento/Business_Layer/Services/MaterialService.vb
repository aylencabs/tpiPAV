Public Class MaterialService
    Private oMaterialDAO As MaterialDAO

    Public Sub New()
        oMaterialDAO = New MaterialDAO()
    End Sub


    Public Function listMaterials(Optional ByVal cod As Long = -1, Optional ByVal descrip As String = "", Optional ByVal prov As Integer = -1, Optional ByVal vol As Integer = -1) As List(Of Material)
        Return oMaterialDAO.getAll(cod, descrip, prov, vol)
    End Function
    Public Function update_Mat(ByVal mat As Material, ByVal supps As List(Of Integer)) As Integer
        Return oMaterialDAO.update(mat, supps)
    End Function

    Public Function delete_mat(ByVal id_mat As Long) As Integer
        Return oMaterialDAO.delete(id_mat)
    End Function

    Public Function add_rel(ByVal id_mat As Long, ByVal id_prov As List(Of Integer)) As Integer
        Return oMaterialDAO.add_rel(id_mat, id_prov)
    End Function

    Public Function del_rel(ByVal id_mat As Long, ByVal id_prov As Integer) As Integer
        Return 1
    End Function

    Public Function insert_mat(ByVal mat As Material, ByVal supps As List(Of Integer)) As Integer
        Return oMaterialDAO.insert_Mat(mat, supps)
    End Function

    Public Function get_Rels(ByVal cod_mat As Long) As List(Of Supplier)
        Return oMaterialDAO.getRels(cod_mat)
    End Function

    Public Function getNonRel(ByVal cod_mat As Long) As List(Of Supplier)
        Return oMaterialDAO.getAll_nonREl(cod_mat)
    End Function
End Class
