Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click


        If gpbDistance.Enabled Then

            If IsNumeric(txtDistanceInput.Text) Then
                Dim distance As Double
                distance = txtDistanceInput.Text

                If rdoMilesToKilometers.Checked Then
                    txtDistanceOutput.Text = distance * (8 / 5)

                Else
                    txtDistanceOutput.Text = distance * (5 / 8)
                End If
            Else
                MessageBox.Show("You need to enter a number!")

            End If

        Else
            If IsNumeric(txtTemperatureInput.Text) Then
                Dim temperature As Double
                temperature = txtTemperatureInput.Text

                If rdoCelsiusToFahrenheit.Checked Then
                    txtTemperatureOutput.Text = (temperature * 1.8) + 32

                Else
                    txtTemperatureOutput.Text = (temperature - 32) / 1.8
                End If
            Else
                MessageBox.Show("You need to enter a number!")

            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoDistance.Checked = True
        gpbTemperature.Enabled = False
    End Sub


    Private Sub rdoDistance_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDistance.CheckedChanged
        gpbTemperature.Enabled = False
        gpbDistance.Enabled = True
    End Sub

    Private Sub rdoTemperature_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTemperature.CheckedChanged
        gpbDistance.Enabled = False
        gpbTemperature.Enabled = True
    End Sub
End Class
