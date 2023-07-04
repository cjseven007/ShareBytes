Public Class PaymentForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        CardForm.ShowDialog()
    End Sub


    Private Sub btnManageAcc_Click(sender As Object, e As EventArgs) Handles btnManageAcc.Click
        ManagePayments.ShowDialog()
    End Sub

    Private Sub btnBanking_Click(sender As Object, e As EventArgs) Handles btnBanking.Click
        BankingForm.ShowDialog()
    End Sub
End Class