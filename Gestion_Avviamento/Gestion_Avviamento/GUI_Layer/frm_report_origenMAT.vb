Imports Microsoft.Reporting.WinForms

Public Class frm_report_origenMAT

    Private Sub frm_report_origenMAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oPaisService As New PaisService
        llenarCombo(cbo_paises, oPaisService.get_all(), "descripcion", "id")
        actualizar()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        actualizar()
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub actualizar()
        Dim valor As Integer = -1

        If Integer.Parse(cbo_paises.SelectedIndex.ToString) <> -1 Or Not String.IsNullOrEmpty(cbo_paises.SelectedText) Then
            valor = Integer.Parse(cbo_paises.SelectedValue.ToString)
        End If
        report.LocalReport.DataSources.Clear()
        report.LocalReport.DataSources.Add(New ReportDataSource("DS_origen", BDHelper.getDBHelper.report_origen_mat(valor)))
        Me.report.RefreshReport()
    End Sub

End Class