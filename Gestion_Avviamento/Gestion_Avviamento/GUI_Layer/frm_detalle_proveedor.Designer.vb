<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle_proveedor
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
        Me.lbl_codigo_proveedor = New System.Windows.Forms.Label()
        Me.lbl_Pais = New System.Windows.Forms.Label()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.lbl_Contacto = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lbl_CUIT = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_codigo_proveedor = New System.Windows.Forms.TextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_CUIT = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_contacto = New System.Windows.Forms.TextBox()
        Me.cb_deshabilitado = New System.Windows.Forms.CheckBox()
        Me.cbo_paises = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_codigo_proveedor
        '
        Me.lbl_codigo_proveedor.AutoSize = True
        Me.lbl_codigo_proveedor.Location = New System.Drawing.Point(12, 21)
        Me.lbl_codigo_proveedor.Name = "lbl_codigo_proveedor"
        Me.lbl_codigo_proveedor.Size = New System.Drawing.Size(135, 23)
        Me.lbl_codigo_proveedor.TabIndex = 0
        Me.lbl_codigo_proveedor.Text = "Cód. Proveedor:"
        '
        'lbl_Pais
        '
        Me.lbl_Pais.AutoSize = True
        Me.lbl_Pais.Location = New System.Drawing.Point(342, 21)
        Me.lbl_Pais.Name = "lbl_Pais"
        Me.lbl_Pais.Size = New System.Drawing.Size(46, 23)
        Me.lbl_Pais.TabIndex = 2
        Me.lbl_Pais.Text = "Pais:"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(38, 59)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(109, 23)
        Me.lbl_razon_social.TabIndex = 4
        Me.lbl_razon_social.Text = "Razon social:"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(307, 59)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(84, 23)
        Me.lbl_Contacto.TabIndex = 6
        Me.lbl_Contacto.Text = "Contacto:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(624, 94)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(54, 51)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar.Location = New System.Drawing.Point(566, 94)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(54, 51)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lbl_CUIT
        '
        Me.lbl_CUIT.AutoSize = True
        Me.lbl_CUIT.Location = New System.Drawing.Point(96, 97)
        Me.lbl_CUIT.Name = "lbl_CUIT"
        Me.lbl_CUIT.Size = New System.Drawing.Size(51, 23)
        Me.lbl_CUIT.TabIndex = 10
        Me.lbl_CUIT.Text = "CUIT:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(329, 97)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(62, 23)
        Me.lbl_email.TabIndex = 6
        Me.lbl_email.Text = "E-mail:"
        '
        'txt_codigo_proveedor
        '
        Me.txt_codigo_proveedor.Location = New System.Drawing.Point(153, 18)
        Me.txt_codigo_proveedor.MaxLength = 23
        Me.txt_codigo_proveedor.Name = "txt_codigo_proveedor"
        Me.txt_codigo_proveedor.Size = New System.Drawing.Size(133, 31)
        Me.txt_codigo_proveedor.TabIndex = 3
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(153, 56)
        Me.txt_razon_social.MaxLength = 100
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(133, 31)
        Me.txt_razon_social.TabIndex = 7
        '
        'txt_CUIT
        '
        Me.txt_CUIT.Location = New System.Drawing.Point(153, 94)
        Me.txt_CUIT.MaxLength = 11
        Me.txt_CUIT.Name = "txt_CUIT"
        Me.txt_CUIT.Size = New System.Drawing.Size(133, 31)
        Me.txt_CUIT.TabIndex = 7
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(397, 94)
        Me.txt_email.MaxLength = 100
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(133, 31)
        Me.txt_email.TabIndex = 12
        '
        'txt_contacto
        '
        Me.txt_contacto.Location = New System.Drawing.Point(397, 56)
        Me.txt_contacto.MaxLength = 100
        Me.txt_contacto.Name = "txt_contacto"
        Me.txt_contacto.Size = New System.Drawing.Size(133, 31)
        Me.txt_contacto.TabIndex = 13
        '
        'cb_deshabilitado
        '
        Me.cb_deshabilitado.AutoSize = True
        Me.cb_deshabilitado.Location = New System.Drawing.Point(555, 20)
        Me.cb_deshabilitado.Name = "cb_deshabilitado"
        Me.cb_deshabilitado.Size = New System.Drawing.Size(124, 27)
        Me.cb_deshabilitado.TabIndex = 15
        Me.cb_deshabilitado.Text = "Desactivado"
        Me.cb_deshabilitado.UseVisualStyleBackColor = True
        '
        'cbo_paises
        '
        Me.cbo_paises.FormattingEnabled = True
        Me.cbo_paises.Location = New System.Drawing.Point(397, 18)
        Me.cbo_paises.Name = "cbo_paises"
        Me.cbo_paises.Size = New System.Drawing.Size(133, 31)
        Me.cbo_paises.TabIndex = 16
        '
        'frm_detalle_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 157)
        Me.Controls.Add(Me.cbo_paises)
        Me.Controls.Add(Me.cb_deshabilitado)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_contacto)
        Me.Controls.Add(Me.lbl_CUIT)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_CUIT)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_Contacto)
        Me.Controls.Add(Me.txt_codigo_proveedor)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Controls.Add(Me.lbl_Pais)
        Me.Controls.Add(Me.lbl_codigo_proveedor)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frm_detalle_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_codigo_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_Pais As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_CUIT As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_codigo_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents txt_CUIT As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_contacto As System.Windows.Forms.TextBox
    Friend WithEvents cb_deshabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_paises As System.Windows.Forms.ComboBox
End Class
