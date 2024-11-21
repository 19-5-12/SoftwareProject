Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form3
    Public user As Integer
    Public con As New MySqlConnection
    Public com As New MySqlCommand
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "server=localhost;userid=root;password='';database=db_softwareproject"
            con.Open()
        End If
        Dim connect As String
        connect = "select `name`, `birthday`, `email`, `contact` from roleinfo where userid= '" & user & "'"
        com = New MySqlCommand(connect, con)
        Dim read As MySqlDataReader = com.ExecuteReader

        If read.Read() Then
            Dim result = read("name").ToString()
            shadowname.Text = result
            shadowname.Refresh()
            address.Text = read("birthday").ToString
            age.Text = read("email").ToString
            gender.Text = read("contact").ToString
        Else
            MessageBox.Show("No information found for User ID: " & user)
        End If

    End Sub

    Public Sub New(userID As Integer)
        InitializeComponent()
        user = userID
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listForm As New List()
        listForm.id = user
        listForm.Show()
        Me.Hide()
    End Sub


End Class