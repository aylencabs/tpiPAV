<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_origenMAT
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
        Me.DS_orig_matBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_paises = New System.Windows.Forms.Label()
        Me.cbo_paises = New System.Windows.Forms.ComboBox()
        Me.report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Avviamento = New Gestion_Avviamento.DS_Avviamento()
        Me.DT_origenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DS_orig_matBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_origenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackgroundImage = Global.Gestion_Avviamento.My.Resources.Resources.search
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.Location = New System.Drawing.Point(323, 13)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(46, 38)
        Me.btn_update.TabIndex = 0
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_paises
        '
        Me.lbl_paises.AutoSize = True
        Me.lbl_paises.Location = New System.Drawing.Point(12, 21)
        Me.lbl_paises.Name = "lbl_paises"
        Me.lbl_paises.Size = New System.Drawing.Size(166, 23)
        Me.lbl_paises.TabIndex = 1
        Me.lbl_paises.Text = "País origen material:"
        '
        'cbo_paises
        '
        Me.cbo_paises.FormattingEnabled = True
        Me.cbo_paises.Location = New System.Drawing.Point(184, 18)
        Me.cbo_paises.Name = "cbo_paises"
        Me.cbo_paises.Size = New System.Drawing.Size(121, 31)
        Me.cbo_paises.TabIndex = 2
        '
        'report
        '
        ReportDataSource1.Name = "DS_origen"
        ReportDataSource1.Value = Me.DT_origenBindingSource
        Me.report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.report.LocalReport.ReportEmbeddedResource = "Gestion_Avviamento.report_orig_mat.rdlc"
        Me.report.Location = New System.Drawing.Point(12, 57)
        Me.report.Name = "report"
        Me.report.Size = New System.Drawing.Size(991, 515)
        Me.report.TabIndex = 3
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
        'frm_report_origenMAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 584)
        Me.Controls.Add(Me.report)
        Me.Controls.Add(Me.cbo_paises)
        Me.Controls.Add(Me.lbl_paises)
        Me.Controls.Add(Me.btn_update)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_report_origenMAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Materiales por Origen y Volumen"
        CType(Me.DS_orig_matBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Avviamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_origenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents lbl_paises As System.Windows.Forms.Label
    Friend WithEvents cbo_paises As System.Windows.Forms.ComboBox
    Friend WithEvents DS_orig_matBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_origenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Avviamento As Gestion_Avviamento.DS_Avviamento
End Class
