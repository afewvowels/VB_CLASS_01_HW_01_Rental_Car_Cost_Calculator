<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalCostCalculator
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
        Me.UserInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.DaysRentedTextBox = New System.Windows.Forms.TextBox()
        Me.DaysRentedLabel = New System.Windows.Forms.Label()
        Me.EndOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdometerLabel = New System.Windows.Forms.Label()
        Me.BeginOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.BeginOdometerLabel = New System.Windows.Forms.Label()
        Me.ResultsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInformationGroupBox.SuspendLayout()
        Me.ResultsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInformationGroupBox
        '
        Me.UserInformationGroupBox.Controls.Add(Me.DaysRentedTextBox)
        Me.UserInformationGroupBox.Controls.Add(Me.DaysRentedLabel)
        Me.UserInformationGroupBox.Controls.Add(Me.EndOdometerTextBox)
        Me.UserInformationGroupBox.Controls.Add(Me.EndOdometerLabel)
        Me.UserInformationGroupBox.Controls.Add(Me.BeginOdometerTextBox)
        Me.UserInformationGroupBox.Controls.Add(Me.BeginOdometerLabel)
        Me.UserInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInformationGroupBox.Name = "UserInformationGroupBox"
        Me.UserInformationGroupBox.Size = New System.Drawing.Size(452, 289)
        Me.UserInformationGroupBox.TabIndex = 13
        Me.UserInformationGroupBox.TabStop = False
        Me.UserInformationGroupBox.Text = "User Information"
        '
        'DaysRentedTextBox
        '
        Me.DaysRentedTextBox.Location = New System.Drawing.Point(222, 129)
        Me.DaysRentedTextBox.Name = "DaysRentedTextBox"
        Me.DaysRentedTextBox.Size = New System.Drawing.Size(89, 31)
        Me.DaysRentedTextBox.TabIndex = 5
        '
        'DaysRentedLabel
        '
        Me.DaysRentedLabel.AutoSize = True
        Me.DaysRentedLabel.Location = New System.Drawing.Point(82, 132)
        Me.DaysRentedLabel.Name = "DaysRentedLabel"
        Me.DaysRentedLabel.Size = New System.Drawing.Size(134, 25)
        Me.DaysRentedLabel.TabIndex = 4
        Me.DaysRentedLabel.Text = "Days rented:"
        '
        'EndOdometerTextBox
        '
        Me.EndOdometerTextBox.Location = New System.Drawing.Point(222, 83)
        Me.EndOdometerTextBox.Name = "EndOdometerTextBox"
        Me.EndOdometerTextBox.Size = New System.Drawing.Size(178, 31)
        Me.EndOdometerTextBox.TabIndex = 3
        '
        'EndOdometerLabel
        '
        Me.EndOdometerLabel.AutoSize = True
        Me.EndOdometerLabel.Location = New System.Drawing.Point(35, 86)
        Me.EndOdometerLabel.Name = "EndOdometerLabel"
        Me.EndOdometerLabel.Size = New System.Drawing.Size(181, 25)
        Me.EndOdometerLabel.TabIndex = 2
        Me.EndOdometerLabel.Text = "Ending odometer:"
        '
        'BeginOdometerTextBox
        '
        Me.BeginOdometerTextBox.Location = New System.Drawing.Point(222, 36)
        Me.BeginOdometerTextBox.Name = "BeginOdometerTextBox"
        Me.BeginOdometerTextBox.Size = New System.Drawing.Size(178, 31)
        Me.BeginOdometerTextBox.TabIndex = 1
        '
        'BeginOdometerLabel
        '
        Me.BeginOdometerLabel.AutoSize = True
        Me.BeginOdometerLabel.Location = New System.Drawing.Point(6, 39)
        Me.BeginOdometerLabel.Name = "BeginOdometerLabel"
        Me.BeginOdometerLabel.Size = New System.Drawing.Size(210, 25)
        Me.BeginOdometerLabel.TabIndex = 0
        Me.BeginOdometerLabel.Text = "Beginning odometer:"
        '
        'ResultsGroupBox
        '
        Me.ResultsGroupBox.Controls.Add(Me.TotalCostTextBox)
        Me.ResultsGroupBox.Controls.Add(Me.TotalCostLabel)
        Me.ResultsGroupBox.Controls.Add(Me.MilesDrivenTextBox)
        Me.ResultsGroupBox.Controls.Add(Me.MilesDrivenLabel)
        Me.ResultsGroupBox.Location = New System.Drawing.Point(470, 12)
        Me.ResultsGroupBox.Name = "ResultsGroupBox"
        Me.ResultsGroupBox.Size = New System.Drawing.Size(318, 289)
        Me.ResultsGroupBox.TabIndex = 14
        Me.ResultsGroupBox.TabStop = False
        Me.ResultsGroupBox.Text = "Results"
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Location = New System.Drawing.Point(28, 172)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(251, 31)
        Me.TotalCostTextBox.TabIndex = 9
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.AutoSize = True
        Me.TotalCostLabel.Location = New System.Drawing.Point(23, 134)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(112, 25)
        Me.TotalCostLabel.TabIndex = 8
        Me.TotalCostLabel.Text = "Total cost:"
        '
        'MilesDrivenTextBox
        '
        Me.MilesDrivenTextBox.Location = New System.Drawing.Point(28, 80)
        Me.MilesDrivenTextBox.Name = "MilesDrivenTextBox"
        Me.MilesDrivenTextBox.Size = New System.Drawing.Size(251, 31)
        Me.MilesDrivenTextBox.TabIndex = 7
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.AutoSize = True
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(23, 42)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(134, 25)
        Me.MilesDrivenLabel.TabIndex = 6
        Me.MilesDrivenLabel.Text = "Miles driven:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(288, 352)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(224, 86)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 352)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(224, 86)
        Me.CalculateButton.TabIndex = 16
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(564, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(224, 86)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CarRentalCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserInformationGroupBox)
        Me.Controls.Add(Me.ResultsGroupBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "CarRentalCostCalculator"
        Me.Text = "Car Rental Cost Calculator"
        Me.UserInformationGroupBox.ResumeLayout(False)
        Me.UserInformationGroupBox.PerformLayout()
        Me.ResultsGroupBox.ResumeLayout(False)
        Me.ResultsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserInformationGroupBox As GroupBox
    Friend WithEvents DaysRentedTextBox As TextBox
    Friend WithEvents DaysRentedLabel As Label
    Friend WithEvents EndOdometerTextBox As TextBox
    Friend WithEvents EndOdometerLabel As Label
    Friend WithEvents BeginOdometerTextBox As TextBox
    Friend WithEvents BeginOdometerLabel As Label
    Friend WithEvents ResultsGroupBox As GroupBox
    Friend WithEvents TotalCostTextBox As TextBox
    Friend WithEvents TotalCostLabel As Label
    Friend WithEvents MilesDrivenTextBox As TextBox
    Friend WithEvents MilesDrivenLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
End Class
