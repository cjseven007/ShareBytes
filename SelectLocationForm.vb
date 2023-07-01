Imports System.Runtime.InteropServices
Imports System.Windows.Forms

<ComVisible(True)>
Public Class SelectLocationForm
    Private addRequestForm As AddRequestForm ' Reference to AddRequestForm
    Private editRequestForm As EditRequestForm
    Private editProfileForm As EditProfileForm
    Public Shared latitudeGlobal, longitudeGlobal, addressGlobal As String

    Public Sub New(addRequestForm As AddRequestForm)
        InitializeComponent()
        Me.addRequestForm = addRequestForm

    End Sub
    Public Sub New(editRequestForm As EditRequestForm)
        InitializeComponent()
        Me.editRequestForm = editRequestForm
    End Sub
    Public Sub New(editProfileForm As EditProfileForm)
        InitializeComponent()
        Me.editProfileForm = editProfileForm
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub SelectLocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wbbMap.ScriptErrorsSuppressed = False
        wbbMap.AllowNavigation = True
        wbbMap.Navigate("D:\UTP\Foundation 3rd Sem\VP\OMC stuff\ShareBytes Prototype\Resources\index.html")
        wbbMap.ObjectForScripting = Me 'This allows vb to interact with script in html
    End Sub

    'This is a function in javarscript file that can be called
    Public Sub UpdateLabels(latitude As String, longitude As String, address As String)
        txtLatitude.Text = latitude
        txtLongitude.Text = longitude
        txtAddress.Text = address
        'Store global variable
        latitudeGlobal = latitude
        longitudeGlobal = longitude
        addressGlobal = address
    End Sub



    Private Sub btnSelectLocation_Click(sender As Object, e As EventArgs) Handles btnSelectLocation.Click
        Dim document As HtmlDocument = wbbMap.Document

        Dim searchLocation As String = txtLocation.Text
        'Invoke the javascript function and pass the location text
        wbbMap.Document.InvokeScript("searchLocation", New Object() {searchLocation})
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Update the address in the textbox
        If addRequestForm IsNot Nothing AndAlso addRequestForm.Visible Then
            addRequestForm.txtRLocation.Text = addressGlobal
        ElseIf editRequestForm IsNot Nothing AndAlso editRequestForm.Visible Then
            editRequestForm.txtRLocation.Text = addressGlobal
        ElseIf editProfileForm IsNot Nothing AndAlso editProfileForm.Visible Then
            editProfileForm.txtAddress.Text = addressGlobal
        End If
        Me.Hide()
    End Sub
End Class