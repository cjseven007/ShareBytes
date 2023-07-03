Public Class ViewDonationForm
    Dim donateID, requestTitle, donorOrg, donateDistance, donateFare, status As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal donationID As String, ByVal title As String, ByVal organization As String, ByVal distance As String, ByVal fare As String, ByVal deliverStatus As String)
        ' This constructor accepts all the parameters

        ' Perform any initialization or processing with the passed values here
        InitializeComponent()

        ' Set the values to the corresponding controls in OtherForm
        donateID = donationID
        requestTitle = title
        donorOrg = organization
        donateDistance = distance
        donateFare = fare
        status = deliverStatus
    End Sub
    Private Sub ViewDonationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = requestTitle
        lblDonor.Text = donorOrg
        lblDistance.Text = donateDistance & " km"
        lblFare.Text = "RM " & donateFare
        lblStatus.Text = status
    End Sub
End Class