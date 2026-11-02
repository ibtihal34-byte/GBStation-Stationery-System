Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class frmCustomers

    Private connectionString As String =
        "Server=(localdb)\ProjectModels;Database=GBStationDB;Integrated Security=True;TrustServerCertificate=True;"

    Private customers As New DataTable()

    'LOAD CUSTOMERS
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "SELECT CustomerID AS [Customer ID], " &
                    "CustomerName AS [Customer Name], " &
                    "Phone, Email FROM Customers"

                Using adapter As New SqlDataAdapter(sql, con)
                    customers = New DataTable()
                    adapter.Fill(customers)
                    dgvCustomers.DataSource = customers
                End Using

            End Using

            dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvCustomers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvCustomers.ReadOnly = True
            dgvCustomers.AllowUserToAddRows = False

            SearchCustomers()

        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try

    End Sub

    'ADD CUSTOMER
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Not ValidCustomer() Then Exit Sub

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "INSERT INTO Customers (CustomerID, CustomerName, Phone, Email) " &
                    "VALUES (@id, @name, @phone, @email)"

                Using cmd As New SqlCommand(sql, con)

                    AddCustomerParameters(cmd)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Customer added successfully!")
            LoadCustomers()
            ClearForm()

        Catch ex As SqlException When ex.Number = 2627 OrElse ex.Number = 2601
            MessageBox.Show("This Customer ID already exists.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'UPDATE CUSTOMER
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Not ValidCustomer() Then Exit Sub

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "UPDATE Customers SET CustomerName=@name, " &
                    "Phone=@phone, Email=@email WHERE CustomerID=@id"

                Using cmd As New SqlCommand(sql, con)

                    AddCustomerParameters(cmd)

                    con.Open()

                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Customer not found.")
                        Exit Sub
                    End If

                End Using
            End Using

            MessageBox.Show("Customer updated successfully!")
            LoadCustomers()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'DELETE CUSTOMER
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Please select a customer first.")
            Exit Sub
        End If

        If MessageBox.Show("Delete this customer?", "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(connectionString)

                Dim sql As String =
                    "DELETE FROM Customers WHERE CustomerID=@id"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@id", txtCustomerID.Text.Trim())

                    con.Open()

                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Customer not found.")
                        Exit Sub
                    End If

                End Using
            End Using

            MessageBox.Show("Customer deleted successfully!")
            LoadCustomers()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'VALIDATE CUSTOMER
    Private Function ValidCustomer() As Boolean

        If txtCustomerID.Text.Trim() = "" OrElse
           txtCustomerName.Text.Trim() = "" Then

            MessageBox.Show("Please enter Customer ID and Name.")
            Return False
        End If

        Return True

    End Function

    'SQL PARAMETERS
    Private Sub AddCustomerParameters(cmd As SqlCommand)

        cmd.Parameters.AddWithValue("@id", txtCustomerID.Text.Trim())
        cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim())

        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())

    End Sub

    'SELECT CUSTOMER
    Private Sub dgvCustomers_CellClick(sender As Object,
                                       e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)

        txtCustomerID.Text = Convert.ToString(row.Cells("Customer ID").Value)
        txtCustomerName.Text = Convert.ToString(row.Cells("Customer Name").Value)
        txtPhone.Text = Convert.ToString(row.Cells("Phone").Value)
        txtEmail.Text = Convert.ToString(row.Cells("Email").Value)

    End Sub

    'SEARCH CUSTOMERS
    Private Sub txtSearch_TextChanged(sender As Object,
                                       e As EventArgs) Handles txtSearch.TextChanged
        SearchCustomers()
    End Sub

    Private Sub SearchCustomers()

        If customers.Columns.Count = 0 Then Exit Sub

        Dim searchText As String = txtSearch.Text.Replace("'", "''")
        searchText = searchText.Replace("[", "[[]")
        searchText = searchText.Replace("%", "[%]")
        searchText = searchText.Replace("*", "[*]")

        customers.DefaultView.RowFilter =
            "[Customer Name] LIKE '%" & searchText & "%'"

    End Sub

    'CLEAR BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()

        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()

    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class