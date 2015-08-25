Public Class Form1

    Dim i As Integer
    Private Sub btnDIE1_Click(sender As Object, e As EventArgs) Handles btnDIE1.Click
        btnDIE2.Enabled = True

        Dim rand As New Random
        txtDie1.Text = rand.Next(1, 7)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
        btnDIE2.Enabled = False
    End Sub

    Private Sub btnDIE2_Click(sender As Object, e As EventArgs) Handles btnDIE2.Click
        Dim rand As New Random
        txtDie2.Text = rand.Next(1, 7)
        btnDIE2.Enabled = False

        
        i += 1

        Dim d1 As Integer
        d1 = txtDie1.Text

        Dim d2 As Integer
        d2 = txtDie2.Text

        txtNumberOfAttempts.Text = i
        txtScore.Text = d1 + d2

        If txtScore.Text >= 9 Then
            MessageBox.Show("Well done, you're awesome")

        End If


    End Sub
End Class
