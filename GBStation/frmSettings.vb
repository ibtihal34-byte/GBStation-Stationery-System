Public Class frmSettings

    'CHANGE FONT
    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click

        Using fontBox As New FontDialog()

            fontBox.Font = lblTitle.Font

            If fontBox.ShowDialog() = DialogResult.OK Then
                lblTitle.Font = fontBox.Font
                MessageBox.Show("Font changed successfully!")
            End If

        End Using

    End Sub

    'CHANGE BACKGROUND COLOR
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        Using colorBox As New ColorDialog()

            colorBox.Color = Me.BackColor

            If colorBox.ShowDialog() = DialogResult.OK Then
                Me.BackColor = colorBox.Color
                MessageBox.Show("Background color changed!")
            End If

        End Using

    End Sub

    'ABOUT GBSTATION
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

        MessageBox.Show(
            "GBStation Stationery Supplies System" & vbCrLf &
            "Developed by: IBTIHAL HARED" & vbCrLf &
            "Admission: BSCS/2025/53315" & vbCrLf &
            "Version: 1.0",
            "About GBStation",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    'BACK BUTTON
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Using openFile As New OpenFileDialog()

            openFile.Title = "Select a File"
            openFile.Filter = "Text Files|*.txt|All Files|*.*"

            If openFile.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Selected File: " & openFile.FileName)
            End If

        End Using
    End Sub
End Class