Imports Microsoft.Reporting.WinForms

Public Class frm_listado_proveedores

    Private Sub frm_listado_proveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar()
    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        actualizar()
    End Sub

    Private Sub actualizar()
        rep_provs.LocalReport.DataSources.Clear()
        rep_provs.LocalReport.DataSources.Add(New ReportDataSource("DS_provs", BDHelper.getDBHelper.listado_proveedores()))
        Me.rep_provs.RefreshReport()
    End Sub
End Class