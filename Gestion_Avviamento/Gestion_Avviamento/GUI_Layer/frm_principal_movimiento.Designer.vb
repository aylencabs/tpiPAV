<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_movement
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
        Me.lbl_type_movement = New System.Windows.Forms.Label()
        Me.cbo_mov_type = New System.Windows.Forms.ComboBox()
        Me.pan_in = New System.Windows.Forms.Panel()
        Me.mtb_fecha_entrada = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fecha_emision = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecha_entrada = New System.Windows.Forms.Label()
        Me.lbl_fecha_emision = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.txt_remito = New System.Windows.Forms.TextBox()
        Me.lbl_remito = New System.Windows.Forms.Label()
        Me.txt_pro_vta = New System.Windows.Forms.TextBox()
        Me.lbl_pto_vta = New System.Windows.Forms.Label()
        Me.pan_out = New System.Windows.Forms.Panel()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_solicitante = New System.Windows.Forms.TextBox()
        Me.lbl_solicitante = New System.Windows.Forms.Label()
        Me.dgv_ingreso = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trace_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add_detalle = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.pan_in.SuspendLayout()
        Me.pan_out.SuspendLayout()
        CType(Me.dgv_ingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_type_movement
        '
        Me.lbl_type_movement.AutoSize = True
        Me.lbl_type_movement.Location = New System.Drawing.Point(41, 26)
        Me.lbl_type_movement.Name = "lbl_type_movement"
        Me.lbl_type_movement.Size = New System.Drawing.Size(249, 23)
        Me.lbl_type_movement.TabIndex = 0
        Me.lbl_type_movement.Text = "Seleccione tipo de movimiento:"
        '
        'cbo_mov_type
        '
        Me.cbo_mov_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cbo_mov_type.FormattingEnabled = True
        Me.cbo_mov_type.Items.AddRange(New Object() {"Ingreso", "Egreso"})
        Me.cbo_mov_type.Location = New System.Drawing.Point(296, 23)
        Me.cbo_mov_type.Name = "cbo_mov_type"
        Me.cbo_mov_type.Size = New System.Drawing.Size(121, 31)
        Me.cbo_mov_type.TabIndex = 1
        '
        'pan_in
        '
        Me.pan_in.Controls.Add(Me.mtb_fecha_entrada)
        Me.pan_in.Controls.Add(Me.mtb_fecha_emision)
        Me.pan_in.Controls.Add(Me.lbl_fecha_entrada)
        Me.pan_in.Controls.Add(Me.lbl_fecha_emision)
        Me.pan_in.Controls.Add(Me.txt_proveedor)
        Me.pan_in.Controls.Add(Me.lbl_proveedor)
        Me.pan_in.Controls.Add(Me.txt_remito)
        Me.pan_in.Controls.Add(Me.lbl_remito)
        Me.pan_in.Controls.Add(Me.txt_pro_vta)
        Me.pan_in.Controls.Add(Me.lbl_pto_vta)
        Me.pan_in.Location = New System.Drawing.Point(45, 94)
        Me.pan_in.Name = "pan_in"
        Me.pan_in.Size = New System.Drawing.Size(808, 133)
        Me.pan_in.TabIndex = 2
        Me.pan_in.Visible = False
        '
        'mtb_fecha_entrada
        '
        Me.mtb_fecha_entrada.Location = New System.Drawing.Point(421, 64)
        Me.mtb_fecha_entrada.Mask = "00/00/0000"
        Me.mtb_fecha_entrada.Name = "mtb_fecha_entrada"
        Me.mtb_fecha_entrada.Size = New System.Drawing.Size(100, 31)
        Me.mtb_fecha_entrada.TabIndex = 11
        Me.mtb_fecha_entrada.ValidatingType = GetType(Date)
        '
        'mtb_fecha_emision
        '
        Me.mtb_fecha_emision.Location = New System.Drawing.Point(161, 64)
        Me.mtb_fecha_emision.Mask = "00/00/0000"
        Me.mtb_fecha_emision.Name = "mtb_fecha_emision"
        Me.mtb_fecha_emision.Size = New System.Drawing.Size(100, 31)
        Me.mtb_fecha_emision.TabIndex = 10
        Me.mtb_fecha_emision.ValidatingType = GetType(Date)
        '
        'lbl_fecha_entrada
        '
        Me.lbl_fecha_entrada.AutoSize = True
        Me.lbl_fecha_entrada.Location = New System.Drawing.Point(291, 67)
        Me.lbl_fecha_entrada.Name = "lbl_fecha_entrada"
        Me.lbl_fecha_entrada.Size = New System.Drawing.Size(124, 23)
        Me.lbl_fecha_entrada.TabIndex = 8
        Me.lbl_fecha_entrada.Text = "Fecha Entrada:"
        '
        'lbl_fecha_emision
        '
        Me.lbl_fecha_emision.AutoSize = True
        Me.lbl_fecha_emision.Location = New System.Drawing.Point(27, 67)
        Me.lbl_fecha_emision.Name = "lbl_fecha_emision"
        Me.lbl_fecha_emision.Size = New System.Drawing.Size(124, 23)
        Me.lbl_fecha_emision.TabIndex = 6
        Me.lbl_fecha_emision.Text = "Fecha Emisión:"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(665, 14)
        Me.txt_proveedor.MaxLength = 8
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(100, 31)
        Me.txt_proveedor.TabIndex = 5
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(566, 17)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(96, 23)
        Me.lbl_proveedor.TabIndex = 4
        Me.lbl_proveedor.Text = "Proveedor:"
        '
        'txt_remito
        '
        Me.txt_remito.Location = New System.Drawing.Point(419, 14)
        Me.txt_remito.MaxLength = 8
        Me.txt_remito.Name = "txt_remito"
        Me.txt_remito.Size = New System.Drawing.Size(100, 31)
        Me.txt_remito.TabIndex = 3
        '
        'lbl_remito
        '
        Me.lbl_remito.AutoSize = True
        Me.lbl_remito.Location = New System.Drawing.Point(292, 17)
        Me.lbl_remito.Name = "lbl_remito"
        Me.lbl_remito.Size = New System.Drawing.Size(69, 23)
        Me.lbl_remito.TabIndex = 2
        Me.lbl_remito.Text = "Remito:"
        '
        'txt_pro_vta
        '
        Me.txt_pro_vta.Location = New System.Drawing.Point(161, 14)
        Me.txt_pro_vta.MaxLength = 4
        Me.txt_pro_vta.Name = "txt_pro_vta"
        Me.txt_pro_vta.Size = New System.Drawing.Size(100, 31)
        Me.txt_pro_vta.TabIndex = 1
        '
        'lbl_pto_vta
        '
        Me.lbl_pto_vta.AutoSize = True
        Me.lbl_pto_vta.Location = New System.Drawing.Point(23, 17)
        Me.lbl_pto_vta.Name = "lbl_pto_vta"
        Me.lbl_pto_vta.Size = New System.Drawing.Size(132, 23)
        Me.lbl_pto_vta.TabIndex = 0
        Me.lbl_pto_vta.Text = "Punto de Venta:"
        '
        'pan_out
        '
        Me.pan_out.Controls.Add(Me.txt_motivo)
        Me.pan_out.Controls.Add(Me.Label2)
        Me.pan_out.Controls.Add(Me.txt_solicitante)
        Me.pan_out.Controls.Add(Me.lbl_solicitante)
        Me.pan_out.Location = New System.Drawing.Point(45, 87)
        Me.pan_out.Name = "pan_out"
        Me.pan_out.Size = New System.Drawing.Size(808, 140)
        Me.pan_out.TabIndex = 3
        Me.pan_out.Visible = False
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(419, 12)
        Me.txt_motivo.MaxLength = 8
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(346, 31)
        Me.txt_motivo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Motivo:"
        '
        'txt_solicitante
        '
        Me.txt_solicitante.Location = New System.Drawing.Point(161, 12)
        Me.txt_solicitante.MaxLength = 4
        Me.txt_solicitante.Name = "txt_solicitante"
        Me.txt_solicitante.Size = New System.Drawing.Size(100, 31)
        Me.txt_solicitante.TabIndex = 7
        '
        'lbl_solicitante
        '
        Me.lbl_solicitante.AutoSize = True
        Me.lbl_solicitante.Location = New System.Drawing.Point(23, 15)
        Me.lbl_solicitante.Name = "lbl_solicitante"
        Me.lbl_solicitante.Size = New System.Drawing.Size(94, 23)
        Me.lbl_solicitante.TabIndex = 6
        Me.lbl_solicitante.Text = "Solicitante:"
        '
        'dgv_ingreso
        '
        Me.dgv_ingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ingreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.cant, Me.fum, Me.trace_code, Me.lote})
        Me.dgv_ingreso.Location = New System.Drawing.Point(45, 244)
        Me.dgv_ingreso.Name = "dgv_ingreso"
        Me.dgv_ingreso.Size = New System.Drawing.Size(544, 187)
        Me.dgv_ingreso.TabIndex = 4
        Me.dgv_ingreso.Visible = False
        '
        'material
        '
        Me.material.HeaderText = "Material"
        Me.material.Name = "material"
        '
        'cant
        '
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        '
        'fum
        '
        Me.fum.HeaderText = "FUM"
        Me.fum.Name = "fum"
        '
        'trace_code
        '
        Me.trace_code.HeaderText = "Cod. Trazabilidad"
        Me.trace_code.Name = "trace_code"
        '
        'lote
        '
        Me.lote.HeaderText = "Lote Producción"
        Me.lote.Name = "lote"
        '
        'btn_add_detalle
        '
        Me.btn_add_detalle.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.add
        Me.btn_add_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add_detalle.ForeColor = System.Drawing.Color.Black
        Me.btn_add_detalle.Location = New System.Drawing.Point(595, 244)
        Me.btn_add_detalle.Name = "btn_add_detalle"
        Me.btn_add_detalle.Size = New System.Drawing.Size(48, 38)
        Me.btn_add_detalle.TabIndex = 5
        Me.btn_add_detalle.UseVisualStyleBackColor = True
        Me.btn_add_detalle.Visible = False
        '
        'btn_registrar
        '
        Me.btn_registrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_registrar.ForeColor = System.Drawing.Color.Black
        Me.btn_registrar.Location = New System.Drawing.Point(76, 471)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(51, 49)
        Me.btn_registrar.TabIndex = 6
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(140, 471)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(56, 49)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_movement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 548)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_add_detalle)
        Me.Controls.Add(Me.dgv_ingreso)
        Me.Controls.Add(Me.pan_out)
        Me.Controls.Add(Me.pan_in)
        Me.Controls.Add(Me.cbo_mov_type)
        Me.Controls.Add(Me.lbl_type_movement)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_movement"
        Me.Text = "Movimiento de Material"
        Me.pan_in.ResumeLayout(False)
        Me.pan_in.PerformLayout()
        Me.pan_out.ResumeLayout(False)
        Me.pan_out.PerformLayout()
        CType(Me.dgv_ingreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_type_movement As System.Windows.Forms.Label
    Friend WithEvents cbo_mov_type As System.Windows.Forms.ComboBox
    Friend WithEvents pan_in As System.Windows.Forms.Panel
    Friend WithEvents mtb_fecha_entrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fecha_emision As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fecha_entrada As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_emision As System.Windows.Forms.Label
    Friend WithEvents txt_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents txt_remito As System.Windows.Forms.TextBox
    Friend WithEvents lbl_remito As System.Windows.Forms.Label
    Friend WithEvents lbl_pto_vta As System.Windows.Forms.Label
    Friend WithEvents pan_out As System.Windows.Forms.Panel
    Friend WithEvents txt_motivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_solicitante As System.Windows.Forms.Label
    Friend WithEvents dgv_ingreso As System.Windows.Forms.DataGridView
    Friend WithEvents material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trace_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_add_detalle As System.Windows.Forms.Button
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_solicitante As System.Windows.Forms.TextBox
    Friend WithEvents txt_pro_vta As System.Windows.Forms.TextBox

End Class
