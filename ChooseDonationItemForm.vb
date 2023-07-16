Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ChooseDonationItemForm
    Dim viewRequestForm As ViewRequestForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim donorID As String = LoginForm.globalUserID
    Private linearRegressionModel As LinearRegressionModel 'reference LinearRegressionModel Class file


    Dim requestorID As Integer
    Dim requestID As Integer
    Dim latitude As String
    Dim longitude As String
    Public Sub New(ByVal CRequestorID As Integer, ByVal CRequestID As Integer, ByVal CLatitude As String, ByVal CLongitude As String)
        InitializeComponent()
        ' Use the received values as needed in the destination form
        requestorID = CRequestorID
        requestID = CRequestID
        latitude = CLatitude
        longitude = CLongitude
    End Sub
    Private Sub ChooseDonationItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        sql = "SELECT * FROM Inventory WHERE donorID = @DonorID AND status IS NULL"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", donorID)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        While reader.Read()
            Dim itemID As String = reader("ID").ToString()
            Dim itemName As String = reader("product").ToString()
            Dim quantity As String = reader("quantity").ToString()
            Dim itemText As String = String.Format("{0}: {1}, quantity: {2}", itemID, itemName, quantity)

            lstInventory.Items.Add(itemText)

        End While
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lstInventory.SelectedIndex <> -1 Then
            lstDonationItems.Items.Add(lstInventory.SelectedItem)
            lstInventory.Items.Remove(lstInventory.SelectedItem)
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstDonationItems.SelectedIndex <> -1 Then
            lstInventory.Items.Add(lstDonationItems.SelectedItem)
            lstDonationItems.Items.Remove(lstDonationItems.SelectedItem)
        End If

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
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'Getting the ID's of all the items and store in a list
        'Dim itemsArray(lstDonationItems.Items.Count - 1) As String
        Dim itemString As String
        ' Loop through each item in the ListBox and add them to the array
        For i As Integer = 0 To lstDonationItems.Items.Count - 1
            itemString += Val(lstDonationItems.Items(i)).ToString()
            itemString += " "
        Next i

        'Change the inventory status to "donated"
        Dim subIDs() As String = itemString.Split(" "c)
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        For Each id As String In subIDs
            sql = "UPDATE Inventory SET status = 'donated' WHERE ID = @ProductID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@ProductID", id)
            command.ExecuteNonQuery()
        Next

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        sql = "UPDATE Requests SET status = @Status where RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@Status", "Pending")
        command.Parameters.AddWithValue("@RequestID", requestID)

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
        Dim distance As Double = CalculateDistance(userLatitude, userLongitude, latitude, longitude)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''
        'Use distance obatained to predict the fare price
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Reads csv file to predict fare
        ' Read the CSV file
        Dim csvData = File.ReadAllLines("D:/UTP/Foundation 3rd Sem/VP/ml.csv") 'change to real dataset later

        ' Parse the data into arrays
        Dim distances = csvData.Skip(1).Select(Function(line) Double.Parse(line.Split(","c)(0))).ToArray()
        Dim fares = csvData.Skip(1).Select(Function(line) Double.Parse(line.Split(","c)(1))).ToArray()

        ' Create an instance of LinearRegressionModel
        Dim linearRegressionModel As New LinearRegressionModel(distances, fares)
        ' Train the linear regression model
        linearRegressionModel.Train()
        ' Access the slope and intercept
        Dim slope As Double = linearRegressionModel.Slope
        Dim intercept As Double = linearRegressionModel.Intercept

        Dim predictedFare = linearRegressionModel.PredictFare(distance)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Add donation to Donations Table
        sql = "INSERT INTO Donations (donorID, requestorID, requestID, distance, fare, deliverStatus, itemsList) VALUES (@DonorID, @RequestorID, @RequestID, @Distance, @Fare, @Status, @ItemsList)"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", userID)
        command.Parameters.AddWithValue("@RequestorID", requestorID)
        command.Parameters.AddWithValue("@RequestID", requestID)
        command.Parameters.AddWithValue("@Distance", distance.ToString("0.00"))
        'Add predicted fare
        command.Parameters.AddWithValue("@Fare", predictedFare.ToString("0.00"))
        command.Parameters.AddWithValue("@Status", "Pending Payment")
        command.Parameters.AddWithValue("@ItemsList", itemString)
        command.ExecuteNonQuery()


        MsgBox("Donation record addedd. Status: Pending", 0, "Donation Added")
        Me.Close()
    End Sub
End Class