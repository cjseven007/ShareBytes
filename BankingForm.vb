Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BankingForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BankingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub


    Private Sub btnEye_MouseHover(sender As Object, e As EventArgs) Handles btnEye.MouseHover
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub btnEye_MouseLeave(sender As Object, e As EventArgs) Handles btnEye.MouseLeave
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If cboBanks.SelectedIndex = -1 Or txtCardNum.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Please make sure all card details is complete", 0 & MsgBoxStyle.Exclamation, "INCOMPLETE CARD DETAILS")
        Else
            sql = "INSERT INTO PaymentMethod (userID, paymentType, accountType, accountNum) VALUES (@UserID, @PaymentType, @AccountType, @AccountNum)"

            Dim userID = LoginForm.globalUserID
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@userID", userID)
            command.Parameters.AddWithValue("@PaymentType", "Banking")
            command.Parameters.AddWithValue("@AccoutType", cboBanks.SelectedItem)
            command.Parameters.AddWithValue("@AccoutNum", txtCardNum.Text)

            command.ExecuteNonQuery()

            MsgBox("Banking details is saved.", 0 & MsgBoxStyle.Information, "BANK SAVED")
            Me.Close()
            PaymentForm.Close()
        End If

        connect.Close()
    End Sub
End Class