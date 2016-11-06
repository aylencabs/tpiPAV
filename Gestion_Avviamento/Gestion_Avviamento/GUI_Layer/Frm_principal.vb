Public Class Frm_principal
    Friend flag As Integer = 0
    Private Sub Frm_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pnl_user.Width = Me.Width
        lbl_ingreso.Text = ""
        lbl_user.Text = ""
        Frm_login.ShowDialog()
        If flag = 0 Then
            Deshabilitar_Componentes()
            lbl_ingreso.Text = "Debe iniciar sesión en el sistema!!"
            lbl_ingreso.ForeColor = Color.Red

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frm_proveedor.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Mostrar formulario Materiales
        Frm_materiales.ShowDialog()
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosToolStripMenuItem.Click
        'Mostrar formulario Movimientos
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
        'Mostrar Formulario Ubicaciones
        frm_almacen.ShowDialog()
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        'Mostrar Formulario Usuarios
    End Sub

    Private Sub Deshabilitar_Componentes()
        tool_grip_admin.Enabled = False
        tool_grip_report.Enabled = False
        tool_grip_stock.Enabled = False
    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Dispose()
        End
    End Sub

    Private Sub ReporteOrigenMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteOrigenMaterialToolStripMenuItem.Click
        frm_report_origenMAT.ShowDialog()
    End Sub
End Class