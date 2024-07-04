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
        Label1 = New Label()
        Bit7 = New CheckBox()
        Bit6 = New CheckBox()
        Bit5 = New CheckBox()
        Bit4 = New CheckBox()
        Bit3 = New CheckBox()
        Bit2 = New CheckBox()
        Bit1 = New CheckBox()
        Bit0 = New CheckBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CbInverted = New CheckBox()
        LbResultingBits = New Label()
        LbDec = New Label()
        LbHex = New Label()
        CbReverse = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 0
        Label1.Text = "Click the Bits"
        ' 
        ' Bit7
        ' 
        Bit7.AutoSize = True
        Bit7.Location = New Point(15, 52)
        Bit7.Name = "Bit7"
        Bit7.Size = New Size(15, 14)
        Bit7.TabIndex = 1
        Bit7.UseVisualStyleBackColor = True
        ' 
        ' Bit6
        ' 
        Bit6.AutoSize = True
        Bit6.Location = New Point(36, 52)
        Bit6.Name = "Bit6"
        Bit6.Size = New Size(15, 14)
        Bit6.TabIndex = 2
        Bit6.UseVisualStyleBackColor = True
        ' 
        ' Bit5
        ' 
        Bit5.AutoSize = True
        Bit5.Location = New Point(57, 52)
        Bit5.Name = "Bit5"
        Bit5.Size = New Size(15, 14)
        Bit5.TabIndex = 3
        Bit5.UseVisualStyleBackColor = True
        ' 
        ' Bit4
        ' 
        Bit4.AutoSize = True
        Bit4.Location = New Point(78, 52)
        Bit4.Name = "Bit4"
        Bit4.Size = New Size(15, 14)
        Bit4.TabIndex = 4
        Bit4.UseVisualStyleBackColor = True
        ' 
        ' Bit3
        ' 
        Bit3.AutoSize = True
        Bit3.Location = New Point(110, 52)
        Bit3.Name = "Bit3"
        Bit3.Size = New Size(15, 14)
        Bit3.TabIndex = 5
        Bit3.UseVisualStyleBackColor = True
        ' 
        ' Bit2
        ' 
        Bit2.AutoSize = True
        Bit2.Location = New Point(131, 52)
        Bit2.Name = "Bit2"
        Bit2.Size = New Size(15, 14)
        Bit2.TabIndex = 6
        Bit2.UseVisualStyleBackColor = True
        ' 
        ' Bit1
        ' 
        Bit1.AutoSize = True
        Bit1.Location = New Point(152, 52)
        Bit1.Name = "Bit1"
        Bit1.Size = New Size(15, 14)
        Bit1.TabIndex = 7
        Bit1.UseVisualStyleBackColor = True
        ' 
        ' Bit0
        ' 
        Bit0.AutoSize = True
        Bit0.Location = New Point(173, 52)
        Bit0.Name = "Bit0"
        Bit0.Size = New Size(15, 14)
        Bit0.TabIndex = 8
        Bit0.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 17)
        Label2.TabIndex = 9
        Label2.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 17)
        Label3.TabIndex = 10
        Label3.Text = "4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(194, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 17)
        Label4.TabIndex = 11
        Label4.Text = "Bit #"
        ' 
        ' CbInverted
        ' 
        CbInverted.AutoSize = True
        CbInverted.Location = New Point(270, 50)
        CbInverted.Name = "CbInverted"
        CbInverted.Size = New Size(83, 21)
        CbInverted.TabIndex = 12
        CbInverted.Text = "Invert Bits"
        CbInverted.UseVisualStyleBackColor = True
        ' 
        ' LbResultingBits
        ' 
        LbResultingBits.AutoSize = True
        LbResultingBits.Location = New Point(15, 108)
        LbResultingBits.Name = "LbResultingBits"
        LbResultingBits.Size = New Size(152, 17)
        LbResultingBits.TabIndex = 14
        LbResultingBits.Text = "Resulting Bits: 0000 0000"
        ' 
        ' LbDec
        ' 
        LbDec.AutoSize = True
        LbDec.Location = New Point(15, 128)
        LbDec.Name = "LbDec"
        LbDec.Size = New Size(62, 17)
        LbDec.TabIndex = 15
        LbDec.Text = "As Dec: 0"
        ' 
        ' LbHex
        ' 
        LbHex.AutoSize = True
        LbHex.Location = New Point(15, 148)
        LbHex.Name = "LbHex"
        LbHex.Size = New Size(82, 17)
        LbHex.TabIndex = 16
        LbHex.Text = "As Hex: 0x00"
        ' 
        ' CbReverse
        ' 
        CbReverse.AutoSize = True
        CbReverse.Location = New Point(270, 78)
        CbReverse.Name = "CbReverse"
        CbReverse.Size = New Size(97, 21)
        CbReverse.TabIndex = 17
        CbReverse.Text = "Reverse Bits"
        CbReverse.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 203)
        Controls.Add(CbReverse)
        Controls.Add(LbHex)
        Controls.Add(LbDec)
        Controls.Add(LbResultingBits)
        Controls.Add(CbInverted)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Bit0)
        Controls.Add(Bit1)
        Controls.Add(Bit2)
        Controls.Add(Bit3)
        Controls.Add(Bit4)
        Controls.Add(Bit5)
        Controls.Add(Bit6)
        Controls.Add(Bit7)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Bit Calc"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bit7 As CheckBox
    Friend WithEvents Bit6 As CheckBox
    Friend WithEvents Bit5 As CheckBox
    Friend WithEvents Bit4 As CheckBox
    Friend WithEvents Bit3 As CheckBox
    Friend WithEvents Bit2 As CheckBox
    Friend WithEvents Bit1 As CheckBox
    Friend WithEvents Bit0 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbInverted As CheckBox
    Friend WithEvents LbResultingBits As Label
    Friend WithEvents LbDec As Label
    Friend WithEvents LbHex As Label
    Friend WithEvents CbReverse As CheckBox
End Class
