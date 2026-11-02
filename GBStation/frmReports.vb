Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmReports

    Private connectionString As String =
        "Server=(localdb)\ProjectModels;Database=GBStationDB;Integrated Security=True;TrustServerCertificate=True;"

    'GENERATE REPORT
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim sql As String = ""

        Select Case cmbReportType.Text

            Case "Product Report"
                sql = "SELECT ProductID, ProductName, Price, Quantity FROM Products"

            Case "Customer Report"
                sql = "SELECT CustomerID, CustomerName, Phone, Email FROM Customers"


            Case "Sales Report"
                sql = "SELECT SaleID, ProductName, Price, Quantity, " &
                      "Discount, Tax, Total FROM Sales ORDER BY SaleID DESC"

            Case Else
                MessageBox.Show("Please select a report type.")
                Exit Sub

        End Select

        Try
            Using con As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter(sql, con)

                    Dim report As New DataTable()
                    adapter.Fill(report)

                    dgvReports.DataSource = report

                End Using
            End Using

            dgvReports.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvReports.ReadOnly = True

            MessageBox.Show("Report generated successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'EXPORT REPORT TO CSV
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvReports.DataSource Is Nothing Then
            MessageBox.Show("Please generate a report first.")
            Exit Sub
        End If

        Using save As New SaveFileDialog()

            save.Filter = "CSV Files (*.csv)|*.csv"
            save.FileName = "GBStation_Report.csv"

            If save.ShowDialog() = DialogResult.OK Then

                Try
                    Using writer As New StreamWriter(save.FileName, False, Encoding.UTF8)

                        Dim headers As New List(Of String)

                        For Each col As DataGridViewColumn In dgvReports.Columns
                            headers.Add(CsvValue(col.HeaderText))
                        Next

                        writer.WriteLine(String.Join(",", headers))

                        For Each row As DataGridViewRow In dgvReports.Rows

                            If row.IsNewRow Then Continue For

                            Dim values As New List(Of String)

                            For Each cell As DataGridViewCell In row.Cells
                                values.Add(CsvValue(Convert.ToString(cell.Value)))
                            Next

                            writer.WriteLine(String.Join(",", values))

                        Next
                    End Using

                    MessageBox.Show("Report exported successfully!")

                Catch ex As Exception
                    MessageBox.Show("Export error: " & ex.Message)
                End Try

            End If

        End Using

    End Sub

    'FORMAT CSV VALUES
    Private Function CsvValue(value As String) As String

        If value Is Nothing Then value = ""

        Return """" & value.Replace("""", """""") & """"

    End Function

    'CLEAR REPORT
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        dgvReports.DataSource = Nothing
        cmbReportType.SelectedIndex = -1

    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class