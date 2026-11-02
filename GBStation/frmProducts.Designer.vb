<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        txtProductID = New TextBox()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnBack = New Button()
        dgvProducts = New DataGridView()
        Label5 = New Label()
        txtSearch = New TextBox()
        btnCopy = New Button()
        btnPaste = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(284, 54)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(309, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "PRODUCT MANAGEMENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(121, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 1
        Label1.Text = "Product ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 2
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(121, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 3
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(121, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 4
        Label4.Text = "Quantity"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(373, 123)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(246, 23)
        txtProductID.TabIndex = 5
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(373, 169)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(246, 23)
        txtProductName.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(373, 217)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(246, 23)
        txtPrice.TabIndex = 7
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(373, 260)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(246, 23)
        txtQuantity.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(121, 319)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(110, 35)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add Product"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(282, 319)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 35)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(428, 319)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 35)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(556, 319)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(110, 35)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(716, 319)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 35)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(121, 429)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.Size = New Size(652, 102)
        dgvProducts.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(233, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 15
        Label5.Text = "Search Product:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(458, 376)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 16
        ' 
        ' btnCopy
        ' 
        btnCopy.Location = New Point(698, 143)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(154, 23)
        btnCopy.TabIndex = 17
        btnCopy.Text = "Copy Product Name"
        btnCopy.UseVisualStyleBackColor = True
        ' 
        ' btnPaste
        ' 
        btnPaste.Location = New Point(751, 205)
        btnPaste.Name = "btnPaste"
        btnPaste.Size = New Size(75, 23)
        btnPaste.TabIndex = 18
        btnPaste.Text = "Paste Product Name"
        btnPaste.UseVisualStyleBackColor = True
        ' 
        ' frmProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 611)
        Controls.Add(btnPaste)
        Controls.Add(btnCopy)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(dgvProducts)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtProductName)
        Controls.Add(txtProductID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GBStation - Product Management"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnPaste As Button
End Class
