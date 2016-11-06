Public Class Frm_login


    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click

        ingreso()

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If MessageBox.Show("Seguro que desea salir?", _
        "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
        , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            End
        End If
    End Sub


    Private Sub btn_ingresar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ingresar.Enter
        ingreso()

    End Sub


    Private Sub ingreso()

        Dim oUserService As New UserService
        Dim oUser As User
        If String.IsNullOrEmpty(txt_pass.Text) Or String.IsNullOrEmpty(txt_user.Text) Then
            MsgBox("Usuario y Password son requeridos", vbCritical, "Aviso")
            Exit Sub
        End If

        oUser = oUserService.validarUsuario(txt_user.Text, txt_pass.Text)
        If Not IsNothing(oUser) Then
            Frm_principal.lbl_user.Tag = oUser.id.ToString
            Frm_principal.lbl_user.Text = DateTime.Now.Date + " - " + oUser.email + " | " + oUser.apellido.ToUpper + ", " + oUser.nombre
            Frm_principal.flag = 1
            Me.Close()
        Else
            lbl_mensaje.ForeColor = Color.Red
            lbl_mensaje.Text = "Usuario o clave incorrectos"
        End If

    End Sub
End Class