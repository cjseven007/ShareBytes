Imports System.Data.OleDb
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CardForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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

    Private Function FormatCCV(ccv As String) As String
        Dim formattedNumber As String = "###"
        Dim index As Integer = 0

        For i As Integer = 0 To formattedNumber.Length - 1
            If formattedNumber(i) = "#" AndAlso index < ccv.Length Then
                formattedNumber = formattedNumber.Remove(i, 1)
                formattedNumber = formattedNumber.Insert(i, ccv(index).ToString())
                index += 1
            End If
        Next

        Return formattedNumber
    End Function

    Private Sub txtCardNum_TextChanged(sender As Object, e As EventArgs) Handles txtCardNum.TextChanged
        Dim cardNumber As String = txtCardNum.Text
        Dim formattedCardNumber As String = FormatCardNumber(cardNumber)
        lblCardNum1.Text = formattedCardNumber
    End Sub

    Private Sub txtCardNum_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCardNum.KeyPress
        ' Check if the input is a digit or backspace
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True ' Ignore the input
            Return
        End If

        ' Check if the total number of characters is already 16
        If txtCardNum.Text.Length >= 16 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True ' Ignore the input
        End If

        ' Revert to "#" when backspace is pressed
        If e.KeyChar = ChrW(Keys.Back) Then
            Dim currentIndex As Integer = txtCardNum.SelectionStart

            ' If the current character is not "#" (masked character), then revert back
            If currentIndex > 0 AndAlso txtCardNum.Text(currentIndex - 1) <> "#" Then
                txtCardNum.Text = txtCardNum.Text.Remove(currentIndex - 1, 1)
                txtCardNum.SelectionStart = currentIndex - 1
            End If

            e.Handled = True ' Ignore the input
        End If
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged
        lblDate1.Text = txtDate.Text
    End Sub

    Private Sub CardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        lblDate1.Text = "##/##"
    End Sub

    Private Sub txtDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDate.KeyPress
        ' Check if the input is a digit or backspace
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True ' Ignore the input
            Return
        End If

    End Sub

    Private Sub txtCCV_TextChanged(sender As Object, e As EventArgs) Handles txtCCV.TextChanged
        Dim ccv As String = txtCCV.Text
        Dim formattedCCVNumber As String = FormatCCV(ccv)
        lblCCV.Text = formattedCCVNumber
    End Sub

    Private Sub txtCCV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCCV.KeyPress
        ' Check if the input is a digit or backspace
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True ' Ignore the input
            Return
        End If

        ' Check if the total number of characters is already 16
        If txtCCV.Text.Length >= 3 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True ' Ignore the input
        End If

        ' Revert to "#" when backspace is pressed
        If e.KeyChar = ChrW(Keys.Back) Then
            Dim currentIndex As Integer = txtCCV.SelectionStart

            ' If the current character is not "#" (masked character), then revert back
            If currentIndex > 0 AndAlso txtCCV.Text(currentIndex - 1) <> "#" Then
                txtCCV.Text = txtCCV.Text.Remove(currentIndex - 1, 1)
                txtCCV.SelectionStart = currentIndex - 1
            End If

            e.Handled = True ' Ignore the input
        End If
    End Sub



    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If cboBanks.SelectedIndex = -1 Or txtCardNum.Text = Nothing Or txtDate.Text = Nothing Or txtCCV.Text = Nothing Then
            MsgBox("Please make sure all card details is complete", 0 & MsgBoxStyle.Exclamation, "INCOMPLETE CARD DETAILS")
        Else
            sql = "INSERT INTO PaymentMethod (userID, paymentType, accountType, accountNum) VALUES (@UserID, @PaymentType, @AccountType, @AccountNum)"

            Dim userID = LoginForm.globalUserID
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@userID", userID)
            command.Parameters.AddWithValue("@PaymentType", "Card")
            command.Parameters.AddWithValue("@AccoutType", cboBanks.SelectedItem)
            command.Parameters.AddWithValue("@AccoutNum", txtCardNum.Text)

            command.ExecuteNonQuery()

            MsgBox("Card details is saved.", 0 & MsgBoxStyle.Information, "CARD SAVED")
            Me.Close()
            PaymentForm.Close()
        End If

        connect.Close()
    End Sub

    Private Sub cboBanks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBanks.SelectedIndexChanged
        lblBankName.Text = cboBanks.SelectedItem
    End Sub
End Class