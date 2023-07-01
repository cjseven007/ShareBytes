Public Class ViewRequestForm
    Private donateForm As DonateForm ' Reference to requestForm
    Public Property RequestID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property Location As String
    Public Property Latitude As String
    Public Property Longitude As String
    Public Property Pax As String

    Public Sub New(donateForm As DonateForm)
        InitializeComponent()
        Me.donateForm = donateForm
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub ViewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = Title
        lblDescription.Text = Description
        lblLocation.Text = Location
        lblPax.Text = Pax
    End Sub


End Class