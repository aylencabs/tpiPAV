<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_principal
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tool_grip_stock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tool_grip_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.tool_grip_admin = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_user = New System.Windows.Forms.Panel()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.ReporteOrigenMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pnl_user.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_grip_stock, Me.tool_grip_report, Me.tool_grip_admin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1215, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tool_grip_stock
        '
        Me.tool_grip_stock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.tool_grip_stock.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tool_grip_stock.Name = "tool_grip_stock"
        Me.tool_grip_stock.Size = New System.Drawing.Size(109, 20)
        Me.tool_grip_stock.Text = "Gestión de Stock"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem1.Text = "Gestión de Proveedores"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem2.Text = "Gestión de Materiales"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReportesToolStripMenuItem.Text = "Gestión de Almacén"
        '
        'tool_grip_report
        '
        Me.tool_grip_report.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteOrigenMaterialToolStripMenuItem})
        Me.tool_grip_report.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tool_grip_report.Name = "tool_grip_report"
        Me.tool_grip_report.Size = New System.Drawing.Size(68, 20)
        Me.tool_grip_report.Text = "Reportes"
        '
        'tool_grip_admin
        '
        Me.tool_grip_admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeUsuariosToolStripMenuItem})
        Me.tool_grip_admin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tool_grip_admin.Name = "tool_grip_admin"
        Me.tool_grip_admin.Size = New System.Drawing.Size(102, 20)
        Me.tool_grip_admin.Text = "Administración"
        '
        'GestiónDeUsuariosToolStripMenuItem
        '
        Me.GestiónDeUsuariosToolStripMenuItem.Name = "GestiónDeUsuariosToolStripMenuItem"
        Me.GestiónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios"
        '
        'pnl_user
        '
        Me.pnl_user.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnl_user.Controls.Add(Me.lbl_user)
        Me.pnl_user.Location = New System.Drawing.Point(0, 25)
        Me.pnl_user.Name = "pnl_user"
        Me.pnl_user.Size = New System.Drawing.Size(1215, 24)
        Me.pnl_user.TabIndex = 3
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(3, 4)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(129, 13)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "ID user - Nombre, Apellido"
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ingreso.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingreso.ForeColor = System.Drawing.Color.Red
        Me.lbl_ingreso.Location = New System.Drawing.Point(374, 214)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(0, 45)
        Me.lbl_ingreso.TabIndex = 1
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salir.Location = New System.Drawing.Point(0, 55)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(44, 43)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'ReporteOrigenMaterialToolStripMenuItem
        '
        Me.ReporteOrigenMaterialToolStripMenuItem.Name = "ReporteOrigenMaterialToolStripMenuItem"
        Me.ReporteOrigenMaterialToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ReporteOrigenMaterialToolStripMenuItem.Text = "Reporte origen Material"
        '
        'Frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.logo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1215, 654)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_ingreso)
        Me.Controls.Add(Me.pnl_user)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avviamento Stock Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnl_user.ResumeLayout(False)
        Me.pnl_user.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tool_grip_stock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tool_grip_report As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tool_grip_admin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_user As System.Windows.Forms.Panel
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents lbl_ingreso As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents ReporteOrigenMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
