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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gpbDistance = New System.Windows.Forms.GroupBox()
        Me.gpbTemperature = New System.Windows.Forms.GroupBox()
        Me.txtDistanceInput = New System.Windows.Forms.TextBox()
        Me.txtDistanceOutput = New System.Windows.Forms.TextBox()
        Me.txtTemperatureInput = New System.Windows.Forms.TextBox()
        Me.txtTemperatureOutput = New System.Windows.Forms.TextBox()
        Me.rdoMilesToKilometers = New System.Windows.Forms.RadioButton()
        Me.rdoKilometersToMiles = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdoCelsiusToFahrenheit = New System.Windows.Forms.RadioButton()
        Me.rdoFahrenheitToKilometers = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rdoDistance = New System.Windows.Forms.RadioButton()
        Me.rdoTemperature = New System.Windows.Forms.RadioButton()
        Me.gpbDistance.SuspendLayout()
        Me.gpbTemperature.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(358, 386)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(453, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gpbDistance
        '
        Me.gpbDistance.Controls.Add(Me.Panel1)
        Me.gpbDistance.Controls.Add(Me.txtDistanceOutput)
        Me.gpbDistance.Controls.Add(Me.txtDistanceInput)
        Me.gpbDistance.Location = New System.Drawing.Point(12, 12)
        Me.gpbDistance.Name = "gpbDistance"
        Me.gpbDistance.Size = New System.Drawing.Size(516, 128)
        Me.gpbDistance.TabIndex = 9
        Me.gpbDistance.TabStop = False
        Me.gpbDistance.Text = "Distance"
        '
        'gpbTemperature
        '
        Me.gpbTemperature.Controls.Add(Me.Panel2)
        Me.gpbTemperature.Controls.Add(Me.txtTemperatureOutput)
        Me.gpbTemperature.Controls.Add(Me.txtTemperatureInput)
        Me.gpbTemperature.Location = New System.Drawing.Point(12, 189)
        Me.gpbTemperature.Name = "gpbTemperature"
        Me.gpbTemperature.Size = New System.Drawing.Size(516, 151)
        Me.gpbTemperature.TabIndex = 10
        Me.gpbTemperature.TabStop = False
        Me.gpbTemperature.Text = "Temperature"
        '
        'txtDistanceInput
        '
        Me.txtDistanceInput.Location = New System.Drawing.Point(17, 46)
        Me.txtDistanceInput.Name = "txtDistanceInput"
        Me.txtDistanceInput.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanceInput.TabIndex = 0
        '
        'txtDistanceOutput
        '
        Me.txtDistanceOutput.Location = New System.Drawing.Point(366, 46)
        Me.txtDistanceOutput.Name = "txtDistanceOutput"
        Me.txtDistanceOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanceOutput.TabIndex = 1
        '
        'txtTemperatureInput
        '
        Me.txtTemperatureInput.Location = New System.Drawing.Point(17, 51)
        Me.txtTemperatureInput.Name = "txtTemperatureInput"
        Me.txtTemperatureInput.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperatureInput.TabIndex = 2
        '
        'txtTemperatureOutput
        '
        Me.txtTemperatureOutput.Location = New System.Drawing.Point(366, 51)
        Me.txtTemperatureOutput.Name = "txtTemperatureOutput"
        Me.txtTemperatureOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperatureOutput.TabIndex = 3
        '
        'rdoMilesToKilometers
        '
        Me.rdoMilesToKilometers.AutoSize = True
        Me.rdoMilesToKilometers.Location = New System.Drawing.Point(26, 21)
        Me.rdoMilesToKilometers.Name = "rdoMilesToKilometers"
        Me.rdoMilesToKilometers.Size = New System.Drawing.Size(112, 17)
        Me.rdoMilesToKilometers.TabIndex = 4
        Me.rdoMilesToKilometers.TabStop = True
        Me.rdoMilesToKilometers.Text = "Miles to Kilometers"
        Me.rdoMilesToKilometers.UseVisualStyleBackColor = True
        '
        'rdoKilometersToMiles
        '
        Me.rdoKilometersToMiles.AutoSize = True
        Me.rdoKilometersToMiles.Location = New System.Drawing.Point(26, 55)
        Me.rdoKilometersToMiles.Name = "rdoKilometersToMiles"
        Me.rdoKilometersToMiles.Size = New System.Drawing.Size(112, 17)
        Me.rdoKilometersToMiles.TabIndex = 5
        Me.rdoKilometersToMiles.TabStop = True
        Me.rdoKilometersToMiles.Text = "Kilometers to Miles"
        Me.rdoKilometersToMiles.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdoMilesToKilometers)
        Me.Panel1.Controls.Add(Me.rdoKilometersToMiles)
        Me.Panel1.Location = New System.Drawing.Point(144, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 6
        '
        'rdoCelsiusToFahrenheit
        '
        Me.rdoCelsiusToFahrenheit.AutoSize = True
        Me.rdoCelsiusToFahrenheit.Location = New System.Drawing.Point(30, 22)
        Me.rdoCelsiusToFahrenheit.Name = "rdoCelsiusToFahrenheit"
        Me.rdoCelsiusToFahrenheit.Size = New System.Drawing.Size(127, 17)
        Me.rdoCelsiusToFahrenheit.TabIndex = 6
        Me.rdoCelsiusToFahrenheit.TabStop = True
        Me.rdoCelsiusToFahrenheit.Text = "Celsius To Fahrenheit"
        Me.rdoCelsiusToFahrenheit.UseVisualStyleBackColor = True
        '
        'rdoFahrenheitToKilometers
        '
        Me.rdoFahrenheitToKilometers.AutoSize = True
        Me.rdoFahrenheitToKilometers.Location = New System.Drawing.Point(30, 57)
        Me.rdoFahrenheitToKilometers.Name = "rdoFahrenheitToKilometers"
        Me.rdoFahrenheitToKilometers.Size = New System.Drawing.Size(123, 17)
        Me.rdoFahrenheitToKilometers.TabIndex = 7
        Me.rdoFahrenheitToKilometers.TabStop = True
        Me.rdoFahrenheitToKilometers.Text = "Fahrenheit to Celsius"
        Me.rdoFahrenheitToKilometers.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdoCelsiusToFahrenheit)
        Me.Panel2.Controls.Add(Me.rdoFahrenheitToKilometers)
        Me.Panel2.Location = New System.Drawing.Point(144, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rdoTemperature)
        Me.Panel3.Controls.Add(Me.rdoDistance)
        Me.Panel3.Location = New System.Drawing.Point(12, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 13
        '
        'rdoDistance
        '
        Me.rdoDistance.AutoSize = True
        Me.rdoDistance.Location = New System.Drawing.Point(26, 19)
        Me.rdoDistance.Name = "rdoDistance"
        Me.rdoDistance.Size = New System.Drawing.Size(67, 17)
        Me.rdoDistance.TabIndex = 0
        Me.rdoDistance.TabStop = True
        Me.rdoDistance.Text = "Distance"
        Me.rdoDistance.UseVisualStyleBackColor = True
        '
        'rdoTemperature
        '
        Me.rdoTemperature.AutoSize = True
        Me.rdoTemperature.Location = New System.Drawing.Point(26, 56)
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.Size = New System.Drawing.Size(85, 17)
        Me.rdoTemperature.TabIndex = 1
        Me.rdoTemperature.TabStop = True
        Me.rdoTemperature.Text = "Temperature"
        Me.rdoTemperature.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 501)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gpbTemperature)
        Me.Controls.Add(Me.gpbDistance)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gpbDistance.ResumeLayout(False)
        Me.gpbDistance.PerformLayout()
        Me.gpbTemperature.ResumeLayout(False)
        Me.gpbTemperature.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gpbDistance As System.Windows.Forms.GroupBox
    Friend WithEvents gpbTemperature As System.Windows.Forms.GroupBox
    Friend WithEvents txtDistanceOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtDistanceInput As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperatureOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperatureInput As System.Windows.Forms.TextBox
    Friend WithEvents rdoKilometersToMiles As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMilesToKilometers As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdoFahrenheitToKilometers As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCelsiusToFahrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdoTemperature As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDistance As System.Windows.Forms.RadioButton

End Class
