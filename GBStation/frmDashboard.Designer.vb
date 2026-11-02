<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        components = New ComponentModel.Container()
        lblDashboardTitle = New Label()
        lblWelcome = New Label()
        btnProducts = New Button()
        btnCustomers = New Button()
        btnSales = New Button()
        btnReports = New Button()
        btnSettings = New Button()
        btnLogout = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ProductsToolStripMenuItem = New ToolStripMenuItem()
        CustomersToolStripMenuItem = New ToolStripMenuItem()
        SalesToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        GenerateReportsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ctxProducts = New ToolStripMenuItem()
        ctxCustomers = New ToolStripMenuItem()
        ctxRefresh = New ToolStripMenuItem()
        ctxExit = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.Location = New Point(71, 48)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(700, 50)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = "GBSTATION STATIONERY SUPPLIES SYSTEM"
        lblDashboardTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(233, 112)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(254, 20)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome to GBStation Management System"
        ' 
        ' btnProducts
        ' 
        btnProducts.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProducts.Location = New Point(116, 167)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(250, 60)
        btnProducts.TabIndex = 2
        btnProducts.Text = "Product Management "
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCustomers.Location = New Point(412, 167)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(250, 60)
        btnCustomers.TabIndex = 3
        btnCustomers.Text = "Customer Management"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnSales
        ' 
        btnSales.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSales.Location = New Point(116, 253)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(250, 60)
        btnSales.TabIndex = 4
        btnSales.Text = "Sales and Transactions"
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = SystemColors.ButtonHighlight
        btnReports.DialogResult = DialogResult.TryAgain
        btnReports.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReports.Location = New Point(412, 253)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(250, 60)
        btnReports.TabIndex = 5
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSettings.Location = New Point(116, 337)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(250, 60)
        btnSettings.TabIndex = 6
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(412, 337)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(250, 60)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ReportToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(984, 24)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductsToolStripMenuItem, CustomersToolStripMenuItem, SalesToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ProductsToolStripMenuItem
        ' 
        ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        ProductsToolStripMenuItem.Size = New Size(129, 22)
        ProductsToolStripMenuItem.Text = "products"
        ' 
        ' CustomersToolStripMenuItem
        ' 
        CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        CustomersToolStripMenuItem.Size = New Size(129, 22)
        CustomersToolStripMenuItem.Text = "customers"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(129, 22)
        SalesToolStripMenuItem.Text = "sales"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(129, 22)
        ExitToolStripMenuItem.Text = "exit"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GenerateReportsToolStripMenuItem})
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(59, 20)
        ReportToolStripMenuItem.Text = "Reports"
        ' 
        ' GenerateReportsToolStripMenuItem
        ' 
        GenerateReportsToolStripMenuItem.Name = "GenerateReportsToolStripMenuItem"
        GenerateReportsToolStripMenuItem.Size = New Size(164, 22)
        GenerateReportsToolStripMenuItem.Text = "Generate Reports"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ctxProducts, ctxCustomers, ctxRefresh, ctxExit})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(132, 92)
        ' 
        ' ctxProducts
        ' 
        ctxProducts.Name = "ctxProducts"
        ctxProducts.Size = New Size(131, 22)
        ctxProducts.Text = "Products"
        ' 
        ' ctxCustomers
        ' 
        ctxCustomers.Name = "ctxCustomers"
        ctxCustomers.Size = New Size(131, 22)
        ctxCustomers.Text = "Customers"
        ' 
        ' ctxRefresh
        ' 
        ctxRefresh.Name = "ctxRefresh"
        ctxRefresh.Size = New Size(131, 22)
        ctxRefresh.Text = "Refresh"
        ' 
        ' ctxExit
        ' 
        ctxExit.Name = "ctxExit"
        ctxExit.Size = New Size(131, 22)
        ctxExit.Text = "Exit"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(984, 561)
        ContextMenuStrip = ContextMenuStrip1
        Controls.Add(btnLogout)
        Controls.Add(btnSettings)
        Controls.Add(btnReports)
        Controls.Add(btnSales)
        Controls.Add(btnCustomers)
        Controls.Add(btnProducts)
        Controls.Add(lblWelcome)
        Controls.Add(lblDashboardTitle)
        Controls.Add(MenuStrip1)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Dashboard"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ctxProducts As ToolStripMenuItem
    Friend WithEvents ctxCustomers As ToolStripMenuItem
    Friend WithEvents ctxRefresh As ToolStripMenuItem
    Friend WithEvents ctxExit As ToolStripMenuItem
End Class
