﻿Public Class SupplierService
    '------------------------> Inicio Modificación <------------------------
    'Versión inicial
    'cbaigorria
    '06-09-2016
    '-----------------------------------------------------------------------
    Private oSupplierDAO As SupplierDAO

    Public Sub New()
        oSupplierDAO = New SupplierDAO()
    End Sub

    Public Function listSuppliers() As List(Of Supplier)
        Return oSupplierDAO.getAll()
    End Function

    Public Function update_Supplier(ByVal supp As Supplier) As Integer
        Return oSupplierDAO.update(supp)
    End Function

    Public Function insert_supplier(ByVal supp As Supplier) As Integer
        Return oSupplierDAO.insert_Supplier(supp)
    End Function

    Public Function delete_supplier(ByVal supp As Supplier) As Integer
        Return oSupplierDAO.delete_supplier(supp)
    End Function

    Public Function list_one(ByVal supplier As Integer) As Supplier
        Return oSupplierDAO.get_one(supplier)
    End Function

    Public Function list_active() As List(Of Supplier)
        Return oSupplierDAO.getAll_active()
    End Function

    '--------------------------> Fin Modificación <-------------------------
    'Versión inicial
    'cbaigorria
    '06-09-2016
    '-----------------------------------------------------------------------

End Class
