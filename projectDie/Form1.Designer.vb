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
        Me.btnDIE1 = New System.Windows.Forms.Button()
        Me.btnDIE2 = New System.Windows.Forms.Button()
        Me.txtNumberOfAttempts = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDie1 = New System.Windows.Forms.TextBox()
        Me.txtDie2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDIE1
        '
        Me.btnDIE1.Location = New System.Drawing.Point(96, 105)
        Me.btnDIE1.Name = "btnDIE1"
        Me.btnDIE1.Size = New System.Drawing.Size(75, 23)
        Me.btnDIE1.TabIndex = 0
        Me.btnDIE1.Text = "DIE1"
        Me.btnDIE1.UseVisualStyleBackColor = True
        '
        'btnDIE2
        '
        Me.btnDIE2.Location = New System.Drawing.Point(191, 105)
        Me.btnDIE2.Name = "btnDIE2"
        Me.btnDIE2.Size = New System.Drawing.Size(75, 23)
        Me.btnDIE2.TabIndex = 1
        Me.btnDIE2.Text = "DIE2"
        Me.btnDIE2.UseVisualStyleBackColor = True
        '
        'txtNumberOfAttempts
        '
        Me.txtNumberOfAttempts.Location = New System.Drawing.Point(148, 186)
        Me.txtNumberOfAttempts.Name = "txtNumberOfAttempts"
        Me.txtNumberOfAttempts.Size = New System.Drawing.Size(127, 20)
        Me.txtNumberOfAttempts.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(148, 232)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(127, 20)
        Me.txtScore.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Attempts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Score this Attempt"
        '
        'txtDie1
        '
        Me.txtDie1.Location = New System.Drawing.Point(96, 57)
        Me.txtDie1.Name = "txtDie1"
        Me.txtDie1.Size = New System.Drawing.Size(75, 20)
        Me.txtDie1.TabIndex = 6
        '
        'txtDie2
        '
        Me.txtDie2.Location = New System.Drawing.Point(191, 57)
        Me.txtDie2.Name = "txtDie2"
        Me.txtDie2.Size = New System.Drawing.Size(75, 20)
        Me.txtDie2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 364)
        Me.Controls.Add(Me.txtDie2)
        Me.Controls.Add(Me.txtDie1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtNumberOfAttempts)
        Me.Controls.Add(Me.btnDIE2)
        Me.Controls.Add(Me.btnDIE1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDIE1 As System.Windows.Forms.Button
    Friend WithEvents btnDIE2 As System.Windows.Forms.Button
    Friend WithEvents txtNumberOfAttempts As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDie1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDie2 As System.Windows.Forms.TextBox

End Class
