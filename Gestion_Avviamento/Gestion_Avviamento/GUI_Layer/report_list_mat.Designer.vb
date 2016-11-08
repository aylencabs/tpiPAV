<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_list_mat
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
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Avviamento = New Gestion_Avviamento.DS_Avviamento()
        Me.DT_origenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.DS_orig_matBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.list_mat = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_origenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_orig_matBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataMember = "Material"
        Me.MaterialBindingSource.DataSource = Me.DS_Avviamento
        '
        'DS_Avviamento
        '
        Me.DS_Avviamento.DataSetName = "DS_Avviamento"
        Me.DS_Avviamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_origenBindingSource
        '
        Me.DT_origenBindingSource.DataMember = "DT_origen"
        Me.DT_origenBindingSource.DataSource = Me.DS_Avviamento
        '
        'btn_generar
        '
        Me.btn_generar.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.update
        Me.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_generar.Location = New System.Drawing.Point(12, 12)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(104, 38)
        Me.btn_generar.TabIndex = 0
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'list_mat
        '
        ReportDataSource1.Name = "DS_mats"
        ReportDataSource1.Value = Me.MaterialBindingSource
        Me.list_mat.LocalReport.DataSources.Add(ReportDataSource1)
        Me.list_mat.LocalReport.ReportEmbeddedResource = "Gestion_Avviamento.listado_mats.rdlc"
        Me.list_mat.Location = New System.Drawing.Point(12, 56)
        Me.list_mat.Name = "list_mat"
        Me.list_mat.Size = New System.Drawing.Size(555, 516)
        Me.list_mat.TabIndex = 1
        '
        'report_list_mat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 584)
        Me.Controls.Add(Me.list_mat)
        Me.Controls.Add(Me.btn_generar)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "report_list_mat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Materiales por Origen y Volumen"
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_origenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_orig_matBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents DS_orig_matBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_origenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Avviamento As Gestion_Avviamento.DS_Avviamento
    Friend WithEvents list_mat As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaterialBindingSource As System.Windows.Forms.BindingSource
End Class
