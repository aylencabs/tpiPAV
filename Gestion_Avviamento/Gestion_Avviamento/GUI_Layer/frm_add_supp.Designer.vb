<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_supp
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lbl_provs = New System.Windows.Forms.Label()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.dgv_supps = New System.Windows.Forms.DataGridView()
        Me.cod_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.raz_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_supp_assigned = New System.Windows.Forms.DataGridView()
        Me.cod_prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_supp_assigned = New System.Windows.Forms.Label()
        Me.lbl_mat = New System.Windows.Forms.Label()
        CType(Me.dgv_supps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_supp_assigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(383, 238)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(54, 51)
        Me.btn_cancelar.TabIndex = 54
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar.Location = New System.Drawing.Point(161, 238)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(54, 51)
        Me.btn_guardar.TabIndex = 53
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lbl_provs
        '
        Me.lbl_provs.AutoSize = True
        Me.lbl_provs.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.lbl_provs.Location = New System.Drawing.Point(324, 50)
        Me.lbl_provs.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_provs.Name = "lbl_provs"
        Me.lbl_provs.Size = New System.Drawing.Size(113, 23)
        Me.lbl_provs.TabIndex = 52
        Me.lbl_provs.Text = "Proveedores:"
        '
        'btn_minus
        '
        Me.btn_minus.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.minus
        Me.btn_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minus.ForeColor = System.Drawing.Color.Black
        Me.btn_minus.Location = New System.Drawing.Point(274, 154)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(47, 44)
        Me.btn_minus.TabIndex = 51
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.pluss
        Me.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_plus.ForeColor = System.Drawing.Color.Black
        Me.btn_plus.Location = New System.Drawing.Point(274, 95)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(47, 44)
        Me.btn_plus.TabIndex = 50
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'dgv_supps
        '
        Me.dgv_supps.AllowUserToAddRows = False
        Me.dgv_supps.AllowUserToDeleteRows = False
        Me.dgv_supps.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_supps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_supps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_proveedor, Me.raz_social})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_supps.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_supps.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_supps.Location = New System.Drawing.Point(328, 76)
        Me.dgv_supps.Name = "dgv_supps"
        Me.dgv_supps.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supps.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_supps.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_supps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supps.Size = New System.Drawing.Size(245, 150)
        Me.dgv_supps.TabIndex = 49
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
        'dgv_supp_assigned
        '
        Me.dgv_supp_assigned.AllowUserToAddRows = False
        Me.dgv_supp_assigned.AllowUserToDeleteRows = False
        Me.dgv_supp_assigned.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supp_assigned.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_supp_assigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_supp_assigned.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_prov, Me.razon_social})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_supp_assigned.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_supp_assigned.Location = New System.Drawing.Point(12, 76)
        Me.dgv_supp_assigned.Name = "dgv_supp_assigned"
        Me.dgv_supp_assigned.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supp_assigned.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_supp_assigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supp_assigned.Size = New System.Drawing.Size(256, 150)
        Me.dgv_supp_assigned.TabIndex = 48
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
        'lbl_supp_assigned
        '
        Me.lbl_supp_assigned.AutoSize = True
        Me.lbl_supp_assigned.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.lbl_supp_assigned.Location = New System.Drawing.Point(8, 50)
        Me.lbl_supp_assigned.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_supp_assigned.Name = "lbl_supp_assigned"
        Me.lbl_supp_assigned.Size = New System.Drawing.Size(194, 23)
        Me.lbl_supp_assigned.TabIndex = 47
        Me.lbl_supp_assigned.Text = "Proveedores Enlazados:"
        '
        'lbl_mat
        '
        Me.lbl_mat.AutoSize = True
        Me.lbl_mat.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.lbl_mat.Location = New System.Drawing.Point(9, 13)
        Me.lbl_mat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_mat.Name = "lbl_mat"
        Me.lbl_mat.Size = New System.Drawing.Size(0, 23)
        Me.lbl_mat.TabIndex = 55
        '
        'frm_add_supp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 310)
        Me.Controls.Add(Me.lbl_mat)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.lbl_provs)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.dgv_supps)
        Me.Controls.Add(Me.dgv_supp_assigned)
        Me.Controls.Add(Me.lbl_supp_assigned)
        Me.Font = New System.Drawing.Font("Calibri", 16.25!)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_add_supp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Proveedor"
        CType(Me.dgv_supps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_supp_assigned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_provs As System.Windows.Forms.Label
    Friend WithEvents btn_minus As System.Windows.Forms.Button
    Friend WithEvents btn_plus As System.Windows.Forms.Button
    Friend WithEvents dgv_supps As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_supp_assigned As System.Windows.Forms.DataGridView
    Friend WithEvents cod_prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_supp_assigned As System.Windows.Forms.Label
    Friend WithEvents lbl_mat As System.Windows.Forms.Label
    Friend WithEvents cod_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raz_social As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
