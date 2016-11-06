Public Class frm_movement


    Private Sub cbo_mov_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_mov_type.SelectedIndexChanged
        If cbo_mov_type.SelectedItem.ToString = "Ingreso" Then

            pan_in.Visible = True
            dgv_ingreso.Visible = True
            btn_add_detalle.Visible = True
            pan_out.Visible() = False

        Else

            pan_out.Visible() = True
            dgv_ingreso.Visible = True
            btn_add_detalle.Visible = True
            pan_in.Visible = False

        End If

    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    'Validar lo siguiente:
    'Fecha de emisión no puede ser mayor a fecha de entrada.
    'pto_vta, remito y proveedor deben ser numéricos

    Private Sub btn_add_detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_detalle.Click
        frm_detalle_ingreso.ShowDialog()
    End Sub
End Class
