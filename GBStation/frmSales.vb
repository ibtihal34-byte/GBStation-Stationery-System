Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frmSales

    Private connectionString As String =
        "Server=(localdb)\ProjectModels;Database=GBStationDB;Integrated Security=True;TrustServerCertificate=True;"

    'LOAD SALES
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSales()
    End Sub

    Private Sub LoadSales()

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "SELECT SaleID, ProductName, Price, Quantity, " &
                    "Discount, Tax, Total FROM Sales ORDER BY SaleID DESC"

                Using adapter As New SqlDataAdapter(sql, con)

                    Dim sales As New DataTable()
                    adapter.Fill(sales)
                    dgvSales.DataSource = sales

                End Using
            End Using

            dgvSales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvSales.ReadOnly = True
            dgvSales.AllowUserToAddRows = False

        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message)
        End Try

    End Sub

    'CALCULATE SALE
    Private Function CalculateSale() As Boolean

        Dim price As Decimal
        Dim quantity As Integer
        Dim discount As Decimal
        Dim taxRate As Decimal

        If txtProductName.Text.Trim() = "" Then
            MessageBox.Show("Please enter a product name.")
            Return False
        End If

        If Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MessageBox.Show("Enter a valid price.")
            Return False
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Enter a valid quantity.")
            Return False
        End If

        If txtDiscount.Text.Trim() = "" Then
            discount = 0
        ElseIf Not Decimal.TryParse(txtDiscount.Text, discount) OrElse discount < 0 Then
            MessageBox.Show("Enter a valid discount.")
            Return False
        End If

        If txtTax.Text.Trim() = "" Then
            taxRate = 16
        ElseIf Not Decimal.TryParse(txtTax.Text, taxRate) OrElse taxRate < 0 Then
            MessageBox.Show("Enter a valid tax percentage.")
            Return False
        End If

        Dim subtotal As Decimal = price * quantity

        If discount > subtotal Then
            MessageBox.Show("Discount cannot exceed subtotal.")
            Return False
        End If

        Dim taxAmount As Decimal = (subtotal - discount) * taxRate / 100D
        Dim total As Decimal = subtotal - discount + taxAmount

        lblSubtotal.Text = subtotal.ToString("N2")
        lblTaxAmount.Text = taxAmount.ToString("N2")
        lblTotal.Text = total.ToString("N2")

        Return True

    End Function

    'CALCULATE BUTTON
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If CalculateSale() Then
            MessageBox.Show("Sale calculated successfully!")
        End If
    End Sub

    'SAVE SALE TO SQL
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not CalculateSale() Then Exit Sub

        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim quantity As Integer = Integer.Parse(txtQuantity.Text)

        Dim discount As Decimal = 0
        If txtDiscount.Text.Trim() <> "" Then
            discount = Decimal.Parse(txtDiscount.Text)
        End If

        Dim subtotal As Decimal = price * quantity

        Dim taxAmount As Decimal =
            Decimal.Parse(lblTaxAmount.Text,
                          Globalization.NumberStyles.Number)

        Dim total As Decimal =
            Decimal.Parse(lblTotal.Text,
                          Globalization.NumberStyles.Number)

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "INSERT INTO Sales (ProductName, Price, Quantity, Discount, Tax, Total) " &
                    "VALUES (@name, @price, @quantity, @discount, @tax, @total)"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@discount", discount)
                    cmd.Parameters.AddWithValue("@tax", taxAmount)
                    cmd.Parameters.AddWithValue("@total", total)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Sale saved successfully!")

            LoadSales()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error saving sale: " & ex.Message)
        End Try

    End Sub

    'CLEAR BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()

        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtDiscount.Clear()
        txtTax.Clear()

        lblSubtotal.Text = "0.00"
        lblTaxAmount.Text = "0.00"
        lblTotal.Text = "0.00"

    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class