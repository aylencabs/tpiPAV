Public Class frm_edit_mat

    'Enum actions type for save button
    Enum Action_type
        insert
        update
        view
    End Enum

    Public action As Action_type
    Public sel_row As DataGridViewRow

    Dim oServTipoVol As New TipoVolService
    Dim oSuppServ As New SupplierService
    Dim oMatServ As New MaterialService

    Private Sub frm_edit_mat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_detalle_proveedor.llenarCombo(cbo_tipo_vol, oServTipoVol.getAll, "descripcion", "id_tipo_vol")

        dgv_supps.Rows.Clear()
        dgv_supp_assigned.Rows.Clear()

        If action = Action_type.insert Then

            Clear_Components()
            txt_cod.Enabled = False
            cbo_tipo_vol.Enabled = True
            txt_descrip.Enabled = True
            btn_minus.Enabled = True
            btn_plus.Enabled = True
            'cargo la grilla de proveedores de la derecha completa
            llenar_Grid(dgv_supps, oSuppServ.list_active())



        ElseIf action = Action_type.update Then
            txt_cod.Text = Frm_materiales.row_selected.Cells("cod_material").Value.ToString
            txt_cod.Enabled = False
            txt_descrip.Text = Frm_materiales.row_selected.Cells("descrip").Value.ToString
            cbo_tipo_vol.SelectedValue = Integer.Parse(Frm_materiales.row_selected.Cells("tipo_vol").Value.ToString)
            txt_descrip.Enabled = True
            cbo_tipo_vol.Enabled = True
            btn_guardar.Enabled = True
            btn_minus.Enabled = True
            btn_plus.Enabled = True

            'cargar dgv de proveedores asignados y proveedores por asignar
            If oMatServ.get_Rels(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)).Count = 0 Then
                llenar_Grid(dgv_supps, oSuppServ.list_active())
            Else
                llenar_Grid(dgv_supp_assigned, oMatServ.get_Rels(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)))
                'cargar grilla proveedores aún no asignados.
                llenar_Grid(dgv_supps, oMatServ.getNonRel(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)))

            End If
        Else
            txt_cod.Text = Frm_materiales.row_selected.Cells("cod_material").Value.ToString
            txt_cod.Enabled = False
            txt_descrip.Text = Frm_materiales.row_selected.Cells("descrip").Value.ToString
            txt_descrip.Enabled = False
            cbo_tipo_vol.SelectedValue = Integer.Parse(Frm_materiales.row_selected.Cells("tipo_vol").Value.ToString)
            cbo_tipo_vol.Enabled = False
            btn_guardar.Enabled = False
            btn_minus.Enabled = False
            btn_plus.Enabled = False
            'cargar dgv de proveedores asignados y proveedores por asignar
            If oMatServ.get_Rels(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)).Count = 0 Then
                llenar_Grid(dgv_supps, oSuppServ.list_active())
            Else
                llenar_Grid(dgv_supp_assigned, oMatServ.get_Rels(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)))
                'cargar grilla proveedores aún no asignados.
                llenar_Grid(dgv_supps, oMatServ.getNonRel(Long.Parse(Frm_materiales.row_selected.Cells("cod_material").Value.ToString)))
            End If
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'Guarda los cambios
        Dim oMatService As New MaterialService
        Dim oMat As New Material
        If action = Action_type.update Then
            With oMat
                .id_mat = Long.Parse(txt_cod.Text)
                .descripcion = txt_descrip.Text
                .tipo_vol = Integer.Parse(cbo_tipo_vol.SelectedValue.ToString)
                .habilitado = 0
            End With
            If oMatService.update_Mat(oMat, get_rels()) = 0 Then
                MsgBox("Error al actualizar el material" + txt_cod.Text, vbCritical, "Error")
            Else
                MsgBox("Material " + txt_cod.Text + " actualizado correctamente", vbExclamation, "Info")
                Frm_materiales.actualizar_grilla()
                Me.Close()
            End If

        ElseIf action = Action_type.insert Then
            'inserto en la BD
            If validarDatos() = False Then
                With oMat
                    .habilitado = 0
                    .descripcion = txt_descrip.Text.ToString
                    .tipo_vol = Integer.Parse(cbo_tipo_vol.SelectedValue.ToString)
                End With
                If oMatService.insert_mat(oMat, get_rels()) = 0 Then
                    MsgBox("Error al insertar el material", vbCritical, "Error")
                Else
                    MsgBox("Material insertado correctamente", vbExclamation, "Info")
                    Frm_materiales.actualizar_grilla()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plus.Click
        'agrega un proveedor desde la celda de la derecha
        If dgv_supps.Rows.Count <> 0 Then
            sel_row = dgv_supps.SelectedRows(0)
            dgv_supp_assigned.Rows.Add(New String() {sel_row.Cells("cod_proveedor").Value.ToString, sel_row.Cells("raz_social").Value.ToString})
            dgv_supps.Rows.RemoveAt(sel_row.Index)
        End If
    End Sub

    Private Sub btn_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minus.Click
        'Quita un proveedor desde la celda de la izquierda y lo agrega en la celda de la derecha
        If dgv_supp_assigned.Rows.Count <> 0 Then
            sel_row = dgv_supp_assigned.SelectedRows(0)
            dgv_supps.Rows.Add(New String() {sel_row.Cells("cod_prov").Value.ToString, sel_row.Cells("razon_social").Value.ToString})
            dgv_supp_assigned.Rows.RemoveAt(sel_row.Index)
        End If
    End Sub

    Private Sub Clear_Components()
        txt_cod.Text = ""
        txt_descrip.Text = ""
        cbo_tipo_vol.SelectedIndex = -1
        dgv_supps.Rows.Clear()
        dgv_supp_assigned.Rows.Clear()
    End Sub

    Private Sub llenar_Grid(ByVal GRID As DataGridView, ByVal lst As List(Of Supplier))
        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        GRID.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GRID.Rows.Clear()
        For Each oSupplier In lst
            With oSupplier
                'cargar filas del datagridview a partir de un array de strings
                GRID.Rows.Add(New String() {.codigo.ToString, .razon_social.ToString})
            End With
        Next
    End Sub
    Private Function validarDatos() As Boolean
        If String.IsNullOrEmpty(txt_descrip.Text) Or cbo_tipo_vol.SelectedIndex = -1 Then
            Return True
            Exit Function
        Else
            Return False
            Exit Function
        End If
    End Function
    Private Function get_rels() As List(Of Integer)
        Dim supps As New List(Of Integer)
        Dim oMatService As New MaterialService

        For Each row As DataGridViewRow In dgv_supp_assigned.Rows
            supps.Add(Integer.Parse(row.Cells("cod_prov").Value.ToString()))
        Next

        Return supps
    End Function
End Class