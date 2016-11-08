<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_det_warehouse
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
        Me.lbl_id_calle = New System.Windows.Forms.Label()
        Me.txt_nro_calle = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_volume = New System.Windows.Forms.Label()
        Me.cbo_vol = New System.Windows.Forms.ComboBox()
        Me.cb_habilitada = New System.Windows.Forms.CheckBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_id_calle
        '
        Me.lbl_id_calle.AutoSize = True
        Me.lbl_id_calle.Location = New System.Drawing.Point(12, 18)
        Me.lbl_id_calle.Name = "lbl_id_calle"
        Me.lbl_id_calle.Size = New System.Drawing.Size(87, 23)
        Me.lbl_id_calle.TabIndex = 0
        Me.lbl_id_calle.Text = "Nro. calle:"
        '
        'txt_nro_calle
        '
        Me.txt_nro_calle.Location = New System.Drawing.Point(169, 15)
        Me.txt_nro_calle.Name = "txt_nro_calle"
        Me.txt_nro_calle.Size = New System.Drawing.Size(55, 31)
        Me.txt_nro_calle.TabIndex = 1
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(169, 64)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(135, 31)
        Me.txt_desc.TabIndex = 4
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Location = New System.Drawing.Point(12, 67)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(105, 23)
        Me.lbl_desc.TabIndex = 3
        Me.lbl_desc.Text = "Descripción:"
        '
        'lbl_volume
        '
        Me.lbl_volume.AutoSize = True
        Me.lbl_volume.Location = New System.Drawing.Point(12, 114)
        Me.lbl_volume.Name = "lbl_volume"
        Me.lbl_volume.Size = New System.Drawing.Size(120, 23)
        Me.lbl_volume.TabIndex = 5
        Me.lbl_volume.Text = "Tipo Volúmen:"
        '
        'cbo_vol
        '
        Me.cbo_vol.FormattingEnabled = True
        Me.cbo_vol.Location = New System.Drawing.Point(169, 111)
        Me.cbo_vol.Name = "cbo_vol"
        Me.cbo_vol.Size = New System.Drawing.Size(135, 31)
        Me.cbo_vol.TabIndex = 6
        '
        'cb_habilitada
        '
        Me.cb_habilitada.AutoSize = True
        Me.cb_habilitada.Checked = True
        Me.cb_habilitada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_habilitada.Location = New System.Drawing.Point(16, 212)
        Me.cb_habilitada.Name = "cb_habilitada"
        Me.cb_habilitada.Size = New System.Drawing.Size(77, 27)
        Me.cb_habilitada.TabIndex = 8
        Me.cb_habilitada.Text = "Activa"
        Me.cb_habilitada.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(356, 150)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(54, 51)
        Me.btn_exit.TabIndex = 56
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(356, 53)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(54, 51)
        Me.btn_save.TabIndex = 55
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Cant. Ubicaciones:"
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(169, 161)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(55, 31)
        Me.txt_cant.TabIndex = 58
        '
        'frm_det_warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 252)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.cb_habilitada)
        Me.Controls.Add(Me.cbo_vol)
        Me.Controls.Add(Me.lbl_volume)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.txt_nro_calle)
        Me.Controls.Add(Me.lbl_id_calle)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_det_warehouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_id_calle As System.Windows.Forms.Label
    Friend WithEvents txt_nro_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_desc As System.Windows.Forms.Label
    Friend WithEvents lbl_volume As System.Windows.Forms.Label
    Friend WithEvents cbo_vol As System.Windows.Forms.ComboBox
    Friend WithEvents cb_habilitada As System.Windows.Forms.CheckBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cant As System.Windows.Forms.TextBox
End Class
