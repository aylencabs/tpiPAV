Public Class frm_det_warehouse

    Enum action_type
        insert
        update
        view
    End Enum
    Public action As action_type
    Private Sub frm_det_warehouse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oServVol As New TipoVolService
        clear_components()
        frm_detalle_proveedor.llenarCombo(cbo_vol, oServVol.getAll(), "descripcion", "id_tipo_vol")
        If action = action_type.insert Then
            'acciones para inserción
            txt_nro_calle.Enabled = False

        ElseIf action = action_type.update Then
            'si es update....
            txt_nro_calle.Enabled = False
            txt_nro_calle.Text = frm_almacen.row_selected.Cells("id_calle").Value.ToString
            txt_desc.Text = frm_almacen.row_selected.Cells("descrip").Value.ToString
            txt_cant.Text = frm_almacen.row_selected.Cells("tot_ubic").Value.ToString
            cb_habilitada.Checked = True
            cbo_vol.SelectedValue = Integer.Parse(frm_almacen.row_selected.Cells("id_vol").Value.ToString)

            Else
                'si es view...
            txt_nro_calle.Enabled = False
            txt_nro_calle.Text = frm_almacen.row_selected.Cells("id_calle").Value.ToString
            txt_desc.Text = frm_almacen.row_selected.Cells("descrip").Value.ToString
            txt_cant.Text = frm_almacen.row_selected.Cells("tot_ubic").Value.ToString
            cb_habilitada.Checked = True
            cbo_vol.SelectedValue = Integer.Parse(frm_almacen.row_selected.Cells("id_vol").Value.ToString)

            txt_cant.Enabled = False
                txt_desc.Enabled = False
            cb_habilitada.Enabled = False
            cbo_vol.Enabled = False
            btn_save.Enabled = False
            End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'generar las calles
        If validar() Then
            Dim cant As Integer = Integer.Parse(txt_cant.Text)
            If action = action_type.insert Then
                Dim street As New calle
                Dim oWarehouseServ As New CalleService
                street.descripcion = txt_desc.Text
                street.id_volumen = Integer.Parse(cbo_vol.SelectedValue.ToString)
                If cb_habilitada.Checked = False Then
                    street.habilitada = 1
                Else
                    street.habilitada = 0
                End If
                If oWarehouseServ.add_street(street, cant) <> 0 Then
                    MsgBox("La calle y sus " + txt_cant.Text + " ubicacion/es se han creado correctamente", vbExclamation, "Éxito")
                    frm_almacen.actualizar_grilla()
                    Me.Dispose()
                    Me.Close()
                Else
                    MsgBox("Ha ocurrido un error al insertar la calle y sus ubicaciones", vbExclamation, "Error")
                End If
            Else
                Dim street As New calle
                Dim oWarehouseServ As New CalleService

                street.nro_calle = Integer.Parse(txt_nro_calle.Text)
                street.descripcion = txt_desc.Text
                street.id_volumen = Integer.Parse(cbo_vol.SelectedValue.ToString)
                If cb_habilitada.Checked = False Then
                    street.habilitada = 1
                Else
                    street.habilitada = 0
                End If
                If Not Integer.Parse(frm_almacen.row_selected.Cells("tot_ubic").Value.ToString) <> Integer.Parse(txt_cant.Text) Then
                    cant = -1
                End If
                If oWarehouseServ.edit_street(street, cant) = 1 Then
                    MsgBox("La calle y sus " + txt_cant.Text + " ubicacion/es se han actualizado correctamente", vbExclamation, "Éxito")
                    frm_almacen.actualizar_grilla()
                    Me.Dispose()
                    Me.Close()
                Else
                    MsgBox("Ha ocurrido un error al actualizar la calle y sus ubicaciones", vbExclamation, "Error")
                End If
            End If

        End If
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

    Private Function validar() As Boolean
        Dim ret As Boolean = False
        If IsNumeric(txt_cant.Text.ToString) And Not String.IsNullOrWhiteSpace(txt_desc.Text.ToString) Then
            '& Integer.Parse(cbo_vol.SelectedIndex.ToString) <> -1 Then
            ret = True
        End If
        Return ret
    End Function
End Class