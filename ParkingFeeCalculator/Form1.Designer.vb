<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        compute = New Button()
        inputHours = New TextBox()
        Label2 = New Label()
        Timer2 = New Timer(components)
        currentTime = New Label()
        Label3 = New Label()
        inputMinutes = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        outputMinutes = New TextBox()
        outputHours = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        parkingFee = New TextBox()
        vatAmount = New TextBox()
        vatSales = New TextBox()
        Label14 = New Label()
        clear = New Button()
        Label15 = New Label()
        computedHours = New TextBox()
        inTime = New Label()
        outTime = New Label()
        totalTime = New TextBox()
        entryDate = New DateTimePicker()
        Label1 = New Label()
        Label11 = New Label()
        entryDateDisplay = New TextBox()
        SuspendLayout()
        ' 
        ' compute
        ' 
        compute.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        compute.Location = New Point(88, 705)
        compute.Name = "compute"
        compute.Size = New Size(252, 77)
        compute.TabIndex = 0
        compute.Text = "COMPUTE"
        compute.UseVisualStyleBackColor = True
        ' 
        ' inputHours
        ' 
        inputHours.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        inputHours.Location = New Point(153, 227)
        inputHours.MaxLength = 2
        inputHours.Name = "inputHours"
        inputHours.Size = New Size(154, 39)
        inputHours.TabIndex = 1
        inputHours.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(17, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 32)
        Label2.TabIndex = 4
        Label2.Text = "Time(24-hour format):"
        ' 
        ' Timer2
        ' 
        ' 
        ' currentTime
        ' 
        currentTime.AutoSize = True
        currentTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        currentTime.Location = New Point(295, 69)
        currentTime.Name = "currentTime"
        currentTime.Size = New Size(70, 32)
        currentTime.TabIndex = 5
        currentTime.Text = "Time"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(96, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 45)
        Label3.TabIndex = 7
        Label3.Text = "TIME IN"
        ' 
        ' inputMinutes
        ' 
        inputMinutes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        inputMinutes.Location = New Point(153, 287)
        inputMinutes.MaxLength = 2
        inputMinutes.Name = "inputMinutes"
        inputMinutes.Size = New Size(154, 39)
        inputMinutes.TabIndex = 9
        inputMinutes.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 32)
        Label4.TabIndex = 11
        Label4.Text = "Hours:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(20, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 32)
        Label5.TabIndex = 12
        Label5.Text = "Minutes:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(87, 431)
        Label7.Name = "Label7"
        Label7.Size = New Size(172, 45)
        Label7.TabIndex = 14
        Label7.Text = "TIME OUT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(17, 565)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 32)
        Label9.TabIndex = 19
        Label9.Text = "Minutes:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(41, 506)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 32)
        Label10.TabIndex = 18
        Label10.Text = "Hours:"
        ' 
        ' outputMinutes
        ' 
        outputMinutes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        outputMinutes.Location = New Point(150, 558)
        outputMinutes.MaxLength = 2
        outputMinutes.Name = "outputMinutes"
        outputMinutes.Size = New Size(154, 39)
        outputMinutes.TabIndex = 16
        outputMinutes.TextAlign = HorizontalAlignment.Center
        ' 
        ' outputHours
        ' 
        outputHours.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        outputHours.Location = New Point(150, 499)
        outputHours.MaxLength = 2
        outputHours.Name = "outputHours"
        outputHours.Size = New Size(154, 39)
        outputHours.TabIndex = 15
        outputHours.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(500, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(254, 45)
        Label6.TabIndex = 22
        Label6.Text = "COMPUTATION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(431, 402)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 32)
        Label8.TabIndex = 23
        Label8.Text = "Parking Fee:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(519, 460)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 32)
        Label12.TabIndex = 24
        Label12.Text = "VAT:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(455, 519)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 32)
        Label13.TabIndex = 25
        Label13.Text = "VAT Sales:"
        ' 
        ' parkingFee
        ' 
        parkingFee.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        parkingFee.Location = New Point(600, 395)
        parkingFee.Name = "parkingFee"
        parkingFee.Size = New Size(303, 39)
        parkingFee.TabIndex = 26
        parkingFee.TextAlign = HorizontalAlignment.Center
        ' 
        ' vatAmount
        ' 
        vatAmount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        vatAmount.Location = New Point(600, 453)
        vatAmount.Name = "vatAmount"
        vatAmount.Size = New Size(303, 39)
        vatAmount.TabIndex = 27
        vatAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' vatSales
        ' 
        vatSales.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        vatSales.Location = New Point(600, 512)
        vatSales.Name = "vatSales"
        vatSales.Size = New Size(303, 39)
        vatSales.TabIndex = 28
        vatSales.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(379, 230)
        Label14.Name = "Label14"
        Label14.Size = New Size(205, 32)
        Label14.TabIndex = 29
        Label14.Text = "Consumed Time:"
        ' 
        ' clear
        ' 
        clear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        clear.Location = New Point(600, 657)
        clear.Name = "clear"
        clear.Size = New Size(154, 67)
        clear.TabIndex = 31
        clear.Text = "CLEAR"
        clear.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(431, 294)
        Label15.Name = "Label15"
        Label15.Size = New Size(153, 32)
        Label15.TabIndex = 32
        Label15.Text = "Total Hours:"
        ' 
        ' computedHours
        ' 
        computedHours.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        computedHours.Location = New Point(600, 287)
        computedHours.Name = "computedHours"
        computedHours.Size = New Size(303, 39)
        computedHours.TabIndex = 34
        computedHours.TextAlign = HorizontalAlignment.Center
        ' 
        ' inTime
        ' 
        inTime.AutoSize = True
        inTime.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        inTime.Location = New Point(153, 350)
        inTime.Name = "inTime"
        inTime.Size = New Size(0, 38)
        inTime.TabIndex = 40
        inTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' outTime
        ' 
        outTime.AutoSize = True
        outTime.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        outTime.Location = New Point(150, 620)
        outTime.Name = "outTime"
        outTime.Size = New Size(0, 38)
        outTime.TabIndex = 41
        outTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' totalTime
        ' 
        totalTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        totalTime.Location = New Point(600, 223)
        totalTime.Name = "totalTime"
        totalTime.Size = New Size(303, 39)
        totalTime.TabIndex = 42
        totalTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' entryDate
        ' 
        entryDate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        entryDate.Location = New Point(97, 12)
        entryDate.Name = "entryDate"
        entryDate.Size = New Size(423, 39)
        entryDate.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 32)
        Label1.TabIndex = 44
        Label1.Text = "Date:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(384, 583)
        Label11.Name = "Label11"
        Label11.Size = New Size(200, 32)
        Label11.TabIndex = 45
        Label11.Text = "Date Computed:"
        ' 
        ' entryDateDisplay
        ' 
        entryDateDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        entryDateDisplay.Location = New Point(600, 576)
        entryDateDisplay.Name = "entryDateDisplay"
        entryDateDisplay.Size = New Size(303, 39)
        entryDateDisplay.TabIndex = 46
        entryDateDisplay.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(943, 828)
        Controls.Add(entryDateDisplay)
        Controls.Add(Label11)
        Controls.Add(Label1)
        Controls.Add(entryDate)
        Controls.Add(totalTime)
        Controls.Add(outTime)
        Controls.Add(inTime)
        Controls.Add(computedHours)
        Controls.Add(Label15)
        Controls.Add(clear)
        Controls.Add(Label14)
        Controls.Add(vatSales)
        Controls.Add(vatAmount)
        Controls.Add(parkingFee)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(outputMinutes)
        Controls.Add(outputHours)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(inputMinutes)
        Controls.Add(Label3)
        Controls.Add(currentTime)
        Controls.Add(Label2)
        Controls.Add(inputHours)
        Controls.Add(compute)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parking Fee Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents compute As Button
    Friend WithEvents inputHours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents currentTime As Label
    Friend WithEvents timeOut As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents inputMinutes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents outputMinutes As TextBox
    Friend WithEvents outputHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents parkingFee As TextBox
    Friend WithEvents vatAmount As TextBox
    Friend WithEvents vatSales As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents clear As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents computedHours As TextBox
    Friend WithEvents inTime As Label
    Friend WithEvents outTime As Label
    Friend WithEvents totalTime As TextBox
    Friend WithEvents entryDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents entryDateDisplay As TextBox
End Class
