﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmMain
    Dim connectionString As String
    Dim cnn As New SqlConnection
    Dim dt As New DataTable
    Dim ds As New DataSet("Employees")
    Dim da As New SqlDataAdapter
    Dim row As DataRow
    Dim iRecCount As Integer
    Dim iIndex As Integer = 0
    Dim strOp As String = ""
    Dim iInd As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisableInput()
        ConnectionToDatabase()
        DisplayRecord(iIndex)

    End Sub

    Private Sub ConnectionToDatabase()
        connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue4\Documents\vsprojects\Visual_Basic\projectEmployee\EmployeesDBO.mdf;Integrated Security=True"
        cnn = New SqlConnection(connectionString)

        Try
            cnn.Open()
            Dim str As String = "SELECT * FROM Employees"
            da = New SqlDataAdapter(str, cnn)
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            da.Fill(ds, "Employees")
            dt = ds.Tables("Employees")
            iRecCount = dt.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DisableInput()
        Try

            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is TextBox Then
                    Ctrl.Enabled = False
                Else
                    Ctrl.Enabled = True
                End If
            Next

            For Each GroupBoxControl As Control In Me.Controls
                If TypeOf GroupBoxControl Is GroupBox Then
                    For Each Ctrl As Control In GroupBoxControl.Controls
                        If TypeOf Ctrl Is TextBox Then
                            Ctrl.Enabled = False
                        Else
                            Ctrl.Enabled = True
                        End If
                    Next
                End If
            Next

            txtCounty.Visible = True
            txtDOB.Visible = True
            txtGender.Visible = True
            txtDateStarted.Visible = True
            txtDepartment.Visible = True


            lstCounties.Visible = False
            dtDOB.Visible = False
            rdoMale.Visible = False
            rdoFemale.Visible = False
            dtDateStarted.Visible = False
            cboDepartment.Visible = False

        Catch ex As Exception
            MessageBox.Show("Unable to set up display! ")
        End Try
    End Sub

    Private Sub EnableInput()
        Try

            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is TextBox Then
                    Ctrl.Enabled = True
                End If
            Next

            For Each GroupBoxControl As Control In Me.Controls
                If TypeOf GroupBoxControl Is GroupBox Then
                    For Each Ctrl As Control In GroupBoxControl.Controls
                        If TypeOf Ctrl Is TextBox Then
                            Ctrl.Enabled = True
                        End If
                    Next
                End If
            Next

            txtCounty.Visible = False
            txtDOB.Visible = False
            txtGender.Visible = False
            txtDateStarted.Visible = False
            txtDepartment.Visible = False

            lstCounties.Visible = True
            dtDOB.Visible = True
            rdoFemale.Visible = True
            rdoMale.Visible = True
            dtDateStarted.Visible = True
            cboDepartment.Visible = True

        Catch ex As Exception
            MessageBox.Show("Unable to set up display! ")
        End Try
    End Sub

    Private Sub DisplayRecord(Index As Integer)
        Try
            txtID.Text = dt.Rows(Index)("ID").ToString()
            txtFirstName.Text = dt.Rows(Index)("FirstName").ToString()
            txtLastName.Text = dt.Rows(Index)("LastName").ToString()
            txtAddressLine1.Text = dt.Rows(Index)("Address1").ToString()
            txtAddressLine2.Text = dt.Rows(Index)("Address2").ToString()
            txtCounty.Text = dt.Rows(Index)("County").ToString()
            lstCounties.SelectedItem = dt.Rows(Index)("County")

            txtDOB.Text = dt.Rows(Index)("DateOfBirth").ToString()
            dtDOB.Value = dt.Rows(Index)("DateOfBirth")

            If (dt.Rows(Index)("Gender").ToString()) = "M" Then
                txtGender.Text = "Male"
                rdoMale.Checked = True
            Else
                txtGender.Text = "Female"
                rdoFemale.Checked = True
            End If

            txtDateStarted.Text = dt.Rows(Index)("DateStarted").ToString()
            dtDateStarted.Value = dt.Rows(Index)("DateStarted")
            txtDepartment.Text = dt.Rows(Index)("Department").ToString()
            cboDepartment.SelectedItem = dt.Rows(Index)("Department")
            txtNotes.Text = dt.Rows(Index)("Notes").ToString()

        Catch ex As Exception
            MessageBox.Show("Unable to set up display!")
        End Try
    End Sub

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub CheckInput()
        Try

            If Not CheckForAlphaCharacters(txtFirstName.ToString()) Then
                MessageBox.Show("Your name must containe only letters.")
            Else
                MessageBox.Show("Jeeeej")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        iIndex = 0
        DisplayRecord(iIndex)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        iIndex = iRecCount - 1
        DisplayRecord(iIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If iIndex > 0 Then
            iIndex -= 1
            DisplayRecord(iIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If iIndex < iRecCount - 1 Then
            iIndex += 1
            DisplayRecord(iIndex)
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        strOp = "Add"
        EnableInput()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        lstCounties.SelectedIndex = 0
        cboDepartment.SelectedIndex = 0
        rdoMale.Checked = True

        Try

            row = ds.Tables("Employees").NewRow()

            row("FirstName") = "First Name"
            row("LastName") = "Last Name"
            row("Address1") = "Address1"
            row("Address2") = "Address2"
            row("County") = lstCounties.SelectedItem
            row("DateOfBirth") = dtDOB.Value
            row("Gender") = "M"
            row("DateStarted") = dtDateStarted.Value
            row("Department") = cboDepartment.SelectedItem
            row("Notes") = "Notes"

            ds.Tables("Employees").Rows.Add(row)
            iRecCount = dt.Rows.Count

            iIndex = iRecCount - 1

            DisplayRecord(iIndex)

        Catch ex As Exception
            MessageBox.Show("Bla")
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableInput()

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ds.Tables("Employees").Rows(iInd - 1).Delete()

        'iRecCount = dt.Rows.Count
        'iIndex = iRecCount - 1
        'DisplayRecord(iIndex)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DisableInput()

        Dim cB As SqlCommandBuilder = New SqlCommandBuilder(da)
        da.UpdateCommand = cB.GetUpdateCommand()

        iInd = txtID.Text
        dt.Rows(iInd - 1)("FirstName") = txtFirstName.Text
        dt.Rows(iInd - 1)("LastName") = txtLastName.Text
        dt.Rows(iInd - 1)("Address1") = txtAddressLine1.Text
        dt.Rows(iInd - 1)("Address2") = txtAddressLine2.Text

        If rdoMale.Checked Then
            dt.Rows(iInd - 1)("Gender") = "M"
        Else
            dt.Rows(iInd - 1)("Gender") = "F"
        End If

        dt.Rows(iInd - 1)("County") = lstCounties.SelectedItem
        dt.Rows(iInd - 1)("DateOfBirth") = dtDOB.Value
        dt.Rows(iInd - 1)("DateStarted") = dtDateStarted.Value
        dt.Rows(iInd - 1)("Department") = cboDepartment.SelectedItem
        dt.Rows(iInd - 1)("Notes") = txtNotes.Text

        da.Update(dt)
        MessageBox.Show("Saved successfully")

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ds.RejectChanges()
        iRecCount = dt.Rows.Count

        If strOp = "Add" Then
            iIndex = iRecCount - 1
            strOp = ""

        End If


        DisplayRecord(iIndex)

        DisableInput()
        btnFirst.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = True
        btnLast.Enabled = True

    End Sub
End Class
