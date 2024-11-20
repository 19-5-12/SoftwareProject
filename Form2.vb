Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Public Class Form2
    Public Event userchanged As EventHandler(Of Integer)
    Public con As New MySqlConnection
    Public com As New MySqlCommand

    Public user As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user = 0

        txtuser.Text = "Username"
        txtuser.ForeColor = Color.LightGray

        TextBox1.Text = "Password"
        TextBox1.ForeColor = Color.LightGray

        invisbtn.Focus()

        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "server=localhost;userid=root;password='';database=db_softwareproject"
                con.Open()
            End If
        Catch ex As mysql.data.mysqlclient.MySqlException
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Protected Overridable Sub onuserchanged()
        RaiseEvent userchanged(Me, user)
    End Sub

    Private Sub txtuser_GotFocus(sender As Object, e As EventArgs) Handles txtuser.GotFocus
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtuser_LostFocus(sender As Object, e As EventArgs) Handles txtuser.LostFocus
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Password" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.PasswordChar = "●"
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Password"
            TextBox1.ForeColor = Color.LightGray
            TextBox1.PasswordChar = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;password='';database=db_softwareproject"
        Dim result As Object

        Try
            con.Open()
            Dim login As String
            login = "select id from user where username='" & txtuser.Text & "' and password='" & TextBox1.Text & "'"
            com = New MySqlCommand(login, con)
            result = com.ExecuteScalar()

            If result IsNot Nothing Then

                user = Convert.ToInt32(result)
                onuserchanged()

                txtuser.Text = "Username"
                txtuser.ForeColor = Color.LightGray

                TextBox1.Text = "Password"
                TextBox1.ForeColor = Color.LightGray
                TextBox1.PasswordChar = ""

                Dim form3 As New Form3(user)
                form3.Show()
                Me.Hide()

            Else
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
End Class