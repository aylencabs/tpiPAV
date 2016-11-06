Public Class frm_proveedor
    Friend row_selected As DataGridViewRow
    '------------------------> Inicio Modificación <------------------------
    'Versión inicial
    'cbaigorria
    '12/09/2016
    '-----------------------------------------------------------------------
    Dim supps As List(Of Supplier)

    Private Sub frm_proveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'sólo se habilita si se selecciona una celda
        btn_editar.Enabled() = False
        btn_borrar.Enabled() = False
        'Llenar grilla
        actualizar_grilla()


    End Sub


    
    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'Cargar nuevo proveedor
        'Dejar todos los campos de la ventana modal vacíos y habilitados
        frm_detalle_proveedor.Text = "Nuevo Proveedor"
        frm_detalle_proveedor.action = frm_detalle_proveedor.Action_type.insert
        frm_detalle_proveedor.ShowDialog()


    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click

        editar_detalle()

    End Sub


    Private Sub llenar_Grid(ByVal lst As List(Of Supplier))
        Dim blocked As String = "NO"
        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_proveedor.Rows.Clear()
        For Each oSupplier In lst
            With oSupplier
                'cargar filas del datagridview a partir de un array de strings
                If .habilitado = 0 Then
                    blocked = "SI"
                Else
                    blocked = "NO"
                End If
                dgv_proveedor.Rows.Add(New String() {.codigo.ToString, .razon_social.ToString, .cuit.ToString, .pais.ToString, .contacto.ToString, .email.ToString, blocked, .id_pais.ToString})

            End With
        Next
    End Sub


    Public Sub actualizar_grilla()
        Dim estado As Integer = -1
        Dim oSupplierService As New SupplierService
        supps = oSupplierService.listSuppliers
        llenar_Grid(supps)

    End Sub
    '--------------------------> Fin Modificación <-------------------------
    'Versión inicial
    'cbaigorria
    '12/09/2016
    '-----------------------------------------------------------------------


    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Verifico que el txtbox no esté vacío
        Dim oSupplierService As New SupplierService
        Dim oSup As New Supplier
        'Dim list As New List(Of Supplier)
        If Not txt_proveedor.Text.ToString = "" Then
            If Not IsNothing(supps) Then
                supps.Clear()
            End If

            oSup = oSupplierService.list_one(Integer.Parse(txt_proveedor.Text.ToString))
            If Not IsNothing(oSup) Then
                supps.Add(oSup)
                llenar_Grid(supps)
                txt_proveedor.Text = ""
            Else
                MsgBox("El proveedor no existe", vbExclamation, "Alerta")
                Exit Sub
            End If
        Else
            actualizar_grilla()
        End If
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Dispose()
    End Sub

    Private Sub dgv_proveedor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_proveedor.CellClick
        btn_editar.Enabled() = True
        btn_borrar.Enabled() = True
        row_selected = dgv_proveedor.CurrentRow
    End Sub

    Private Sub dgv_proveedor_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_proveedor.CellContentDoubleClick
        editar_detalle()
    End Sub

    Private Sub editar_detalle()
        If dgv_proveedor.SelectedRows.Count = 1 Then
            frm_detalle_proveedor.Text = "Editar Proveedor"
            frm_detalle_proveedor.action = frm_detalle_proveedor.Action_type.update
            frm_detalle_proveedor.ShowDialog()

        End If
    End Sub

    Private Sub update_habilitado(ByVal valor As Integer, ByVal descri As String, ByVal descri2 As String)
        If dgv_proveedor.SelectedRows.Count = 1 Then
            Dim oSupplierService As New SupplierService
            Dim oSupplier As New Supplier

            oSupplier = oSupplierService.list_one(Integer.Parse(row_selected.Cells("codigo_proveedor").Value))

            If Not IsNothing(oSupplier) Then
                oSupplier.habilitado = valor
                If oSupplierService.update_Supplier(oSupplier) = 1 Then
                    MsgBox("Proveedor" + descri + "correctamente", vbExclamation, "Alerta")
                    actualizar_grilla()
                Else
                    MsgBox("Error al" + descri2 + "el proveedor", vbCritical, "Alerta")
                End If
            Else
                MsgBox("El proveedor no existe", vbCritical, "Alerta")
            End If

        End If
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        If row_selected.Cells("habilitado").Value = "SI" Then
            update_habilitado(1, " deshabilitado ", " deshabilitar ")
        Else
            update_habilitado(0, " habilitado ", " habilitar ")
        End If
    End Sub
End Class