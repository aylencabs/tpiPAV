<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle_ingreso
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
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_trace_code = New System.Windows.Forms.TextBox()
        Me.lbl_trace_code = New System.Windows.Forms.Label()
        Me.lbl_fum = New System.Windows.Forms.Label()
        Me.mtb_fum = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_lote = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.mtb_cant = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Location = New System.Drawing.Point(33, 38)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(79, 23)
        Me.lbl_material.TabIndex = 0
        Me.lbl_material.Text = "Material:"
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(130, 35)
        Me.txt_material.MaxLength = 11
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(100, 31)
        Me.txt_material.TabIndex = 1
        '
        'txt_trace_code
        '
        Me.txt_trace_code.Location = New System.Drawing.Point(430, 35)
        Me.txt_trace_code.MaxLength = 23
        Me.txt_trace_code.Name = "txt_trace_code"
        Me.txt_trace_code.Size = New System.Drawing.Size(223, 31)
        Me.txt_trace_code.TabIndex = 3
        '
        'lbl_trace_code
        '
        Me.lbl_trace_code.AutoSize = True
        Me.lbl_trace_code.Location = New System.Drawing.Point(266, 38)
        Me.lbl_trace_code.Name = "lbl_trace_code"
        Me.lbl_trace_code.Size = New System.Drawing.Size(146, 23)
        Me.lbl_trace_code.TabIndex = 2
        Me.lbl_trace_code.Text = "Cod. Trazabilidad:"
        '
        'lbl_fum
        '
        Me.lbl_fum.AutoSize = True
        Me.lbl_fum.Location = New System.Drawing.Point(33, 94)
        Me.lbl_fum.Name = "lbl_fum"
        Me.lbl_fum.Size = New System.Drawing.Size(52, 23)
        Me.lbl_fum.TabIndex = 4
        Me.lbl_fum.Text = "FUM:"
        '
        'mtb_fum
        '
        Me.mtb_fum.Location = New System.Drawing.Point(130, 91)
        Me.mtb_fum.Mask = "00/00/0000"
        Me.mtb_fum.Name = "mtb_fum"
        Me.mtb_fum.Size = New System.Drawing.Size(100, 31)
        Me.mtb_fum.TabIndex = 5
        Me.mtb_fum.ValidatingType = GetType(Date)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(430, 91)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 7
        '
        'lbl_lote
        '
        Me.lbl_lote.AutoSize = True
        Me.lbl_lote.Location = New System.Drawing.Point(266, 94)
        Me.lbl_lote.Name = "lbl_lote"
        Me.lbl_lote.Size = New System.Drawing.Size(162, 23)
        Me.lbl_lote.TabIndex = 6
        Me.lbl_lote.Text = "Lote de Producción:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(299, 205)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(51, 51)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.save
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(176, 205)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(54, 51)
        Me.btn_agregar.TabIndex = 8
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Location = New System.Drawing.Point(33, 143)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(84, 23)
        Me.lbl_cant.TabIndex = 10
        Me.lbl_cant.Text = "Cantidad:"
        '
        'mtb_cant
        '
        Me.mtb_cant.Location = New System.Drawing.Point(130, 140)
        Me.mtb_cant.Mask = "99999"
        Me.mtb_cant.Name = "mtb_cant"
        Me.mtb_cant.Size = New System.Drawing.Size(100, 31)
        Me.mtb_cant.TabIndex = 11
        Me.mtb_cant.ValidatingType = GetType(Integer)
        '
        'frm_detalle_ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 268)
        Me.Controls.Add(Me.mtb_cant)
        Me.Controls.Add(Me.lbl_cant)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_lote)
        Me.Controls.Add(Me.mtb_fum)
        Me.Controls.Add(Me.lbl_fum)
        Me.Controls.Add(Me.txt_trace_code)
        Me.Controls.Add(Me.lbl_trace_code)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.lbl_material)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frm_detalle_ingreso"
        Me.Text = "Detalle ingreso Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_material As System.Windows.Forms.Label
    Friend WithEvents txt_material As System.Windows.Forms.TextBox
    Friend WithEvents txt_trace_code As System.Windows.Forms.TextBox
    Friend WithEvents lbl_trace_code As System.Windows.Forms.Label
    Friend WithEvents lbl_fum As System.Windows.Forms.Label
    Friend WithEvents mtb_fum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_lote As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents mtb_cant As System.Windows.Forms.MaskedTextBox
End Class
