Public Class frm_almacen
    Friend row_selected As DataGridViewRow

    Dim streets As List(Of calle)

    Private Sub frm_almacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCalleService As New CalleService
        llenar_Grid(oCalleService.get_all())
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'Creo nueva calle y ubicaciones
        frm_det_warehouse.action = frm_det_warehouse.action_type.insert
        frm_det_warehouse.ShowDialog()
    End Sub

    Private Sub btn_watch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_watch.Click
        'Veo el detalle de la calle ingresada
        If dgv_calles.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar una fila", vbExclamation, "Alerta!")
        Else
            frm_det_warehouse.action = frm_det_warehouse.action_type.view
            row_selected = dgv_calles.SelectedRows(0)
            frm_det_warehouse.ShowDialog()
        End If

    End Sub

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click
        'Genero las ubicaciones para una calle particular
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        'Edito una calle, el tipo de volúmen asignado a la misma y las ubicaciones asociadas.
        If dgv_calles.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar una fila", vbExclamation, "Alerta!")
        Else
            frm_det_warehouse.action = frm_det_warehouse.action_type.update
            row_selected = dgv_calles.SelectedRows(0)
            frm_det_warehouse.ShowDialog()
        End If
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        'Elimino una calle y todas sus ubicaciones, siempre y cuando no tenga ubicaciones ocupadas.
        If 1 = 1 Then

        Else
            MsgBox("No se ha podido eliminar la calle seleccionada", vbExclamation, "Error!")
        End If
    End Sub

    Private Sub llenar_Grid(ByVal lst As List(Of calle))
        Dim llena As String = "NO"
        Dim total As Integer
        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_calles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_calles.Rows.Clear()
        For Each oCalle In lst
            With oCalle
                'cargar filas del datagridview a partir de un array de strings
                If .llena = 1 Then
                    llena = "SI"
                End If
                If IsNothing(.ubicaciones) Then
                    total = 0
                Else
                    total = .ubicaciones.Count
                End If
                dgv_calles.Rows.Add(New String() {.nro_calle.ToString, .descripcion.ToString, .tipo_volumen.ToString, total.ToString, llena.ToString, .id_volumen.ToString})
            End With
        Next
    End Sub


    Public Sub actualizar_grilla()
        Dim oCalleService As New CalleService
        Dim llena As Integer = 0

        If cbo_llena.SelectedItem.ToString = "SI" Then
            llena = 1
        End If
        If String.IsNullOrEmpty(txt_calle.Text) Then
            streets = oCalleService.get_all(-1, txt_descrip.Text, llena)
        Else
            streets = oCalleService.get_all(Integer.Parse(txt_calle.Text), txt_descrip.Text, llena)
        End If

        llenar_Grid(streets)
    End Sub

End Class