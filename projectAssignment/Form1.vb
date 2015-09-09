Public Class Form1

    Dim type As String
    Dim isCorrect As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SepaDBDataSet.tblSepa' table. You can move, or remove it, as needed.
        Me.TblSepaTableAdapter.Fill(Me.SepaDBDataSet.tblSepa)
        rdoAccountTransfer.Checked = True
        gpbPayees.Enabled = False
        type = "AccountTransfer"
        cboFromA.SelectedIndex = 0
        cboFromP.SelectedIndex = 0
    End Sub

    Private Sub rdoAccountTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAccountTransfer.CheckedChanged, rdoAccountTransfer.Click
        gpbPayees.Enabled = False
        gpbAccountTransfer.Enabled = True
        type = "AccountTransfer"
    End Sub

    Private Sub rdoPayees_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPayees.CheckedChanged, rdoPayees.Click
        gpbAccountTransfer.Enabled = False
        gpbPayees.Enabled = True
        type = "Payees"
    End Sub

    Private Sub cboFromA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFromA.SelectedIndexChanged, cboFromA.Click
        cboToA.ResetText()
        cboToA.Items.Clear()
        If cboFromA.Text = "Current" Then
            cboToA.Items.Add("Deposit")
            cboToA.Items.Add("Loan")
        ElseIf cboFromA.Text = "Deposit" Then
            cboToA.Items.Add("Current")
            cboToA.Items.Add("Loan")
        Else
            cboToA.Items.Add("Current")
            cboToA.Items.Add("Deposit")
        End If
        cboToA.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel transfer") = MsgBoxResult.Yes Then
            SepaDBDataSet.RejectChanges()
            clearTxtBox()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        checkAmountAndDate()
        If isCorrect = False Then
            Return
        End If

        If type = "AccountTransfer" Then
            Me.TblSepaTableAdapter.Insert(Nothing, dtSepaDate.Value, txtAmount.Text, Nothing, Nothing, "A", cboFromA.Text, cboToA.Text, txtReference.Text)
        Else
            checkPayees()
            If isCorrect Then
                Me.TblSepaTableAdapter.Insert(txtName.Text, dtSepaDate.Value, txtAmount.Text, txtBIC.Text, txtIBAN.Text, "P", cboFromP.Text, Nothing, txtReference.Text)
            End If
        End If

        Me.TblSepaTableAdapter.Fill(Me.SepaDBDataSet.tblSepa)
        Me.Validate()
        TblSepaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SepaDBDataSet)
        txtAmount.Clear()

        clearTxtBox()

    End Sub

    Private Sub clearTxtBox()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
        Next

        For Each GroupBoxControl As Control In Me.Controls
            If TypeOf GroupBoxControl Is GroupBox Then
                For Each Ctrl As Control In GroupBoxControl.Controls
                    If TypeOf Ctrl Is TextBox Then
                        Ctrl.Text = ""
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub checkAmountAndDate()
        If txtAmount.Text = "" Or (Not IsNumeric(txtAmount.Text)) Then
            MessageBox.Show("Enter only numbers in Amount field.")
            isCorrect = False
            Return
        ElseIf dtSepaDate.Value < DateTime.Now Then
            MessageBox.Show("Date can be only today or future date.")
            isCorrect = False
            Return
        Else
            isCorrect = True
            Return
        End If
    End Sub

    Private Sub checkPayees()
        If txtName.Text = "" Or txtBIC.Text = "" Or txtIBAN.Text = "" Then
            MessageBox.Show("Name, BIC and IBAN fields must be filled.")
            isCorrect = False
            Return
        ElseIf Not txtIBAN.Text.Contains(txtBIC.Text) Then
            MessageBox.Show("BIC number must be contained in IBAN number.")
            isCorrect = False
            Return
        End If
    End Sub

End Class

