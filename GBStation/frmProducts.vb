Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frmProducts

    Private connectionString As String =
        "Server=(localdb)\ProjectModels;Database=GBStationDB;Integrated Security=True;TrustServerCertificate=True;"

    Private products As New DataTable()

    'LOAD PRODUCTS FROM SQL
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "SELECT ProductID AS [Product ID], " &
                    "ProductName AS [Product Name], " &
                    "Price, Quantity FROM Products"

                Using adapter As New SqlDataAdapter(sql, con)

                    products = New DataTable()
                    adapter.Fill(products)
                    dgvProducts.DataSource = products

                End Using
            End Using

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvProducts.ReadOnly = True
            dgvProducts.AllowUserToAddRows = False

            SearchProducts()

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try

    End Sub

    'ADD PRODUCT
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim price As Decimal
        Dim quantity As Integer

        If Not ValidProduct(price, quantity) Then Exit Sub

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "INSERT INTO Products (ProductID, ProductName, Price, Quantity) " &
                    "VALUES (@id, @name, @price, @quantity)"

                Using cmd As New SqlCommand(sql, con)

                    AddProductParameters(cmd, price, quantity)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Product added successfully!")
            LoadProducts()
            ClearForm()

        Catch ex As SqlException When ex.Number = 2627 OrElse ex.Number = 2601
            MessageBox.Show("This Product ID already exists.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'UPDATE PRODUCT
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim price As Decimal
        Dim quantity As Integer

        If Not ValidProduct(price, quantity) Then Exit Sub

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "UPDATE Products SET ProductName=@name, " &
                    "Price=@price, Quantity=@quantity " &
                    "WHERE ProductID=@id"

                Using cmd As New SqlCommand(sql, con)

                    AddProductParameters(cmd, price, quantity)

                    con.Open()

                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Product not found.")
                        Exit Sub
                    End If

                End Using
            End Using

            MessageBox.Show("Product updated successfully!")
            LoadProducts()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'DELETE PRODUCT
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtProductID.Text.Trim() = "" Then
            MessageBox.Show("Please select a product first.")
            Exit Sub
        End If

        If MessageBox.Show("Delete this product?", "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "DELETE FROM Products WHERE ProductID=@id"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@id", txtProductID.Text.Trim())

                    con.Open()

                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Product not found.")
                        Exit Sub
                    End If

                End Using
            End Using

            MessageBox.Show("Product deleted successfully!")
            LoadProducts()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'VALIDATE PRODUCT DETAILS
    Private Function ValidProduct(ByRef price As Decimal,
                                  ByRef quantity As Integer) As Boolean

        If txtProductID.Text.Trim() = "" OrElse
           txtProductName.Text.Trim() = "" Then

            MessageBox.Show("Please enter Product ID and Name.")
            Return False
        End If

        If Not Decimal.TryParse(txtPrice.Text, price) OrElse
           price < 0 Then

            MessageBox.Show("Please enter a valid price.")
            Return False
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse
           quantity < 0 Then

            MessageBox.Show("Please enter a valid quantity.")
            Return False
        End If

        Return True

    End Function

    'ADD SQL PARAMETERS
    Private Sub AddProductParameters(cmd As SqlCommand,
                                     price As Decimal,
                                     quantity As Integer)

        cmd.Parameters.AddWithValue("@id", txtProductID.Text.Trim())
        cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim())

        Dim priceParameter = cmd.Parameters.Add("@price", SqlDbType.Decimal)
        priceParameter.Precision = 18
        priceParameter.Scale = 2
        priceParameter.Value = price

        cmd.Parameters.AddWithValue("@quantity", quantity)

    End Sub

    'SELECT PRODUCT FROM TABLE
    Private Sub dgvProducts_CellClick(sender As Object,
                                      e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

        txtProductID.Text = Convert.ToString(row.Cells("Product ID").Value)
        txtProductName.Text = Convert.ToString(row.Cells("Product Name").Value)
        txtPrice.Text = Convert.ToString(row.Cells("Price").Value)
        txtQuantity.Text = Convert.ToString(row.Cells("Quantity").Value)

    End Sub

    'SEARCH PRODUCTS
    Private Sub txtSearch_TextChanged(sender As Object,
                                       e As EventArgs) Handles txtSearch.TextChanged
        SearchProducts()
    End Sub

    Private Sub SearchProducts()

        If products.Columns.Count = 0 Then Exit Sub

        Dim searchText As String = txtSearch.Text.Replace("'", "''")
        searchText = searchText.Replace("[", "[[]")
        searchText = searchText.Replace("%", "[%]")
        searchText = searchText.Replace("*", "[*]")

        products.DefaultView.RowFilter =
            "[Product Name] LIKE '%" & searchText & "%'"

    End Sub

    'CLEAR BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()

        txtProductID.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()

    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    'COPY PRODUCT NAME
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        If txtProductName.Text <> "" Then
            Clipboard.SetText(txtProductName.Text)
            MessageBox.Show("Product name copied!")
        Else
            MessageBox.Show("Enter a product name first.")
        End If

    End Sub

    'PASTE PRODUCT NAME
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click

        If Clipboard.ContainsText() Then
            txtProductName.Text = Clipboard.GetText()
            MessageBox.Show("Product name pasted!")
        Else
            MessageBox.Show("Nothing to paste!")
        End If

    End Sub
End Class