<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_proveedor
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
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.codigo_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_proveedor, Me.razon_social, Me.CUIT, Me.pais, Me.contacto, Me.email, Me.habilitado, Me.id_pais})
        Me.dgv_proveedor.Location = New System.Drawing.Point(12, 87)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        Me.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedor.Size = New System.Drawing.Size(764, 198)
        Me.dgv_proveedor.TabIndex = 4
        '
        'codigo_proveedor
        '
        Me.codigo_proveedor.HeaderText = "Código"
        Me.codigo_proveedor.Name = "codigo_proveedor"
        Me.codigo_proveedor.ReadOnly = True
        Me.codigo_proveedor.Width = 88
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "Razon Social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = True
        Me.razon_social.Width = 130
        '
        'CUIT
        '
        Me.CUIT.HeaderText = "CUIT"
        Me.CUIT.Name = "CUIT"
        Me.CUIT.ReadOnly = True
        '
        'pais
        '
        Me.pais.HeaderText = "Pais"
        Me.pais.Name = "pais"
        Me.pais.ReadOnly = True
        '
        'contacto
        '
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'habilitado
        '
        Me.habilitado.HeaderText = "Habilitado"
        Me.habilitado.Name = "habilitado"
        Me.habilitado.ReadOnly = True
        '
        'id_pais
        '
        Me.id_pais.HeaderText = ""
        Me.id_pais.Name = "id_pais"
        Me.id_pais.ReadOnly = True
        Me.id_pais.Visible = False
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(166, 29)
        Me.txt_proveedor.MaxLength = 8
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(333, 31)
        Me.txt_proveedor.TabIndex = 8
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(12, 32)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(135, 23)
        Me.lbl_proveedor.TabIndex = 13
        Me.lbl_proveedor.Text = "Cód. Proveedor:"
        '
        'btn_borrar
        '
        Me.btn_borrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.delete
        Me.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_borrar.ForeColor = System.Drawing.Color.Black
        Me.btn_borrar.Location = New System.Drawing.Point(784, 191)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(51, 51)
        Me.btn_borrar.TabIndex = 14
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.edit1
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.ForeColor = System.Drawing.Color.Black
        Me.btn_editar.Location = New System.Drawing.Point(783, 137)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(52, 48)
        Me.btn_editar.TabIndex = 12
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_Buscar.Location = New System.Drawing.Point(512, 26)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(42, 35)
        Me.btn_Buscar.TabIndex = 10
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.add
        Me.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Location = New System.Drawing.Point(783, 87)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(51, 44)
        Me.btn_Nuevo.TabIndex = 9
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources._exit
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Location = New System.Drawing.Point(784, 248)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(51, 37)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'frm_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(845, 306)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.txt_proveedor)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dgv_proveedor)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Proveedores"
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents txt_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents codigo_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_pais As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
