Public Class frm_add_supp

    Public sel_row As DataGridViewRow
    Public cod_mat As Long = 0

    Private Sub frm_add_supp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oSupServ As New SupplierService
        Dim oMatServ As New MaterialService
        dgv_supp_assigned.Rows.Clear()
        dgv_supps.Rows.Clear()

        dgv_supps.Rows.Clear()
        dgv_supp_assigned.Rows.Clear()
        If oMatServ.get_Rels(cod_mat).Count = 0 Then
            llenar_Grid(dgv_supps, oSupServ.list_active())
        Else
            llenar_Grid(dgv_supp_assigned, oMatServ.get_Rels(cod_mat))
            'cargar grilla proveedores aún no asignados.
            llenar_Grid(dgv_supps, oMatServ.getNonRel(cod_mat))
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'guardar relaciones con proveedor
        Dim supps As New List(Of Integer)
        Dim oMatService As New MaterialService

        For Each row As DataGridViewRow In dgv_supp_assigned.Rows
            supps.Add(Integer.Parse(row.Cells("cod_prov").Value.ToString()))
        Next

        If oMatService.add_rel(cod_mat, supps) = 0 Then
            MsgBox("Error al actualizar las relaciones para el material " + cod_mat.ToString, vbCritical, "Error")
        Else
            MsgBox("Relaciones actualizadas correctamente", vbExclamation, "Info")
            Frm_materiales.actualizar_grilla()
            Me.Close()
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
End Class