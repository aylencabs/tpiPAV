<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_almacen
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
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_llena = New System.Windows.Forms.Label()
        Me.cbo_llena = New System.Windows.Forms.ComboBox()
        Me.dgv_calles = New System.Windows.Forms.DataGridView()
        Me.id_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_vol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot_ubic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.llena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_vol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.btn_watch = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        CType(Me.dgv_calles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(17, 23)
        Me.lbl_calle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(56, 13)
        Me.lbl_calle.TabIndex = 23
        Me.lbl_calle.Text = "Nro. Calle:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(77, 20)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_calle.MaxLength = 8
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(55, 21)
        Me.txt_calle.TabIndex = 22
        '
        'lbl_llena
        '
        Me.lbl_llena.AutoSize = True
        Me.lbl_llena.Location = New System.Drawing.Point(354, 23)
        Me.lbl_llena.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_llena.Name = "lbl_llena"
        Me.lbl_llena.Size = New System.Drawing.Size(36, 13)
        Me.lbl_llena.TabIndex = 24
        Me.lbl_llena.Text = "Llena:"
        '
        'cbo_llena
        '
        Me.cbo_llena.FormattingEnabled = True
        Me.cbo_llena.Location = New System.Drawing.Point(395, 20)
        Me.cbo_llena.Name = "cbo_llena"
        Me.cbo_llena.Size = New System.Drawing.Size(48, 21)
        Me.cbo_llena.TabIndex = 33
        '
        'dgv_calles
        '
        Me.dgv_calles.AllowUserToAddRows = False
        Me.dgv_calles.AllowUserToDeleteRows = False
        Me.dgv_calles.AllowUserToOrderColumns = True
        Me.dgv_calles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_calles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_calles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_calle, Me.descrip, Me.tipo_vol, Me.tot_ubic, Me.llena, Me.id_vol})
        Me.dgv_calles.Location = New System.Drawing.Point(12, 68)
        Me.dgv_calles.Name = "dgv_calles"
        Me.dgv_calles.ReadOnly = True
        Me.dgv_calles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_calles.Size = New System.Drawing.Size(516, 249)
        Me.dgv_calles.TabIndex = 35
        '
        'id_calle
        '
        Me.id_calle.HeaderText = "Nro. Calle"
        Me.id_calle.Name = "id_calle"
        Me.id_calle.ReadOnly = True
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        '
        'tipo_vol
        '
        Me.tipo_vol.HeaderText = "Tipo Volumen"
        Me.tipo_vol.Name = "tipo_vol"
        Me.tipo_vol.ReadOnly = True
        '
        'tot_ubic
        '
        Me.tot_ubic.HeaderText = "Total Ubicaciones"
        Me.tot_ubic.Name = "tot_ubic"
        Me.tot_ubic.ReadOnly = True
        '
        'llena
        '
        Me.llena.HeaderText = "Llena"
        Me.llena.Name = "llena"
        Me.llena.ReadOnly = True
        '
        'id_vol
        '
        Me.id_vol.HeaderText = "id_vol"
        Me.id_vol.Name = "id_vol"
        Me.id_vol.ReadOnly = True
        Me.id_vol.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Descripción Calle:"
        '
        'txt_descrip
        '
        Me.txt_descrip.Location = New System.Drawing.Point(234, 20)
        Me.txt_descrip.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_descrip.MaxLength = 8
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(88, 21)
        Me.txt_descrip.TabIndex = 36
        '
        'btn_watch
        '
        Me.btn_watch.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search_more
        Me.btn_watch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_watch.ForeColor = System.Drawing.Color.Black
        Me.btn_watch.Location = New System.Drawing.Point(546, 112)
        Me.btn_watch.Name = "btn_watch"
        Me.btn_watch.Size = New System.Drawing.Size(33, 29)
        Me.btn_watch.TabIndex = 42
        Me.btn_watch.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.delete
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_borrar.ForeColor = System.Drawing.Color.Black
        Me.btn_borrar.Location = New System.Drawing.Point(546, 207)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(33, 29)
        Me.btn_borrar.TabIndex = 41
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.edit1
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_editar.ForeColor = System.Drawing.Color.Black
        Me.btn_editar.Location = New System.Drawing.Point(546, 157)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(33, 29)
        Me.btn_editar.TabIndex = 40
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.add
        Me.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Location = New System.Drawing.Point(546, 62)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(33, 29)
        Me.btn_Nuevo.TabIndex = 39
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Location = New System.Drawing.Point(546, 282)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(34, 35)
        Me.btn_cerrar.TabIndex = 38
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_Buscar.Location = New System.Drawing.Point(546, 15)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(34, 28)
        Me.btn_Buscar.TabIndex = 34
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'frm_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 331)
        Me.Controls.Add(Me.btn_watch)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_descrip)
        Me.Controls.Add(Me.dgv_calles)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.cbo_llena)
        Me.Controls.Add(Me.lbl_llena)
        Me.Controls.Add(Me.lbl_calle)
        Me.Controls.Add(Me.txt_calle)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Almacen"
        CType(Me.dgv_calles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_calle As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_llena As System.Windows.Forms.Label
    Friend WithEvents cbo_llena As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents dgv_calles As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_watch As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents id_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_vol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tot_ubic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents llena As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_vol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
