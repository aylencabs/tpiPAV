<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_mat
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbo_tipo_vol = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_vol = New System.Windows.Forms.Label()
        Me.lbl_descrip = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.lbl_cod_mat = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.lbl_supp_assigned = New System.Windows.Forms.Label()
        Me.dgv_supp_assigned = New System.Windows.Forms.DataGridView()
        Me.cod_prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_supps = New System.Windows.Forms.DataGridView()
        Me.lbl_provs = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.cod_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.raz_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_supp_assigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_supps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_tipo_vol
        '
        Me.cbo_tipo_vol.FormattingEnabled = True
        Me.cbo_tipo_vol.Location = New System.Drawing.Point(381, 14)
        Me.cbo_tipo_vol.Name = "cbo_tipo_vol"
        Me.cbo_tipo_vol.Size = New System.Drawing.Size(134, 31)
        Me.cbo_tipo_vol.TabIndex = 36
        '
        'lbl_tipo_vol
        '
        Me.lbl_tipo_vol.AutoSize = True
        Me.lbl_tipo_vol.Location = New System.Drawing.Point(257, 22)
        Me.lbl_tipo_vol.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tipo_vol.Name = "lbl_tipo_vol"
        Me.lbl_tipo_vol.Size = New System.Drawing.Size(120, 23)
        Me.lbl_tipo_vol.TabIndex = 35
        Me.lbl_tipo_vol.Text = "Tipo Volumen:"
        '
        'lbl_descrip
        '
        Me.lbl_descrip.AutoSize = True
        Me.lbl_descrip.Location = New System.Drawing.Point(10, 58)
        Me.lbl_descrip.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_descrip.Name = "lbl_descrip"
        Me.lbl_descrip.Size = New System.Drawing.Size(105, 23)
        Me.lbl_descrip.TabIndex = 34
        Me.lbl_descrip.Text = "Descripción:"
        '
        'txt_descrip
        '
        Me.txt_descrip.Location = New System.Drawing.Point(138, 55)
        Me.txt_descrip.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_descrip.MaxLength = 50
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(377, 31)
        Me.txt_descrip.TabIndex = 33
        '
        'lbl_cod_mat
        '
        Me.lbl_cod_mat.AutoSize = True
        Me.lbl_cod_mat.Location = New System.Drawing.Point(10, 22)
        Me.lbl_cod_mat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_cod_mat.Name = "lbl_cod_mat"
        Me.lbl_cod_mat.Size = New System.Drawing.Size(118, 23)
        Me.lbl_cod_mat.TabIndex = 32
        Me.lbl_cod_mat.Text = "Cód. Material:"
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(138, 14)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cod.MaxLength = 11
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(116, 31)
        Me.txt_cod.TabIndex = 31
        '
        'lbl_supp_assigned
        '
        Me.lbl_supp_assigned.AutoSize = True
        Me.lbl_supp_assigned.Location = New System.Drawing.Point(10, 108)
        Me.lbl_supp_assigned.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_supp_assigned.Name = "lbl_supp_assigned"
        Me.lbl_supp_assigned.Size = New System.Drawing.Size(194, 23)
        Me.lbl_supp_assigned.TabIndex = 38
        Me.lbl_supp_assigned.Text = "Proveedores Enlazados:"
        '
        'dgv_supp_assigned
        '
        Me.dgv_supp_assigned.AllowUserToAddRows = False
        Me.dgv_supp_assigned.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supp_assigned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_supp_assigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_supp_assigned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_prov, Me.razon_social})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_supp_assigned.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_supp_assigned.Location = New System.Drawing.Point(14, 134)
        Me.dgv_supp_assigned.Name = "dgv_supp_assigned"
        Me.dgv_supp_assigned.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supp_assigned.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_supp_assigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supp_assigned.Size = New System.Drawing.Size(256, 150)
        Me.dgv_supp_assigned.TabIndex = 39
        '
        'cod_prov
        '
        Me.cod_prov.HeaderText = "Cód."
        Me.cod_prov.Name = "cod_prov"
        Me.cod_prov.ReadOnly = True
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "Razón Social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = True
        '
        'dgv_supps
        '
        Me.dgv_supps.AllowUserToAddRows = False
        Me.dgv_supps.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_supps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_supps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_supps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_proveedor, Me.raz_social})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_supps.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_supps.Location = New System.Drawing.Point(330, 134)
        Me.dgv_supps.Name = "dgv_supps"
        Me.dgv_supps.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supps.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_supps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supps.Size = New System.Drawing.Size(245, 150)
        Me.dgv_supps.TabIndex = 40
        '
        'lbl_provs
        '
        Me.lbl_provs.AutoSize = True
        Me.lbl_provs.Location = New System.Drawing.Point(326, 108)
        Me.lbl_provs.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_provs.Name = "lbl_provs"
        Me.lbl_provs.Size = New System.Drawing.Size(113, 23)
        Me.lbl_provs.TabIndex = 44
        Me.lbl_provs.Text = "Proveedores:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(385, 296)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(54, 51)
        Me.btn_cancelar.TabIndex = 46
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar.Location = New System.Drawing.Point(163, 296)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(54, 51)
        Me.btn_guardar.TabIndex = 45
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.minus
        Me.btn_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minus.ForeColor = System.Drawing.Color.Black
        Me.btn_minus.Location = New System.Drawing.Point(276, 212)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(47, 44)
        Me.btn_minus.TabIndex = 42
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.pluss
        Me.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_plus.ForeColor = System.Drawing.Color.Black
        Me.btn_plus.Location = New System.Drawing.Point(276, 153)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(47, 44)
        Me.btn_plus.TabIndex = 41
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'cod_proveedor
        '
        Me.cod_proveedor.HeaderText = "Cód."
        Me.cod_proveedor.Name = "cod_proveedor"
        Me.cod_proveedor.ReadOnly = True
        '
        'raz_social
        '
        Me.raz_social.HeaderText = "Razón Social"
        Me.raz_social.Name = "raz_social"
        Me.raz_social.ReadOnly = True
        '
        'frm_edit_mat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 355)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.lbl_provs)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.dgv_supps)
        Me.Controls.Add(Me.dgv_supp_assigned)
        Me.Controls.Add(Me.lbl_supp_assigned)
        Me.Controls.Add(Me.cbo_tipo_vol)
        Me.Controls.Add(Me.lbl_tipo_vol)
        Me.Controls.Add(Me.lbl_descrip)
        Me.Controls.Add(Me.txt_descrip)
        Me.Controls.Add(Me.lbl_cod_mat)
        Me.Controls.Add(Me.txt_cod)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_edit_mat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Material"
        CType(Me.dgv_supp_assigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_supps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_tipo_vol As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo_vol As System.Windows.Forms.Label
    Friend WithEvents lbl_descrip As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cod_mat As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_supp_assigned As System.Windows.Forms.Label
    Friend WithEvents dgv_supp_assigned As System.Windows.Forms.DataGridView
    Friend WithEvents cod_prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_supps As System.Windows.Forms.DataGridView
    Friend WithEvents btn_plus As System.Windows.Forms.Button
    Friend WithEvents btn_minus As System.Windows.Forms.Button
    Friend WithEvents lbl_provs As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents cod_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raz_social As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
