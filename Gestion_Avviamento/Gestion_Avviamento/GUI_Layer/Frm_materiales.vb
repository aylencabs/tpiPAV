Public Class Frm_materiales

    Friend row_selected As DataGridViewRow

    Dim mats As List(Of Material)

    Private Sub Frm_materiales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oServVol As New TipoVolService
        Dim oServSupp As New SupplierService

        frm_detalle_proveedor.llenarCombo(cbo_tipo_vol, oServVol.getAll(), "descripcion", "id_tipo_vol")
        frm_detalle_proveedor.llenarCombo(cbo_llena, oServSupp.list_active(), "razon_social", "codigo")
        btn_editar.Enabled = False
        btn_asignar.Enabled = False
        btn_borrar.Enabled = False
        btn_watch.Enabled = False
        actualizar_grilla()
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_watch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_watch.Click
        'Abre ventana modal con todos los componentes deshabilitados
        watch()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'Abre ventana modal con campos en blanco y habilitados
        frm_edit_mat.action = frm_edit_mat.Action_type.insert
        frm_edit_mat.Text = "Nuevo Material"
        frm_edit_mat.ShowDialog()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        'Abre ventana modal con datos seleccionados, permite editar algunos datos
        Edit()
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        'Cambia el check "habilitado" del material a = 1
        Dim oMatServ As New MaterialService
        row_selected = dgv_material.SelectedRows(0)
        If oMatServ.delete_mat(Long.Parse(row_selected.Cells("cod_material").Value.ToString)) Then
            MsgBox("Material " + row_selected.Cells("cod_material").Value.ToString + "eliminado correctamente", vbExclamation, "Info")
            actualizar_grilla()
        Else
            MsgBox("Error al eliminar el material" + row_selected.Cells("cod_material").Value.ToString, vbCritical, "Error")
        End If
    End Sub

    Private Sub btn_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asignar.Click
        'Abre ventana modal, permite ver los proveedores asignados a ese material y agregar nuevos
        'Cambiar título ventana, indicando número de material
        row_selected = dgv_material.SelectedRows(0)
        frm_add_supp.cod_mat = Long.Parse(row_selected.Cells("cod_material").Value.ToString)
        frm_add_supp.lbl_mat.Text = row_selected.Cells("cod_material").Value.ToString + " - " + row_selected.Cells("descrip").Value.ToString
        frm_add_supp.ShowDialog()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Filtra los datos a mostrar en la grilla
        actualizar_grilla()
    End Sub

    Private Sub dgv_material_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_material.CellContentClick
        btn_borrar.Enabled = True
        btn_asignar.Enabled = True
        btn_editar.Enabled = True
        btn_watch.Enabled = True
        row_selected = dgv_material.SelectedRows(0)
    End Sub

    Private Sub llenar_Grid(ByVal lst As List(Of Material))
        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_material.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_material.Rows.Clear()
        For Each oMaterial In lst
            With oMaterial
                'cargar filas del datagridview a partir de un array de strings
                dgv_material.Rows.Add(New String() {.id_mat.ToString, .descripcion.ToString, .descr_vol.ToString, .prov.ToString, .tipo_vol.ToString, .id_prov.ToString, .habilitado.ToString})
            End With
        Next
    End Sub


    Public Sub actualizar_grilla()
        Dim estado As Integer = -1
        Dim oMatService As New MaterialService

        If String.IsNullOrEmpty(txt_cod.Text) Then
            mats = oMatService.listMaterials(-1, txt_descrip.Text, cbo_llena.SelectedValue, cbo_tipo_vol.SelectedValue)
        Else
            mats = oMatService.listMaterials(txt_cod.Text, txt_descrip.Text, cbo_llena.SelectedValue, cbo_tipo_vol.SelectedValue)
        End If

        llenar_Grid(mats)

    End Sub

    Private Sub dgv_material_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_material.CellContentDoubleClick
        'Permite ver los datos del material
        watch()
    End Sub

    Private Sub Edit()
        row_selected = dgv_material.SelectedRows(0)
        frm_edit_mat.Text = "Editar material " + row_selected.Cells("descrip").Value.ToString
        frm_edit_mat.action = frm_edit_mat.Action_type.update
        frm_edit_mat.ShowDialog()
    End Sub
    Private Sub watch()
        row_selected = dgv_material.SelectedRows(0)
        frm_edit_mat.Text = row_selected.Cells("cod_material").Value.ToString + " - " + row_selected.Cells("descrip").Value.ToString
        frm_edit_mat.action = frm_edit_mat.Action_type.view
        frm_edit_mat.ShowDialog()
    End Sub
End Class

