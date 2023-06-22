Imports System.Data.OleDb
Imports InventoryForm
Imports System.Runtime.Remoting.Contexts

Public Class InventoryEditForm
    Private inventoryForm As InventoryForm ' Reference to InventoryForm
    Public Property ProductID As Integer
    Public Property Product As String
    Public Property Quantity As String
    Public Property ExpiryDate As String

    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Sub New(inventoryForm As InventoryForm)
        InitializeComponent()
        Me.inventoryForm = inventoryForm
    End Sub

    Private Sub InventoryEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        lblTitle.Text = Product
        lblQuantity.Text = Quantity
        txtProductName.Text = Product
        txtQuantity.Text = Quantity
        datExpiry.Text = ExpiryDate
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
        sql = "UPDATE Inventory SET product = @Product, quantity = @Quantity, expiryDate = @ExpiryDate WHERE ID = @ProductID"

        command = New OleDbCommand(sql, connect)

        command.Parameters.AddWithValue("@Product", productName)
        command.Parameters.AddWithValue("@Quantity", quantity)
        command.Parameters.AddWithValue("@ExpiryDate", expiryDate)
        command.Parameters.AddWithValue("@ID", ProductID)

        command.ExecuteNonQuery()
        MsgBox("Item Updated.", 0 & MsgBoxStyle.Information, "Updated")

        inventoryForm.RefreshData()
        connect.Close()
        Me.Close()
    End Sub
End Class