<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_materiales
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
        Me.lbl_cod_mat = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.lbl_descrip = New System.Windows.Forms.Label()
        Me.txt_descrip = New System.Windows.Forms.TextBox()
        Me.lbl_tipo_vol = New System.Windows.Forms.Label()
        Me.cbo_tipo_vol = New System.Windows.Forms.ComboBox()
        Me.cbo_llena = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_material = New System.Windows.Forms.DataGridView()
        Me.cod_material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip_vol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_vol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_watch = New System.Windows.Forms.Button()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.dgv_material, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cod_mat
        '
        Me.lbl_cod_mat.AutoSize = True
        Me.lbl_cod_mat.Location = New System.Drawing.Point(20, 38)
        Me.lbl_cod_mat.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_cod_mat.Name = "lbl_cod_mat"
        Me.lbl_cod_mat.Size = New System.Drawing.Size(118, 23)
        Me.lbl_cod_mat.TabIndex = 21
        Me.lbl_cod_mat.Text = "Cód. Material:"
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(148, 30)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cod.MaxLength = 8
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(121, 31)
        Me.txt_cod.TabIndex = 20
        '
        'lbl_descrip
        '
        Me.lbl_descrip.AutoSize = True
        Me.lbl_descrip.Location = New System.Drawing.Point(294, 38)
        Me.lbl_descrip.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_descrip.Name = "lbl_descrip"
        Me.lbl_descrip.Size = New System.Drawing.Size(105, 23)
        Me.lbl_descrip.TabIndex = 23
        Me.lbl_descrip.Text = "Descripción:"
        '
        'txt_descrip
        '
        Me.txt_descrip.Location = New System.Drawing.Point(409, 30)
        Me.txt_descrip.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_descrip.MaxLength = 8
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(205, 31)
        Me.txt_descrip.TabIndex = 22
        '
        'lbl_tipo_vol
        '
        Me.lbl_tipo_vol.AutoSize = True
        Me.lbl_tipo_vol.Location = New System.Drawing.Point(20, 75)
        Me.lbl_tipo_vol.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tipo_vol.Name = "lbl_tipo_vol"
        Me.lbl_tipo_vol.Size = New System.Drawing.Size(120, 23)
        Me.lbl_tipo_vol.TabIndex = 29
        Me.lbl_tipo_vol.Text = "Tipo Volumen:"
        '
        'cbo_tipo_vol
        '
        Me.cbo_tipo_vol.FormattingEnabled = True
        Me.cbo_tipo_vol.Location = New System.Drawing.Point(148, 72)
        Me.cbo_tipo_vol.Name = "cbo_tipo_vol"
        Me.cbo_tipo_vol.Size = New System.Drawing.Size(121, 31)
        Me.cbo_tipo_vol.TabIndex = 30
        '
        'cbo_llena
        '
        Me.cbo_llena.FormattingEnabled = True
        Me.cbo_llena.Location = New System.Drawing.Point(409, 72)
        Me.cbo_llena.Name = "cbo_llena"
        Me.cbo_llena.Size = New System.Drawing.Size(205, 31)
        Me.cbo_llena.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Proveedor:"
        '
        'dgv_material
        '
        Me.dgv_material.AllowUserToAddRows = False
        Me.dgv_material.AllowUserToDeleteRows = False
        Me.dgv_material.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_material.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_material, Me.descrip, Me.descrip_vol, Me.proveedor, Me.tipo_vol, Me.id_proveedor, Me.habilitado})
        Me.dgv_material.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_material.Location = New System.Drawing.Point(57, 134)
        Me.dgv_material.Name = "dgv_material"
        Me.dgv_material.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_material.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_material.Size = New System.Drawing.Size(444, 321)
        Me.dgv_material.TabIndex = 33
        '
        'cod_material
        '
        Me.cod_material.HeaderText = "Cód. Material"
        Me.cod_material.Name = "cod_material"
        Me.cod_material.ReadOnly = True
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripción"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        '
        'descrip_vol
        '
        Me.descrip_vol.HeaderText = "Tipo Volúmen"
        Me.descrip_vol.Name = "descrip_vol"
        Me.descrip_vol.ReadOnly = True
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        '
        'tipo_vol
        '
        Me.tipo_vol.HeaderText = "tipo_vol"
        Me.tipo_vol.Name = "tipo_vol"
        Me.tipo_vol.ReadOnly = True
        Me.tipo_vol.Visible = False
        '
        'id_proveedor
        '
        Me.id_proveedor.HeaderText = "id_proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        Me.id_proveedor.ReadOnly = True
        Me.id_proveedor.Visible = False
        '
        'habilitado
        '
        Me.habilitado.HeaderText = "habilitado"
        Me.habilitado.Name = "habilitado"
        Me.habilitado.ReadOnly = True
        Me.habilitado.Visible = False
        '
        'btn_watch
        '
        Me.btn_watch.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search_more
        Me.btn_watch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_watch.ForeColor = System.Drawing.Color.Black
        Me.btn_watch.Location = New System.Drawing.Point(559, 184)
        Me.btn_watch.Name = "btn_watch"
        Me.btn_watch.Size = New System.Drawing.Size(47, 44)
        Me.btn_watch.TabIndex = 35
        Me.btn_watch.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.asignar_proveedor1
        Me.btn_asignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_asignar.ForeColor = System.Drawing.Color.Black
        Me.btn_asignar.Location = New System.Drawing.Point(540, 392)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(91, 44)
        Me.btn_asignar.TabIndex = 34
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.delete
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_borrar.ForeColor = System.Drawing.Color.Black
        Me.btn_borrar.Location = New System.Drawing.Point(559, 294)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(47, 45)
        Me.btn_borrar.TabIndex = 28
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.edit1
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_editar.ForeColor = System.Drawing.Color.Black
        Me.btn_editar.Location = New System.Drawing.Point(559, 234)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(47, 45)
        Me.btn_editar.TabIndex = 27
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_Buscar.Location = New System.Drawing.Point(629, 45)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(48, 43)
        Me.btn_Buscar.TabIndex = 26
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.add
        Me.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Location = New System.Drawing.Point(559, 134)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(47, 44)
        Me.btn_Nuevo.TabIndex = 25
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Location = New System.Drawing.Point(559, 345)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(47, 42)
        Me.btn_cerrar.TabIndex = 24
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Frm_materiales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 501)
        Me.Controls.Add(Me.btn_watch)
        Me.Controls.Add(Me.btn_asignar)
        Me.Controls.Add(Me.dgv_material)
        Me.Controls.Add(Me.cbo_llena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_tipo_vol)
        Me.Controls.Add(Me.lbl_tipo_vol)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_descrip)
        Me.Controls.Add(Me.txt_descrip)
        Me.Controls.Add(Me.lbl_cod_mat)
        Me.Controls.Add(Me.txt_cod)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_materiales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Materiales"
        CType(Me.dgv_material, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cod_mat As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descrip As System.Windows.Forms.Label
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_tipo_vol As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_vol As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_llena As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_material As System.Windows.Forms.DataGridView
    Friend WithEvents cod_material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip_vol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_vol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents btn_watch As System.Windows.Forms.Button
End Class
