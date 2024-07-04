' SPDX-FileCopyrightText: 2021 Christian Günther <cgite@gmx.de>
'
' SPDX-License-Identifier: MIT
Public Class Form1

    Private Sub CalcByte()
        Dim bits As New BitArray(CreateBitArray)
        Dim res(0) As Byte
        Dim bitString As String = ""

        For i = bits.Length - 1 To 0 Step -1
            bitString += IIf(bits(i), "1", "0")
            If i = 4 Then bitString += " "
        Next

        bits.CopyTo(res, 0)
        LbResultingBits.Text = $"Resulting Bits: {bitString}"
        LbDec.Text = $"As Dec: {res(0)}"
        LbHex.Text = $"As Hex: {BitConverter.ToString(res)}"
    End Sub

    Private Function CreateBitArray() As Boolean()

        Dim res(7) As Boolean
        res(0) = Bit0.Checked Xor CbInverted.Checked
        res(1) = Bit1.Checked Xor CbInverted.Checked
        res(2) = Bit2.Checked Xor CbInverted.Checked
        res(3) = Bit3.Checked Xor CbInverted.Checked
        res(4) = Bit4.Checked Xor CbInverted.Checked
        res(5) = Bit5.Checked Xor CbInverted.Checked
        res(6) = Bit6.Checked Xor CbInverted.Checked
        res(7) = Bit7.Checked Xor CbInverted.Checked

        If CbReverse.Checked Then

            res = res.Reverse.ToArray

        End If
        Return res

    End Function

    Private Sub Bit7_CheckedChanged(sender As Object, e As EventArgs) Handles Bit7.CheckedChanged
        CalcByte()
    End Sub


    Private Sub Bit6_CheckedChanged(sender As Object, e As EventArgs) Handles Bit6.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit5_CheckedChanged(sender As Object, e As EventArgs) Handles Bit5.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit4_CheckedChanged(sender As Object, e As EventArgs) Handles Bit4.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit3_CheckedChanged(sender As Object, e As EventArgs) Handles Bit3.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit2_CheckedChanged(sender As Object, e As EventArgs) Handles Bit2.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit1_CheckedChanged(sender As Object, e As EventArgs) Handles Bit1.CheckedChanged
        CalcByte()
    End Sub

    Private Sub Bit0_CheckedChanged(sender As Object, e As EventArgs) Handles Bit0.CheckedChanged
        CalcByte()
    End Sub

    Private Sub CbInverted_CheckedChanged(sender As Object, e As EventArgs) Handles CbInverted.CheckedChanged
        CalcByte()
    End Sub

    Private Sub CbReverse_CheckedChanged(sender As Object, e As EventArgs) Handles CbReverse.CheckedChanged
        CalcByte()
    End Sub
End Class
