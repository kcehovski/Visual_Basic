Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStop.Enabled = False
        btnReset.Enabled = False

        txtTimer.Text = 0
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStop.Enabled = True
        btnReset.Enabled = True

        Timer1.Start()

    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnStop.Enabled = True
        btnReset.Enabled = True

        txtTimer.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTimer.Text += 1
    End Sub
End Class
