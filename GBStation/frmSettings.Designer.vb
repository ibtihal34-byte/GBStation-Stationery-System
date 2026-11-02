<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        btnFont = New Button()
        btnColor = New Button()
        btnAbout = New Button()
        btnBack = New Button()
        btnOpenFile = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(213, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(105, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SYSTEM SETTINGS"
        ' 
        ' btnFont
        ' 
        btnFont.Location = New Point(65, 107)
        btnFont.Name = "btnFont"
        btnFont.Size = New Size(104, 23)
        btnFont.TabIndex = 1
        btnFont.Text = "Change Font"
        btnFont.UseVisualStyleBackColor = True
        ' 
        ' btnColor
        ' 
        btnColor.Location = New Point(65, 153)
        btnColor.Name = "btnColor"
        btnColor.Size = New Size(167, 23)
        btnColor.TabIndex = 2
        btnColor.Text = "Change Background Color"
        btnColor.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Location = New Point(65, 195)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(136, 23)
        btnAbout.TabIndex = 3
        btnAbout.Text = "About GBStation"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(439, 289)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Location = New Point(406, 98)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(130, 40)
        btnOpenFile.TabIndex = 5
        btnOpenFile.Text = "Open File"
        btnOpenFile.UseVisualStyleBackColor = True
        ' 
        ' frmSettings
        ' 
        AccessibleName = "frmSettings"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 411)
        Controls.Add(btnOpenFile)
        Controls.Add(btnBack)
        Controls.Add(btnAbout)
        Controls.Add(btnColor)
        Controls.Add(btnFont)
        Controls.Add(lblTitle)
        Name = "frmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnFont As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnOpenFile As Button
End Class
