Imports System.Globalization

Public Class frm_detalle_proveedor

    'Enum actions type for save button
    Enum Action_type
        insert
        update
    End Enum

    Public action As Action_type

    Private Sub frm_detalle_proveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim oUserService As New UserService
        'Dim oEstadoService As New EstadoService
        Dim oPaisService As New PaisService

        llenarCombo(cbo_paises, oPaisService.get_all(), "descripcion", "id")
        If action = Action_type.insert Then
            clear_components()

        Else
            With frm_proveedor.row_selected
                'Recuperamos los datos seleccionados
                txt_codigo_proveedor.Text = .Cells("codigo_proveedor").Value
                txt_contacto.Text = .Cells("contacto").Value
                txt_CUIT.Text = Long.Parse(.Cells("cuit").Value)
                txt_email.Text = .Cells("email").Value
                'txt_pais.Text = .Cells("pais").Value
                txt_razon_social.Text = .Cells("razon_social").Value
                cbo_paises.SelectedValue = Integer.Parse(.Cells("id_pais").Value)
                If .Cells("habilitado").Value = "NO" Then
                    cb_deshabilitado.Checked = True
                Else
                    cb_deshabilitado.Checked = False
                End If
            End With
        End If
        txt_codigo_proveedor.Enabled = False

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Not validar() Then
            MsgBox("Verifique los datos ingresados", vbCritical, "Validación de datos")
            Exit Sub
        Else
            'Actualizo/inserto en la base
            Dim oSupplierService As New SupplierService
            Dim oSupplier As New Supplier

            If action = Action_type.insert Then
                'Inserto un nuevo proveedor
                With oSupplier
                    .contacto = txt_contacto.Text.ToString
                    .cuit = Long.Parse(txt_CUIT.Text)
                    .email = txt_email.Text.ToString
                    .id_pais = Integer.Parse(cbo_paises.SelectedValue)
                    .razon_social = txt_razon_social.Text.ToString
                    If cb_deshabilitado.Checked = False Then
                        .habilitado = 0
                    Else
                        .habilitado = 1
                    End If
                End With

                If oSupplierService.insert_supplier(oSupplier) = 1 Then
                    MsgBox("Proveedor insertado correctamente", vbExclamation, "Alerta")
                    frm_proveedor.actualizar_grilla()
                    Me.Close()
                Else
                    MsgBox("Error al insertar", vbCritical, "Alerta")
                End If

            Else
                'Actualizo un proveedor ya existente
                With oSupplier
                    .codigo = Integer.Parse(frm_proveedor.row_selected.Cells("codigo_proveedor").Value)
                    .contacto = txt_contacto.Text.ToString
                    .cuit = Long.Parse(txt_CUIT.Text)
                    .email = txt_email.Text.ToString
                    .id_pais = Integer.Parse(cbo_paises.SelectedValue)
                    .razon_social = txt_razon_social.Text.ToString
                    If cb_deshabilitado.Checked = False Then
                        .habilitado = 0
                    Else
                        .habilitado = 1
                    End If
                End With
                If oSupplierService.update_Supplier(oSupplier) = 1 Then
                    MsgBox("Proveedor actualizado correctamente", vbExclamation, "Alerta")
                    frm_proveedor.actualizar_grilla()
                    Me.Close()
                Else
                    MsgBox("Error al actualizar los datos", vbCritical, "Alerta")
                End If

            End If

        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        frm_proveedor.actualizar_grilla()
        Me.Close()
    End Sub

    Private Function validar() As Boolean
        Dim result As Boolean = False
        'Validamos que el cuit sea numérico
        If IsNumeric(txt_CUIT.Text) And txt_email.Text.Contains("@") And txt_CUIT.Text.Length = 11 And Not IsNothing(cbo_paises.SelectedValue) Then
            result = True
        End If
        Return result
    End Function



    Private Sub clear_components()
        'Procedimiento Clear_components: Permite limpiar todos los campos de un formulario, independientemente del 
        'tipo de control

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = ctrl
                chk.Checked = False
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = ctrl
                rb.Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = ctrl
                cbo.SelectedIndex = -1
            ElseIf (Not TypeOf ctrl Is Label) And (Not TypeOf ctrl Is Button) Then
                ctrl.Text = String.Empty
            End If
            ctrl.Enabled = True
        Next
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        'If IsDBNull(source) Then
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
        'End If
    End Sub



End Class