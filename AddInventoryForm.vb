Imports System.Data.OleDb

Public Class AddInventoryForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private inventoryForm As InventoryForm ' Reference to InventoryForm

    Public Sub New(inventoryForm As InventoryForm)
        InitializeComponent()
        Me.inventoryForm = inventoryForm
    End Sub

    Private Sub AddInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim productName As String = txtProductName.Text
        Dim quantity As String = txtQuantity.Text
        Dim expiryDate As DateTime = datExpiry.Value.Date


        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Dim donorID As Integer = LoginForm.globalUserID
        sql = "INSERT INTO Inventory (donorID,product, quantity, expiryDate) VALUES (@DonorID,@Product, @Quantity, @ExpiryDate)"

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", donorID)
        command.Parameters.AddWithValue("@Product", productName)
        command.Parameters.AddWithValue("@Quantity", quantity)
        command.Parameters.AddWithValue("@ExpiryDate", expiryDate)

        command.ExecuteNonQuery()
        MsgBox("Item Added.", 0 & MsgBoxStyle.Information, "Added")

        inventoryForm.RefreshData()
        Me.Close()

    End Sub


End Class