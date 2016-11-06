<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(12, 24)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(44, 13)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(12, 50)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(62, 13)
        Me.lbl_pass.TabIndex = 1
        Me.lbl_pass.Text = "Contraseña"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(85, 21)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(100, 21)
        Me.txt_user.TabIndex = 2
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(85, 47)
        Me.txt_pass.MaxLength = 8
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(100, 21)
        Me.txt_pass.TabIndex = 3
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(40, 105)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje.TabIndex = 6
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.salir
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.Location = New System.Drawing.Point(125, 90)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(44, 43)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.ingresar
        Me.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ingresar.Location = New System.Drawing.Point(28, 90)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(45, 43)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(202, 149)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
End Class
