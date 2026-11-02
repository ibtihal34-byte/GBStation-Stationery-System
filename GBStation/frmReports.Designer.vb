<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        Label1 = New Label()
        cmbReportType = New ComboBox()
        dgvReports = New DataGridView()
        btnGenerate = New Button()
        btnExport = New Button()
        btnClear = New Button()
        btnBack = New Button()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(408, 64)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(310, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "REPORTS AND RECORDS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(329, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 1
        Label1.Text = "Select Report"
        ' 
        ' cmbReportType
        ' 
        cmbReportType.FormattingEnabled = True
        cmbReportType.Items.AddRange(New Object() {"Product Report", "Customer Report", "Sales Report"})
        cmbReportType.Location = New Point(468, 129)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(121, 23)
        cmbReportType.TabIndex = 2
        ' 
        ' dgvReports
        ' 
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Location = New Point(96, 204)
        dgvReports.Name = "dgvReports"
        dgvReports.Size = New Size(753, 191)
        dgvReports.TabIndex = 3
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(106, 436)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(108, 23)
        btnGenerate.TabIndex = 4
        btnGenerate.Text = "Generate Report"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(282, 436)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(104, 23)
        btnExport.TabIndex = 5
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(494, 436)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(688, 436)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 611)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnExport)
        Controls.Add(btnGenerate)
        Controls.Add(dgvReports)
        Controls.Add(cmbReportType)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Reports"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
End Class
