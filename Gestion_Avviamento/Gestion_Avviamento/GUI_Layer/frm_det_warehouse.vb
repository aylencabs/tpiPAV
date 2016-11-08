Public Class frm_det_warehouse

    Enum action_type
        insert
        update
        view
    End Enum
    Public action As action_type
    Private Sub frm_det_warehouse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clear_components()
        If action = action_type.insert Then
            'acciones para inserción
            txt_nro_calle.Enabled = False

        ElseIf action = action_type.update Then
            'si es update....
            txt_nro_calle.Enabled = False
            txt_nro_calle.Text = frm_almacen.row_selected.Cells("").Value.ToString
            txt_desc.Text = frm_almacen.row_selected.Cells("").Value.ToString
            txt_cant.Text = frm_almacen.row_selected.Cells("").Value.ToString
            cb_habilitada.Checked = True

            Else
                'si es view...
                txt_cant.Enabled = False
                txt_desc.Enabled = False
                txt_nro_calle.Enabled = False
                cb_habilitada.Enabled = False
                cbo_vol.Enabled = False
            End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'generar las calles
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub clear_components()
        txt_nro_calle.Text = ""
        cbo_vol.SelectedIndex = -1
        cb_habilitada.Checked = True
        txt_desc.Text = ""
        txt_cant.Text = ""
    End Sub
End Class