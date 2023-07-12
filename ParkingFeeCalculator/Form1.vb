Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer2.Enabled = True
        totalTime.Enabled = False
        parkingFee.Enabled = False
        vatAmount.Enabled = False
        vatSales.Enabled = False
        computedHours.Enabled = False
        totalTime.Enabled = False
        entryDateDisplay.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'for time reference
        currentTime.Text = TimeString
    End Sub

    Private Sub timeIn_Click(sender As Object, e As EventArgs) Handles compute.Click

        Dim dateEntry As Date = entryDate.Value
        Dim dateDisplay As String = dateEntry.ToString("MM-dd-yyyy")
        entryDateDisplay.Text = dateDisplay

        Dim numOnly1, numOnly2, numOnly3, numOnly4 As Integer

        'to avoid characters except numbers valid for 24-hour format

        If Not (Integer.TryParse(inputHours.Text, numOnly1) AndAlso numOnly1 >= 0 AndAlso numOnly1 < 24) Then
            MsgBox("Please provide correct information!", MsgBoxStyle.Critical, "Error")
            Return
        End If
        If Not (Integer.TryParse(inputMinutes.Text, numOnly2) AndAlso numOnly2 >= 0 AndAlso numOnly2 < 60) Then
            MsgBox("Please provide correct information!", MsgBoxStyle.Critical, "Error")
            Return
        End If
        If Not (Integer.TryParse(outputHours.Text, numOnly3) AndAlso numOnly3 >= 0 AndAlso numOnly3 < 24) Then
            MsgBox("Please provide correct information!", MsgBoxStyle.Critical, "Error")
            Return
        End If
        If Not (Integer.TryParse(outputMinutes.Text, numOnly4) AndAlso numOnly4 >= 0 AndAlso numOnly4 < 60) Then
            MsgBox("Please provide correct information!", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim hourIn As Integer = inputHours.Text
        Dim minuteIn As Integer = inputMinutes.Text
        Dim hourOut As Integer = outputHours.Text
        Dim minuteOut As Integer = outputMinutes.Text
        Dim hourDifference As Integer
        Dim minuteDifference As Integer
        Dim totalDifference As Double
        Dim difference As Integer
        Dim totalDecimal As Integer

        'logic in time difference

        'if minuteOut has a value, hourOut can't be 24 hours
        'if minuteOut will add 60 minutes, hourOut can't be 23 (23 hours + 60 minutes = 24 hours)

        If hourIn < hourOut And minuteIn < minuteOut Then
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn < hourOut And minuteIn > minuteOut Then
            hourOut -= 1
            minuteOut += 60
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn > hourOut And minuteIn < minuteOut Then
            hourOut += 24
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn > hourOut And minuteIn > minuteOut Then
            hourOut += 22
            minuteOut += 60
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn Like hourOut And minuteIn < minuteOut Then
            hourIn = 0
            hourOut = 0
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn Like hourOut And minuteIn > minuteOut Then
            hourOut += 22
            minuteOut += 60
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn < hourOut And minuteIn Like minuteOut Then
            minuteIn = 0
            minuteOut = 0
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn > hourOut And minuteIn Like minuteOut Then
            hourOut += 23
            minuteIn = 0
            minuteOut = 0
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        ElseIf hourIn Like hourOut And minuteIn Like minuteOut Then
            hourOut = 0
            hourIn = 0
            minuteIn = 0
            minuteOut = 0
            hourDifference = hourOut - hourIn
            minuteDifference = minuteOut - minuteIn
        End If

        'convert the total hours to minutes to have a single unit
        hourDifference *= 60

        'creating integer variable to store the whole number from the double variable
        difference = (hourDifference + minuteDifference) / 60
        totalDifference = (hourDifference + minuteDifference) / 60

        'integers are auto round off
        'Check if the totalDifference is less than 1 to avoid round offs       
        If difference = 1 And totalDifference < 1 Then
            difference -= 1
        End If

        'get the remainder by dividing it to 60 and it will be the minutes
        totalDecimal = (hourDifference + minuteDifference) Mod 60

        totalTime.Text = difference & " hour/s " & "& " & totalDecimal & " minute/s"

        Dim hoursConsumed As Integer
        Dim feeParking As Integer

        'check if there's a fraction of an hour
        hoursConsumed = difference
        If totalDecimal <> 0 Then
            hoursConsumed += 1
        End If

        computedHours.Text = hoursConsumed & " total hour/s"

        'set the minimum parking fee as 50 for 3 hours, 10 for every succeeding hour
        If hoursConsumed > 3 Then
            hoursConsumed = (hoursConsumed - 3) * 10
            feeParking = hoursConsumed + 50
        Else
            feeParking = 50
        End If

        parkingFee.Text = feeParking

        'simple computation of VAT
        Dim amountVat As Double
        Dim salesVat As Double
        amountVat = feeParking * 0.12
        salesVat = feeParking - amountVat
        vatAmount.Text = amountVat
        vatSales.Text = salesVat

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        'clear section for another inputs
        inputHours.Text = ""
        inputMinutes.Text = ""
        inTime.Text = ""
        outputHours.Text = ""
        outputMinutes.Text = ""
        outTime.Text = ""
        parkingFee.Text = ""
        vatAmount.Text = ""
        vatSales.Text = ""
        computedHours.Text = ""
        totalTime.Text = ""
        inputHours.Focus()

    End Sub

End Class
