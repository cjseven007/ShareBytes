Public Class VerifyOTPForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
        txt1.ReadOnly = False
        txt2.ReadOnly = False
        txt3.ReadOnly = False
        txt4.ReadOnly = False
        txt5.ReadOnly = False
        txt6.ReadOnly = False
    End Sub
    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        If txt1.Text.Length >= 1 Then
            txt1.ReadOnly = True
            txt2.Focus()
        End If
    End Sub
    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        If txt2.Text.Length >= 1 Then
            txt2.ReadOnly = True
            txt3.Focus()
        End If
    End Sub


    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles txt3.TextChanged
        If txt3.Text.Length >= 1 Then
            txt3.ReadOnly = True
            txt4.Focus()
        End If
    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles txt4.TextChanged
        If txt4.Text.Length >= 1 Then
            txt4.ReadOnly = True
            txt5.Focus()
        End If
    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged
        If txt5.Text.Length >= 1 Then
            txt5.ReadOnly = True
            txt6.Focus()
        End If
    End Sub

    Private Sub txt6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt6.KeyPress
        If txt6.Text.Length >= 1 Then
            txt6.ReadOnly = True
        End If
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub txt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub txt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub txt5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Discard the non-digit character
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim OTP As Integer = OTPEmailForm.OTP
        Dim enteredOTP As String = txt1.Text & txt2.Text & txt3.Text & txt4.Text & txt5.Text & txt6.Text

        If enteredOTP = OTP.ToString() Then
            ForgotPasswordForm.ShowDialog()

            OTPEmailForm.Close()
            Me.Close()
        Else
            MsgBox("The OTP that you entered is incorrect. Please try again.", 0 & MsgBoxStyle.Exclamation, "INCORRECT OTP")
        End If
    End Sub
End Class