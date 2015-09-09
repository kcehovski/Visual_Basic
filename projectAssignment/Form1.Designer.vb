<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SepaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IBANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayeeOrAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSepaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SepaDBDataSet = New projectAssignment.SepaDBDataSet()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.dtSepaDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.gpbPayees = New System.Windows.Forms.GroupBox()
        Me.txtIBAN = New System.Windows.Forms.TextBox()
        Me.txtBIC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblIBAN = New System.Windows.Forms.Label()
        Me.lblBIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cboFromP = New System.Windows.Forms.ComboBox()
        Me.lblFromP = New System.Windows.Forms.Label()
        Me.gpbAccountTransfer = New System.Windows.Forms.GroupBox()
        Me.cboToA = New System.Windows.Forms.ComboBox()
        Me.cboFromA = New System.Windows.Forms.ComboBox()
        Me.lblToA = New System.Windows.Forms.Label()
        Me.lblFromA = New System.Windows.Forms.Label()
        Me.rdoPayees = New System.Windows.Forms.RadioButton()
        Me.rdoAccountTransfer = New System.Windows.Forms.RadioButton()
        Me.TblSepaTableAdapter = New projectAssignment.SepaDBDataSetTableAdapters.tblSepaTableAdapter()
        Me.TableAdapterManager = New projectAssignment.SepaDBDataSetTableAdapters.TableAdapterManager()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SepaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPayees.SuspendLayout()
        Me.gpbAccountTransfer.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.PayeeNameDataGridViewTextBoxColumn, Me.SepaDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.BICDataGridViewTextBoxColumn, Me.IBANDataGridViewTextBoxColumn, Me.PayeeOrAccountDataGridViewTextBoxColumn, Me.FromAccountDataGridViewTextBoxColumn, Me.ToAccountDataGridViewTextBoxColumn, Me.ReferenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblSepaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(668, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 197)
        Me.DataGridView1.TabIndex = 24
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PayeeNameDataGridViewTextBoxColumn
        '
        Me.PayeeNameDataGridViewTextBoxColumn.DataPropertyName = "PayeeName"
        Me.PayeeNameDataGridViewTextBoxColumn.HeaderText = "PayeeName"
        Me.PayeeNameDataGridViewTextBoxColumn.Name = "PayeeNameDataGridViewTextBoxColumn"
        '
        'SepaDateDataGridViewTextBoxColumn
        '
        Me.SepaDateDataGridViewTextBoxColumn.DataPropertyName = "SepaDate"
        Me.SepaDateDataGridViewTextBoxColumn.HeaderText = "SepaDate"
        Me.SepaDateDataGridViewTextBoxColumn.Name = "SepaDateDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'BICDataGridViewTextBoxColumn
        '
        Me.BICDataGridViewTextBoxColumn.DataPropertyName = "BIC"
        Me.BICDataGridViewTextBoxColumn.HeaderText = "BIC"
        Me.BICDataGridViewTextBoxColumn.Name = "BICDataGridViewTextBoxColumn"
        '
        'IBANDataGridViewTextBoxColumn
        '
        Me.IBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN"
        Me.IBANDataGridViewTextBoxColumn.HeaderText = "IBAN"
        Me.IBANDataGridViewTextBoxColumn.Name = "IBANDataGridViewTextBoxColumn"
        '
        'PayeeOrAccountDataGridViewTextBoxColumn
        '
        Me.PayeeOrAccountDataGridViewTextBoxColumn.DataPropertyName = "PayeeOrAccount"
        Me.PayeeOrAccountDataGridViewTextBoxColumn.HeaderText = "PayeeOrAccount"
        Me.PayeeOrAccountDataGridViewTextBoxColumn.Name = "PayeeOrAccountDataGridViewTextBoxColumn"
        '
        'FromAccountDataGridViewTextBoxColumn
        '
        Me.FromAccountDataGridViewTextBoxColumn.DataPropertyName = "FromAccount"
        Me.FromAccountDataGridViewTextBoxColumn.HeaderText = "FromAccount"
        Me.FromAccountDataGridViewTextBoxColumn.Name = "FromAccountDataGridViewTextBoxColumn"
        '
        'ToAccountDataGridViewTextBoxColumn
        '
        Me.ToAccountDataGridViewTextBoxColumn.DataPropertyName = "ToAccount"
        Me.ToAccountDataGridViewTextBoxColumn.HeaderText = "ToAccount"
        Me.ToAccountDataGridViewTextBoxColumn.Name = "ToAccountDataGridViewTextBoxColumn"
        '
        'ReferenceDataGridViewTextBoxColumn
        '
        Me.ReferenceDataGridViewTextBoxColumn.DataPropertyName = "Reference"
        Me.ReferenceDataGridViewTextBoxColumn.HeaderText = "Reference"
        Me.ReferenceDataGridViewTextBoxColumn.Name = "ReferenceDataGridViewTextBoxColumn"
        '
        'TblSepaBindingSource
        '
        Me.TblSepaBindingSource.DataMember = "tblSepa"
        Me.TblSepaBindingSource.DataSource = Me.SepaDBDataSet
        '
        'SepaDBDataSet
        '
        Me.SepaDBDataSet.DataSetName = "SepaDBDataSet"
        Me.SepaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(174, 391)
        Me.txtReference.Multiline = True
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReference.Size = New System.Drawing.Size(200, 84)
        Me.txtReference.TabIndex = 23
        '
        'dtSepaDate
        '
        Me.dtSepaDate.Location = New System.Drawing.Point(174, 362)
        Me.dtSepaDate.Name = "dtSepaDate"
        Me.dtSepaDate.Size = New System.Drawing.Size(200, 20)
        Me.dtSepaDate.TabIndex = 22
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(174, 324)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtAmount.TabIndex = 21
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(89, 394)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(60, 13)
        Me.lblReference.TabIndex = 20
        Me.lblReference.Text = "Reference:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(89, 362)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Date:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(89, 331)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 18
        Me.lblAmount.Text = "Amount:"
        '
        'gpbPayees
        '
        Me.gpbPayees.Controls.Add(Me.txtIBAN)
        Me.gpbPayees.Controls.Add(Me.txtBIC)
        Me.gpbPayees.Controls.Add(Me.txtName)
        Me.gpbPayees.Controls.Add(Me.lblIBAN)
        Me.gpbPayees.Controls.Add(Me.lblBIC)
        Me.gpbPayees.Controls.Add(Me.lblName)
        Me.gpbPayees.Controls.Add(Me.cboFromP)
        Me.gpbPayees.Controls.Add(Me.lblFromP)
        Me.gpbPayees.Location = New System.Drawing.Point(340, 56)
        Me.gpbPayees.Name = "gpbPayees"
        Me.gpbPayees.Size = New System.Drawing.Size(309, 205)
        Me.gpbPayees.TabIndex = 17
        Me.gpbPayees.TabStop = False
        Me.gpbPayees.Text = "Payees"
        '
        'txtIBAN
        '
        Me.txtIBAN.Location = New System.Drawing.Point(61, 161)
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.Size = New System.Drawing.Size(190, 20)
        Me.txtIBAN.TabIndex = 7
        '
        'txtBIC
        '
        Me.txtBIC.Location = New System.Drawing.Point(61, 124)
        Me.txtBIC.Name = "txtBIC"
        Me.txtBIC.Size = New System.Drawing.Size(190, 20)
        Me.txtBIC.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(61, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 20)
        Me.txtName.TabIndex = 5
        '
        'lblIBAN
        '
        Me.lblIBAN.AutoSize = True
        Me.lblIBAN.Location = New System.Drawing.Point(6, 164)
        Me.lblIBAN.Name = "lblIBAN"
        Me.lblIBAN.Size = New System.Drawing.Size(35, 13)
        Me.lblIBAN.TabIndex = 4
        Me.lblIBAN.Text = "IBAN:"
        '
        'lblBIC
        '
        Me.lblBIC.AutoSize = True
        Me.lblBIC.Location = New System.Drawing.Point(6, 127)
        Me.lblBIC.Name = "lblBIC"
        Me.lblBIC.Size = New System.Drawing.Size(27, 13)
        Me.lblBIC.TabIndex = 3
        Me.lblBIC.Text = "BIC:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'cboFromP
        '
        Me.cboFromP.FormattingEnabled = True
        Me.cboFromP.Items.AddRange(New Object() {"Current", "Deposit"})
        Me.cboFromP.Location = New System.Drawing.Point(61, 42)
        Me.cboFromP.Name = "cboFromP"
        Me.cboFromP.Size = New System.Drawing.Size(190, 21)
        Me.cboFromP.TabIndex = 1
        '
        'lblFromP
        '
        Me.lblFromP.AutoSize = True
        Me.lblFromP.Location = New System.Drawing.Point(6, 45)
        Me.lblFromP.Name = "lblFromP"
        Me.lblFromP.Size = New System.Drawing.Size(33, 13)
        Me.lblFromP.TabIndex = 0
        Me.lblFromP.Text = "From:"
        '
        'gpbAccountTransfer
        '
        Me.gpbAccountTransfer.Controls.Add(Me.cboToA)
        Me.gpbAccountTransfer.Controls.Add(Me.cboFromA)
        Me.gpbAccountTransfer.Controls.Add(Me.lblToA)
        Me.gpbAccountTransfer.Controls.Add(Me.lblFromA)
        Me.gpbAccountTransfer.Location = New System.Drawing.Point(10, 56)
        Me.gpbAccountTransfer.Name = "gpbAccountTransfer"
        Me.gpbAccountTransfer.Size = New System.Drawing.Size(304, 205)
        Me.gpbAccountTransfer.TabIndex = 16
        Me.gpbAccountTransfer.TabStop = False
        Me.gpbAccountTransfer.Text = "Account Transfer"
        '
        'cboToA
        '
        Me.cboToA.FormattingEnabled = True
        Me.cboToA.Location = New System.Drawing.Point(63, 87)
        Me.cboToA.Name = "cboToA"
        Me.cboToA.Size = New System.Drawing.Size(186, 21)
        Me.cboToA.TabIndex = 3
        '
        'cboFromA
        '
        Me.cboFromA.FormattingEnabled = True
        Me.cboFromA.Items.AddRange(New Object() {"Current", "Deposit", "Loan"})
        Me.cboFromA.Location = New System.Drawing.Point(63, 42)
        Me.cboFromA.Name = "cboFromA"
        Me.cboFromA.Size = New System.Drawing.Size(186, 21)
        Me.cboFromA.TabIndex = 2
        '
        'lblToA
        '
        Me.lblToA.AutoSize = True
        Me.lblToA.Location = New System.Drawing.Point(7, 95)
        Me.lblToA.Name = "lblToA"
        Me.lblToA.Size = New System.Drawing.Size(23, 13)
        Me.lblToA.TabIndex = 1
        Me.lblToA.Text = "To:"
        '
        'lblFromA
        '
        Me.lblFromA.AutoSize = True
        Me.lblFromA.Location = New System.Drawing.Point(7, 45)
        Me.lblFromA.Name = "lblFromA"
        Me.lblFromA.Size = New System.Drawing.Size(33, 13)
        Me.lblFromA.TabIndex = 0
        Me.lblFromA.Text = "From:"
        '
        'rdoPayees
        '
        Me.rdoPayees.AutoSize = True
        Me.rdoPayees.Location = New System.Drawing.Point(225, 12)
        Me.rdoPayees.Name = "rdoPayees"
        Me.rdoPayees.Size = New System.Drawing.Size(60, 17)
        Me.rdoPayees.TabIndex = 15
        Me.rdoPayees.TabStop = True
        Me.rdoPayees.Text = "Payees"
        Me.rdoPayees.UseVisualStyleBackColor = True
        '
        'rdoAccountTransfer
        '
        Me.rdoAccountTransfer.AutoSize = True
        Me.rdoAccountTransfer.Location = New System.Drawing.Point(102, 12)
        Me.rdoAccountTransfer.Name = "rdoAccountTransfer"
        Me.rdoAccountTransfer.Size = New System.Drawing.Size(107, 17)
        Me.rdoAccountTransfer.TabIndex = 14
        Me.rdoAccountTransfer.TabStop = True
        Me.rdoAccountTransfer.Text = "Account Transfer"
        Me.rdoAccountTransfer.UseVisualStyleBackColor = True
        '
        'TblSepaTableAdapter
        '
        Me.TblSepaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblSepaTableAdapter = Me.TblSepaTableAdapter
        Me.TableAdapterManager.UpdateOrder = projectAssignment.SepaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(581, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(500, 441)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(419, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 538)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.dtSepaDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.gpbPayees)
        Me.Controls.Add(Me.gpbAccountTransfer)
        Me.Controls.Add(Me.rdoPayees)
        Me.Controls.Add(Me.rdoAccountTransfer)
        Me.Name = "Form1"
        Me.Text = "SEPA Payments/Transfers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SepaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPayees.ResumeLayout(False)
        Me.gpbPayees.PerformLayout()
        Me.gpbAccountTransfer.ResumeLayout(False)
        Me.gpbAccountTransfer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents dtSepaDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents gpbPayees As System.Windows.Forms.GroupBox
    Friend WithEvents txtIBAN As System.Windows.Forms.TextBox
    Friend WithEvents txtBIC As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblIBAN As System.Windows.Forms.Label
    Friend WithEvents lblBIC As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cboFromP As System.Windows.Forms.ComboBox
    Friend WithEvents lblFromP As System.Windows.Forms.Label
    Friend WithEvents gpbAccountTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents cboToA As System.Windows.Forms.ComboBox
    Friend WithEvents cboFromA As System.Windows.Forms.ComboBox
    Friend WithEvents lblToA As System.Windows.Forms.Label
    Friend WithEvents lblFromA As System.Windows.Forms.Label
    Friend WithEvents rdoPayees As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAccountTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents SepaDBDataSet As projectAssignment.SepaDBDataSet
    Friend WithEvents TblSepaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSepaTableAdapter As projectAssignment.SepaDBDataSetTableAdapters.tblSepaTableAdapter
    Friend WithEvents TableAdapterManager As projectAssignment.SepaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SepaDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BICDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayeeOrAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
