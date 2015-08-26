Public Class frmDemoListBox

    Private Sub frmDemoListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPricePds.Items.Add("Potato 149")
        lstPricePds.Items.Add("Red Pepper 343")
        lstPricePds.Items.Add("Cauliflower 193")
        lstPricePds.Items.Add("Carrot 075")
        lstPricePds.Items.Add("Pea 132")
        lstPricePds.Items.Add("Courgette 207")
        lstPricePds.Items.Add("Onion 168")
        lstPricePds.Items.Add("Green Bean 243")
        lstPricePds.Items.Add("Mushroom 243")
        lstPricePds.Items.Add("Broccoli 203")
    End Sub

    Private Sub btnQUIT_Click(sender As Object, e As EventArgs) Handles btnQUIT.Click
        Application.Exit()
    End Sub


    Private Sub lstPricePds_DoubleClick(sender As Object, e As EventArgs) Handles lstPricePds.DoubleClick
        Dim Temp, Veg As String
        Dim Pence, Pounds, Cents As String
        Dim Euros, Converted, TwoPrices As String
        Dim ExchangeRate As String

        ExchangeRate = 1.14

        Temp = lstPricePds.Text
        Veg = Temp.Substring(0, Temp.Length - 3)
        Pence = Temp.Substring(Temp.Length - 3)
        Cents = Format(ExchangeRate * CInt(Pence), "000")

        Converted = Veg & Cents
        lstPriceEuros.Items.Add(Converted)

        Pounds = Format(CInt(Pence) / 100, "0.00")
        Euros = Format(CInt(Cents) / 100, "0.00")
        TwoPrices = Veg & " £" & Pounds & " = " & "€ " & Euros
        txtPriceBoth.Text = txtPriceBoth.Text & TwoPrices & vbCrLf
    End Sub
End Class
