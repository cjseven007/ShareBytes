Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Mail
Public Class OTPEmailForm
    Public Shared OTP As Integer
    Public Function IsValidEmail(email As String) As Boolean 'Check for valid email format
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)

        Return match.Success
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsValidEmail(txtEmail.Text) Then

            Try
                Dim random As New Random()
                OTP = random.Next(100000, 999999)
                ' Set up the SMTP client
                Dim smtpClient As New SmtpClient()
                smtpClient.Host = "smtp.gmail.com"
                smtpClient.Port = 587
                smtpClient.EnableSsl = True
                smtpClient.Credentials = New NetworkCredential("sharebytes06@gmail.com", "yabblionwfymfgrt")

                ' Create the email message
                Dim message As New MailMessage()
                message.From = New MailAddress("sharebytes06@gmail.com")
                message.[To].Add(txtEmail.Text)
                message.Subject = "EMAIL: Change Password"
                message.Body = "Greetings, " & vbCrLf &
    "This email contains the OTP required to change your password." & vbCrLf &
    "Kindly enter the following OTP in the app to proceed." & vbCrLf &
    "OTP: " & OTP.ToString()


                ' Send the email
                smtpClient.Send(message)
                MsgBox("An email containing the OTP has been sent to you. Kindly check your mailbox.", 0 & MsgBoxStyle.Information, "EMAIL SENT")
                VerifyOTPForm.ShowDialog()
                Me.Hide()

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MsgBox("Please enter a valid email format.", 0 + MsgBoxStyle.Exclamation, "INVALID EMAIL FORMAT")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class