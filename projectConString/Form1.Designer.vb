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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtRepeatEmail = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblRepeatEmail = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmailCheck = New System.Windows.Forms.TextBox()
        Me.lblEmailCheck = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(103, 71)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtEmail.TabIndex = 0
        '
        'txtRepeatEmail
        '
        Me.txtRepeatEmail.Location = New System.Drawing.Point(103, 108)
        Me.txtRepeatEmail.Name = "txtRepeatEmail"
        Me.txtRepeatEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtRepeatEmail.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(153, 159)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(234, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(13, 78)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'lblRepeatEmail
        '
        Me.lblRepeatEmail.AutoSize = True
        Me.lblRepeatEmail.Location = New System.Drawing.Point(13, 115)
        Me.lblRepeatEmail.Name = "lblRepeatEmail"
        Me.lblRepeatEmail.Size = New System.Drawing.Size(70, 13)
        Me.lblRepeatEmail.TabIndex = 5
        Me.lblRepeatEmail.Text = "Repeat Email"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(570, 152)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(385, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(289, 20)
        Me.txtName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "What is your name?"
        '
        'txtEmailCheck
        '
        Me.txtEmailCheck.Location = New System.Drawing.Point(75, 339)
        Me.txtEmailCheck.Name = "txtEmailCheck"
        Me.txtEmailCheck.Size = New System.Drawing.Size(193, 20)
        Me.txtEmailCheck.TabIndex = 9
        '
        'lblEmailCheck
        '
        Me.lblEmailCheck.AutoSize = True
        Me.lblEmailCheck.Location = New System.Drawing.Point(16, 342)
        Me.lblEmailCheck.Name = "lblEmailCheck"
        Me.lblEmailCheck.Size = New System.Drawing.Size(32, 13)
        Me.lblEmailCheck.TabIndex = 10
        Me.lblEmailCheck.Text = "Email"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(193, 406)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 11
        Me.btnFind.Text = "OK"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 491)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblEmailCheck)
        Me.Controls.Add(Me.txtEmailCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRepeatEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtRepeatEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtRepeatEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblRepeatEmail As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmailCheck As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailCheck As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button

End Class
