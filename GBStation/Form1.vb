Public Class frmLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "admin" AndAlso txtPassword.Text = "1234" Then

            MessageBox.Show("Login successful!", "GBStation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmDashboard.Show()

        Else

            MessageBox.Show("Invalid username or password!",
                            "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
