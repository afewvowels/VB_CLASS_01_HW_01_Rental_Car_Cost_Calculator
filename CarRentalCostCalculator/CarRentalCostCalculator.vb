' Author, date, and project information
' Author: Keith Smith
' Date: 15 September 2018
' Project Info:
' This project takes user inputs and calculates cost
' And total miles driven for a hypothetical car rental


' Options
Option Strict On
Option Explicit On

Public Class CarRentalCostCalculator
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Initialize Integer Variables
        Dim DaysRentedInteger As Integer
        ' Initialize Decimal Varaiables
        Dim BeginOdometerDecimal As Decimal
        Dim EndOdometerDecimal As Decimal
        ' Initialize Calculated Variables
        Dim TotalMilesDrivenDecimal As Decimal
        Dim TotalCostDecimal As Decimal
        ' Initialize Constants
        Dim DAILY_RENTAL_RATE As Decimal = 75.0
        Dim RATE_PER_MILE_DRIVEN As Decimal = 0.25

        ' #1. Make sure that all data entry fields have data in them.
        If BeginOdometerTextBox.Text Is String.Empty Or
                EndOdometerTextBox.Text Is String.Empty Or
                DaysRentedTextBox.Text Is String.Empty Then
            MessageBox.Show("Please fill out all data entry fields.",
                            "Missing Data Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Else
            ' #2. Try to parse BeginningOdometerTextBox entry to decimal
            Try
                BeginOdometerDecimal = Decimal.Parse(BeginOdometerTextBox.Text)

                ' #3. Try to parse EndOdometerTextBox entry to decimal
                Try
                    EndOdometerDecimal = Decimal.Parse(EndOdometerTextBox.Text)

                    ' #4. Try to parse DaysRentedTextBox entry to integer
                    Try
                        DaysRentedInteger = Integer.Parse(DaysRentedTextBox.Text)

                        ' #5. All data entries are valid, perform calculations
                        TotalMilesDrivenDecimal = EndOdometerDecimal - BeginOdometerDecimal
                        TotalCostDecimal = (DaysRentedInteger * DAILY_RENTAL_RATE) +
                                           (TotalMilesDrivenDecimal * RATE_PER_MILE_DRIVEN)
                        MilesDrivenTextBox.Text = TotalMilesDrivenDecimal.ToString("0.0")
                        TotalCostTextBox.Text = TotalCostDecimal.ToString("c")
                    Catch ex As Exception
                        ' #4. Error message for DaysRentedTextBox
                        MessageBox.Show("Please use an integer value for the number of days rented.",
                                        "Date Parse Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation)
                    End Try
                Catch ex As Exception
                    ' #3. Error messsage for EndOdometerTextBox
                    MessageBox.Show("Please use a decimal value for the ending odometer reading.",
                                    "Date Parse Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                End Try
            Catch ex As Exception
                ' #2. Error message for BeginOdometerTextBox
                MessageBox.Show("Please use a decimal value for the beginning odometer reading.",
                                "Date Parse Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear user data entry text boxes
        BeginOdometerTextBox.Text = String.Empty
        EndOdometerTextBox.Text = String.Empty
        DaysRentedTextBox.Text = String.Empty

        ' Clear calculated data text boxes
        MilesDrivenTextBox.Text = String.Empty
        TotalCostTextBox.Text = String.Empty
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
