Imports Microsoft.Reporting.WinForms

Public Class report_list_mat

    Private Sub frm_report_origenMAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        actualizar()
    End Sub

    Private Sub actualizar()
        list_mat.LocalReport.DataSources.Clear()
        list_mat.LocalReport.DataSources.Add(New ReportDataSource("DS_mats", BDHelper.getDBHelper.listado_materiales()))
        Me.list_mat.RefreshReport()
    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        actualizar()
    End Sub
End Class