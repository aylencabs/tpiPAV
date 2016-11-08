<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_proveedores
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Avviamento = New Gestion_Avviamento.DS_Avviamento()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rep_provs = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DS_Avviamento
        '
        'DS_Avviamento
        '
        Me.DS_Avviamento.DataSetName = "DS_Avviamento"
        Me.DS_Avviamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_generar
        '
        Me.btn_generar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.update
        Me.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_generar.Location = New System.Drawing.Point(12, 12)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(104, 38)
        Me.btn_generar.TabIndex = 1
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rep_provs
        '
        ReportDataSource1.Name = "DS_provs"
        ReportDataSource1.Value = Me.ProveedoresBindingSource
        Me.rep_provs.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rep_provs.LocalReport.ReportEmbeddedResource = "Gestion_Avviamento.listado_proveedor.rdlc"
        Me.rep_provs.Location = New System.Drawing.Point(12, 67)
        Me.rep_provs.Name = "rep_provs"
        Me.rep_provs.Size = New System.Drawing.Size(721, 425)
        Me.rep_provs.TabIndex = 2
        '
        'frm_listado_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 504)
        Me.Controls.Add(Me.rep_provs)
        Me.Controls.Add(Me.btn_generar)
        Me.Name = "frm_listado_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_listado_proveedores"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents rep_provs As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Avviamento As Gestion_Avviamento.DS_Avviamento
End Class
