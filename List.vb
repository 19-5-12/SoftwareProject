Imports MySql.Data.MySqlClient
Public Class List
    Public con As New MySqlConnection
    Public id As Integer
    Dim com As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "server=localhost;userid=root;password='';database=db_softwareproject"
            con.Open()
        End If

        If id = 0 Then
            MessageBox.Show("User ID not set. Redirecting to login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Form2.Show()
            Me.Hide()
        Else
            loadinfo()
        End If
    End Sub

    Public Sub loadinfo()
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;password='';database=db_softwareproject"
        Dim adapt As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bsource As New BindingSource
        Try
            con.Open()
            Dim sel As String
            sel = "select * from list"
            com = New MySqlCommand(sel, con)
            adapt.SelectCommand = com
            adapt.Fill(table)
            bsource.DataSource = table
            DataGridView1.DataSource = bsource
            adapt.Update(table)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnadminpfp_Click(sender As Object, e As EventArgs) Handles btnadminpfp.Click
        Dim form3 As New Form3(id)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class