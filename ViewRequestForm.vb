Imports System.Data.OleDb

Public Class ViewRequestForm
    Private donateForm As DonateForm ' Reference to requestForm
    Public Property RequestorID As Integer
    Public Property RequestID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property Location As String
    Public Property Latitude As String
    Public Property Longitude As String
    Public Property Pax As String

    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Sub New(donateForm As DonateForm)
        InitializeComponent()
        Me.donateForm = donateForm
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub ViewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        lblTitle.Text = Title
        lblDescription.Text = Description
        lblLocation.Text = Location
        lblPax.Text = Pax
    End Sub

    ' Function to calculate the distance using the Haversine formula
    Private Function CalculateDistance(lat1 As Double, lon1 As Double, lat2 As Double, lon2 As Double) As Double
        Dim R As Double = 6371 ' Earth's radius in kilometers

        Dim dLat As Double = DegreeToRadian(lat2 - lat1)
        Dim dLon As Double = DegreeToRadian(lon2 - lon1)

        Dim a As Double = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                      Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
                      Math.Sin(dLon / 2) * Math.Sin(dLon / 2)

        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))

        Dim distance As Double = R * c
        Return distance
    End Function

    Private Function DegreeToRadian(deg As Double) As Double
        Return deg * (Math.PI / 180)
    End Function
    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        sql = "UPDATE Requests SET status = @Status where RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@Status", "Pending")
        command.Parameters.AddWithValue("@RequestID", RequestID)

        command.ExecuteNonQuery()

        'Get user latitude and longitude
        Dim userID As Integer = LoginForm.globalUserID
        sql = "SELECT latitude, longitude FROM [User] WHERE ID = @UserID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@UserID", userID)
        Dim reader1 As OleDbDataReader = command.ExecuteReader()


        Dim userLatitude As Double
        Dim userLongitude As Double
        If reader1.Read() Then
            userLatitude = CDbl(reader1("latitude"))
            userLongitude = CDbl(reader1("longitude"))
            reader1.Close()
        Else
            reader1.Close()
        End If
        ' Calculate the distance using the Haversine formula
        Dim distance As Double = CalculateDistance(userLatitude, userLongitude, Latitude, Longitude)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Add donation to Donations Table
        sql = "INSERT INTO Donations (donorID, requestorID, distance, fare, deliverStatus) VALUES (@DonorID, @RequestorID, @Distance, @Fare, @Status)"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", userID)
        command.Parameters.AddWithValue("@RequestorID", RequestorID)
        command.Parameters.AddWithValue("@Distance", distance.ToString("0.00"))
        command.Parameters.AddWithValue("@Fare", 20)
        command.Parameters.AddWithValue("@Status", "Pending")
        command.ExecuteNonQuery()


        MsgBox("Donation record addedd. Status: Pending", 0, "Donation Added")

        donateForm.DonateFormRefreshData()
        Me.Close()
    End Sub
End Class