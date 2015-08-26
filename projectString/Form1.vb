Public Class Form1

    Dim Form2 As New Form2

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay1_Click(sender As Object, e As EventArgs) Handles btnDisplay1.Click
        Dim count As Integer
        Dim output As String = String.Empty

        For count = 0 To 50
            output = output & "Line" & count.ToString() & ": Display 1" & Environment.NewLine()
        Next

        Form2.txtOutput.Text = output
        Form2.Show()
    End Sub

    Private Sub btnDisplay2_Click(sender As Object, e As EventArgs) Handles btnDisplay2.Click
        Dim count As Integer
        Dim output As String = String.Empty

        For count = 0 To 50
            output = output & "Line" & count.ToString() & ": Display 2" & Environment.NewLine()
        Next

        Form2.txtOutput.Text = output
        Form2.Show()
    End Sub
End Class
