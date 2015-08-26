Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If String.Compare(txtEmail.Text, txtRepeatEmail.Text) = 0 Then
            MessageBox.Show("Your email match.")
        Else
            MessageBox.Show("You tiped something wrong!")
            txtRepeatEmail.Clear()
        End If

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtName.Text.ToLower.Contains("jane") Then
            MessageBox.Show("Hello Jane :) ")
        ElseIf txtName.Text.ToLower.Contains("katarina") Then
            MessageBox.Show("Hello awesome Kate :) ")
        Else
            MessageBox.Show("Hello you. Nice to meet you :)")
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim myIndex = txtEmailCheck.Text.IndexOf("@")
        Dim myString = txtEmailCheck.Text.Remove(0, myIndex)

        Dim indexOfDot = myString.IndexOf(".")
        Dim len = myString.Length
        Dim substring As String = myString.Substring(indexOfDot, len - indexOfDot)

        MessageBox.Show(substring)
    End Sub
End Class
