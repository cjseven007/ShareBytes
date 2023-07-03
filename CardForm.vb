Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CardForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCardNum.TextChanged
        Dim cardNumber As String = txtCardNum.Text
        Dim formattedCardNumber As String = FormatCardNumber(cardNumber)
        lblCardNum1.Text = formattedCardNumber
    End Sub
    Private Function FormatCardNumber(cardNumber As String) As String
        Dim formattedNumber As String = "####   ####   ####   ####"
        Dim index As Integer = 0

        For i As Integer = 0 To formattedNumber.Length - 1
            If formattedNumber(i) = "#" AndAlso index < cardNumber.Length Then
                formattedNumber = formattedNumber.Remove(i, 1)
                formattedNumber = formattedNumber.Insert(i, cardNumber(index).ToString())
                index += 1
            End If
        Next

        Return formattedNumber
    End Function

    Private Sub txtCardNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNum.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the input
            Return
        End If

        ' Check if the total number of characters is already 16
        If txtCardNum.Text.Length >= 16 Then
            e.Handled = True ' Ignore the input
        End If
    End Sub
End Class