<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.gpbPersonalInformation = New System.Windows.Forms.GroupBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.dtDOB = New System.Windows.Forms.DateTimePicker()
        Me.lstCounties = New System.Windows.Forms.ListBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.lblAddressLine2 = New System.Windows.Forms.Label()
        Me.lblAddressLine1 = New System.Windows.Forms.Label()
        Me.gpbJobInformation = New System.Windows.Forms.GroupBox()
        Me.dtDateStarted = New System.Windows.Forms.DateTimePicker()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDateStarted = New System.Windows.Forms.TextBox()
        Me.lblDateStarted = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gpbPersonalInformation.SuspendLayout()
        Me.gpbJobInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(13, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(37, 10)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(35, 20)
        Me.txtID.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(94, 13)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(157, 10)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(112, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(286, 13)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(350, 10)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(151, 20)
        Me.txtLastName.TabIndex = 5
        '
        'gpbPersonalInformation
        '
        Me.gpbPersonalInformation.Controls.Add(Me.rdoFemale)
        Me.gpbPersonalInformation.Controls.Add(Me.rdoMale)
        Me.gpbPersonalInformation.Controls.Add(Me.dtDOB)
        Me.gpbPersonalInformation.Controls.Add(Me.lstCounties)
        Me.gpbPersonalInformation.Controls.Add(Me.txtGender)
        Me.gpbPersonalInformation.Controls.Add(Me.lblGender)
        Me.gpbPersonalInformation.Controls.Add(Me.txtDOB)
        Me.gpbPersonalInformation.Controls.Add(Me.lblDOB)
        Me.gpbPersonalInformation.Controls.Add(Me.txtCounty)
        Me.gpbPersonalInformation.Controls.Add(Me.lblCounty)
        Me.gpbPersonalInformation.Controls.Add(Me.txtAddressLine2)
        Me.gpbPersonalInformation.Controls.Add(Me.txtAddressLine1)
        Me.gpbPersonalInformation.Controls.Add(Me.lblAddressLine2)
        Me.gpbPersonalInformation.Controls.Add(Me.lblAddressLine1)
        Me.gpbPersonalInformation.Location = New System.Drawing.Point(16, 77)
        Me.gpbPersonalInformation.Name = "gpbPersonalInformation"
        Me.gpbPersonalInformation.Size = New System.Drawing.Size(512, 193)
        Me.gpbPersonalInformation.TabIndex = 6
        Me.gpbPersonalInformation.TabStop = False
        Me.gpbPersonalInformation.Text = "Personal Information"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(141, 143)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 13
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(81, 144)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 12
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'dtDOB
        '
        Me.dtDOB.Location = New System.Drawing.Point(334, 107)
        Me.dtDOB.Name = "dtDOB"
        Me.dtDOB.Size = New System.Drawing.Size(151, 20)
        Me.dtDOB.TabIndex = 11
        '
        'lstCounties
        '
        Me.lstCounties.FormattingEnabled = True
        Me.lstCounties.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.lstCounties.Location = New System.Drawing.Point(81, 107)
        Me.lstCounties.Name = "lstCounties"
        Me.lstCounties.Size = New System.Drawing.Size(172, 30)
        Me.lstCounties.TabIndex = 10
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(81, 143)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(66, 20)
        Me.txtGender.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(6, 143)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(334, 107)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(151, 20)
        Me.txtDOB.TabIndex = 7
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(298, 110)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(30, 13)
        Me.lblDOB.TabIndex = 6
        Me.lblDOB.Text = "DOB"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(81, 107)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(126, 20)
        Me.txtCounty.TabIndex = 5
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(8, 110)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 4
        Me.lblCounty.Text = "County"
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.Location = New System.Drawing.Point(81, 75)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(404, 20)
        Me.txtAddressLine2.TabIndex = 3
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.Location = New System.Drawing.Point(81, 40)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(404, 20)
        Me.txtAddressLine1.TabIndex = 2
        '
        'lblAddressLine2
        '
        Me.lblAddressLine2.AutoSize = True
        Me.lblAddressLine2.Location = New System.Drawing.Point(6, 78)
        Me.lblAddressLine2.Name = "lblAddressLine2"
        Me.lblAddressLine2.Size = New System.Drawing.Size(51, 13)
        Me.lblAddressLine2.TabIndex = 1
        Me.lblAddressLine2.Text = "Address2"
        '
        'lblAddressLine1
        '
        Me.lblAddressLine1.AutoSize = True
        Me.lblAddressLine1.Location = New System.Drawing.Point(6, 43)
        Me.lblAddressLine1.Name = "lblAddressLine1"
        Me.lblAddressLine1.Size = New System.Drawing.Size(51, 13)
        Me.lblAddressLine1.TabIndex = 0
        Me.lblAddressLine1.Text = "Address1"
        '
        'gpbJobInformation
        '
        Me.gpbJobInformation.Controls.Add(Me.dtDateStarted)
        Me.gpbJobInformation.Controls.Add(Me.cboDepartment)
        Me.gpbJobInformation.Controls.Add(Me.txtNotes)
        Me.gpbJobInformation.Controls.Add(Me.lblNotes)
        Me.gpbJobInformation.Controls.Add(Me.txtDepartment)
        Me.gpbJobInformation.Controls.Add(Me.lblDepartment)
        Me.gpbJobInformation.Controls.Add(Me.txtDateStarted)
        Me.gpbJobInformation.Controls.Add(Me.lblDateStarted)
        Me.gpbJobInformation.Location = New System.Drawing.Point(16, 298)
        Me.gpbJobInformation.Name = "gpbJobInformation"
        Me.gpbJobInformation.Size = New System.Drawing.Size(512, 231)
        Me.gpbJobInformation.TabIndex = 7
        Me.gpbJobInformation.TabStop = False
        Me.gpbJobInformation.Text = "Job Information"
        '
        'dtDateStarted
        '
        Me.dtDateStarted.Location = New System.Drawing.Point(81, 30)
        Me.dtDateStarted.Name = "dtDateStarted"
        Me.dtDateStarted.Size = New System.Drawing.Size(158, 20)
        Me.dtDateStarted.TabIndex = 7
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Marketing", "Administration", "Accounting", "IT", "Sales", "Shipping", "Finance", "Management", "Human Resources", "Manufacturing"})
        Me.cboDepartment.Location = New System.Drawing.Point(334, 32)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(121, 21)
        Me.cboDepartment.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(81, 77)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(294, 138)
        Me.txtNotes.TabIndex = 5
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(13, 77)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 4
        Me.lblNotes.Text = "Notes"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(334, 33)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(151, 20)
        Me.txtDepartment.TabIndex = 3
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(266, 36)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "Department"
        '
        'txtDateStarted
        '
        Me.txtDateStarted.Location = New System.Drawing.Point(81, 33)
        Me.txtDateStarted.Name = "txtDateStarted"
        Me.txtDateStarted.Size = New System.Drawing.Size(126, 20)
        Me.txtDateStarted.TabIndex = 1
        '
        'lblDateStarted
        '
        Me.lblDateStarted.AutoSize = True
        Me.lblDateStarted.Location = New System.Drawing.Point(10, 36)
        Me.lblDateStarted.Name = "lblDateStarted"
        Me.lblDateStarted.Size = New System.Drawing.Size(67, 13)
        Me.lblDateStarted.TabIndex = 0
        Me.lblDateStarted.Text = "Date Started"
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(37, 554)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(84, 45)
        Me.btnFirst.TabIndex = 8
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Location = New System.Drawing.Point(127, 554)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(84, 45)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(217, 554)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(84, 45)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(307, 554)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(84, 45)
        Me.btnLast.TabIndex = 11
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(574, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 45)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(574, 155)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 45)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(574, 204)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 45)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(574, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 45)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(574, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 45)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(574, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 45)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 615)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.gpbJobInformation)
        Me.Controls.Add(Me.gpbPersonalInformation)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.gpbPersonalInformation.ResumeLayout(False)
        Me.gpbPersonalInformation.PerformLayout()
        Me.gpbJobInformation.ResumeLayout(False)
        Me.gpbJobInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents gpbPersonalInformation As System.Windows.Forms.GroupBox
    Friend WithEvents gpbJobInformation As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents dtDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstCounties As System.Windows.Forms.ListBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents txtAddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddressLine2 As System.Windows.Forms.Label
    Friend WithEvents lblAddressLine1 As System.Windows.Forms.Label
    Friend WithEvents dtDateStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtDateStarted As System.Windows.Forms.TextBox
    Friend WithEvents lblDateStarted As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
