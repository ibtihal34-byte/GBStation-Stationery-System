<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        txtDiscount = New TextBox()
        txtTax = New TextBox()
        lblSubtotal = New Label()
        lblTaxAmount = New Label()
        lblTotal = New Label()
        btnCalculate = New Button()
        btnSave = New Button()
        btnClear = New Button()
        btnBack = New Button()
        dgvSales = New DataGridView()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(130, 76)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(346, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SALES AND TRANSACTIONS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 1
        Label1.Text = "Product Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(105, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 2
        Label2.Text = "Unit Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 3
        Label3.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 4
        Label4.Text = "Discount (%)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(105, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 5
        Label5.Text = "Tax (%)"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(326, 121)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(254, 23)
        txtProductName.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(326, 164)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(264, 23)
        txtPrice.TabIndex = 7
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(326, 203)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(264, 23)
        txtQuantity.TabIndex = 8
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(326, 241)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(264, 23)
        txtDiscount.TabIndex = 9
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(326, 270)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(264, 23)
        txtTax.TabIndex = 10
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(105, 322)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(101, 15)
        lblSubtotal.TabIndex = 11
        lblSubtotal.Text = "Subtotal: KSh 0.00"
        ' 
        ' lblTaxAmount
        ' 
        lblTaxAmount.AutoSize = True
        lblTaxAmount.Location = New Point(105, 349)
        lblTaxAmount.Name = "lblTaxAmount"
        lblTaxAmount.Size = New Size(74, 15)
        lblTaxAmount.TabIndex = 12
        lblTaxAmount.Text = "Tax: KSh 0.00"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(105, 376)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(89, 15)
        lblTotal.TabIndex = 13
        lblTotal.Text = "Total: KSh 0.00"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(105, 411)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(101, 23)
        btnCalculate.TabIndex = 15
        btnCalculate.Text = "Calculate Total"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(286, 411)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 16
        btnSave.Text = "Save Sale"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(428, 411)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(563, 411)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 18
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvSales
        ' 
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(105, 440)
        dgvSales.Name = "dgvSales"
        dgvSales.Size = New Size(691, 150)
        dgvSales.TabIndex = 19
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 611)
        Controls.Add(dgvSales)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(btnCalculate)
        Controls.Add(lblTotal)
        Controls.Add(lblTaxAmount)
        Controls.Add(lblSubtotal)
        Controls.Add(txtTax)
        Controls.Add(txtDiscount)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtProductName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmSales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Sales and Transactions"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvSales As DataGridView
End Class
