Public Class Form1
    'Restriction for BIC and IBAN text boxes are set in the properties for each text box.

    Dim type As String
    Dim isCorrect As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblSepaTableAdapter.Fill(Me.SepaDBDataSet.tblSepa)
        'When Form is loaded radio button Account Transfer will be checked, group box Account Transfer will be enabled,
        'group box Payees will be disabled, first item in combo box From in group box Account Transfer and Payees will be selected,
        'and date time picker will not allow user to pick date befor today.

        rdoAccountTransfer.Checked = True
        gpbPayees.Enabled = False
        type = "AccountTransfer"
        cboFromA.SelectedIndex = 0
        cboFromP.SelectedIndex = 0
        dtSepaDate.MinDate = Date.Today

    End Sub

    Private Sub rdoAccountTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAccountTransfer.CheckedChanged, rdoAccountTransfer.Click
        'When radio button Account Transfer is Checked group box Payees will be disabled, and group box Account Transfer will be enabled.
        'String variable type is set to Account Transfer so I can use it in event of Save button.
        gpbPayees.Enabled = False
        gpbAccountTransfer.Enabled = True
        type = "AccountTransfer"
    End Sub

    Private Sub rdoPayees_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPayees.CheckedChanged, rdoPayees.Click
        'When radio button Payees is Checked group box Payees will be enabled, and group box Account Transfer will be disabled.
        'String variable type is set to Payees so I can use it in event of Save button.
        gpbAccountTransfer.Enabled = False
        gpbPayees.Enabled = True
        type = "Payees"
    End Sub

    Private Sub cboFromA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFromA.SelectedIndexChanged, cboFromA.Click
        'Depending on selected item in combobox From in group box Account Transfer I'm populating combobox To with items.
        'Because of that From and To accounts will not be the same.

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
        'When button Cancel is clicked first we will get Message Box with message Are you sure?. 
        'If button Yes is clicked all boxes will be cleared and changes will be rejected.

        If MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel transfer") = MsgBoxResult.Yes Then
            SepaDBDataSet.RejectChanges()
            clearTxtBox()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program.
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Checking that Amount and Date are correct.
        checkAmountAndDate()
        'If there is error don't continue.
        If isCorrect = False Then
            Return
        End If

        'Format Amount Value to two decimal places.
        Dim aNumber As Double = Val(txtAmount.Text)
        txtAmount.Text = Format(aNumber, "#0.00")

        If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then

            'Depending which radio button is clicked continue with inserting values.
            If type = "AccountTransfer" Then
                Me.TblSepaTableAdapter.Insert(Nothing, dtSepaDate.Value, txtAmount.Text, Nothing, Nothing, "A", cboFromA.Text, cboToA.Text, txtReference.Text)
            Else
                'Checking all fields in Payees group box. And if there is no error continue with inserting values.
                checkPayees()
                If isCorrect Then
                    Me.TblSepaTableAdapter.Insert(txtName.Text, dtSepaDate.Value, txtAmount.Text, txtBIC.Text, txtIBAN.Text, "P", cboFromP.Text, Nothing, txtReference.Text)
                End If
            End If

            'Save and update all information
            Me.TblSepaTableAdapter.Fill(Me.SepaDBDataSet.tblSepa)
            Me.Validate()
            TblSepaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SepaDBDataSet)
            txtAmount.Clear()

            'Clear all text boxes.
            clearTxtBox()
        End If
    End Sub

    Private Sub clearTxtBox()
        'Clearing all text boxes outside and inside group boxes.

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
        'Checking that Amount textbox is not empty and there is number in it. If there is an error boolean variable isCorrect is set to False
        If txtAmount.Text = "" Or (Not IsNumeric(txtAmount.Text)) Then
            MessageBox.Show("Enter only numbers in Amount field.")
            isCorrect = False
            Return
        Else
            isCorrect = True
            Return
        End If
    End Sub

    Private Sub checkPayees()
        'Checking that Name, BIC and IBAN textbox is not empty and that BIC number is in IBAN number. If there is an error boolean variable isCorrect is set to False
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

