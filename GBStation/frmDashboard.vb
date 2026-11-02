Public Class frmDashboard

    'PRODUCT MANAGEMENT BUTTON
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim f As New frmProducts()
        f.ShowDialog()
    End Sub

    'CUSTOMER MANAGEMENT BUTTON
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim f As New frmCustomers()
        f.ShowDialog()
    End Sub

    'SALES BUTTON
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim f As New frmSales()
        f.ShowDialog()
    End Sub

    'REPORTS BUTTON
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim f As New frmReports()
        f.ShowDialog()
    End Sub

    'SETTINGS BUTTON
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim f As New frmSettings()
        f.ShowDialog()
    End Sub

    'LOGOUT BUTTON
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub


    '========== FILE MENU ==========

    'PRODUCTS
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim f As New frmProducts()
        f.ShowDialog()
    End Sub

    'CUSTOMERS
    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim f As New frmCustomers()
        f.ShowDialog()
    End Sub

    'SALES
    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim f As New frmSales()
        f.ShowDialog()
    End Sub

    'EXIT
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    '========== REPORTS MENU ==========

    Private Sub GenerateReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateReportsToolStripMenuItem.Click
        Dim f As New frmReports()
        f.ShowDialog()
    End Sub


    '========== HELP MENU ==========

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        MessageBox.Show(
            "GBStation Stationery Supplies System" & vbCrLf &
            "Developed by: IBTIHAL HARED" & vbCrLf &
            "Admission: BSCS/2025/53315" & vbCrLf &
            "Version: 1.0",
            "About GBStation",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    'RIGHT-CLICK PRODUCTS
    Private Sub ctxProducts_Click(sender As Object, e As EventArgs) Handles ctxProducts.Click
        Dim f As New frmProducts()
        f.ShowDialog()
    End Sub

    'RIGHT-CLICK CUSTOMERS
    Private Sub ctxCustomers_Click(sender As Object, e As EventArgs) Handles ctxCustomers.Click
        Dim f As New frmCustomers()
        f.ShowDialog()
    End Sub

    'RIGHT-CLICK REFRESH
    Private Sub ctxRefresh_Click(sender As Object, e As EventArgs) Handles ctxRefresh.Click
        Me.Refresh()
        MessageBox.Show("Dashboard refreshed!")
    End Sub

    'RIGHT-CLICK EXIT
    Private Sub ctxExit_Click(sender As Object, e As EventArgs) Handles ctxExit.Click
        Me.Close()
    End Sub
End Class