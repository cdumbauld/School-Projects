Imports System.Data.SqlClient

Public Class Login

    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim myreader As SqlDataReader
    Public user As String
    Public accType As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        user = ""
        accType = ""

        'error check login
        If (txtLogin.Text = "") Then
            MessageBox.Show("Please enter in your username!")
            'error check account type
        ElseIf (cmbAccount.Text <> "Doctor" And cmbAccount.Text <> "Employee") Then
            MessageBox.Show("Please specify the account type!")
        ElseIf (cmbAccount.Text = "Employee") Then 'if account type employee use employee table

            If (UsernameValidation(txtLogin.Text, cmbAccount.Text) = True) Then 'checks database for username
                username = getusername(txtLogin.Text, cmbAccount.Text)
                password = getPassword(txtLogin.Text, cmbAccount.Text)
                If username.Equals(txtLogin.Text) And password.Equals(txtPassword.Text) Then 'checks credentials
                    MessageBox.Show("You are logged in!")
                    user = username
                    accType = cmbAccount.Text
                    Home.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Password is wrong!") 'passwords do not match

                End If
            ElseIf (UsernameValidation(txtLogin.Text, cmbAccount.Text) = False) Then
                MessageBox.Show("Invalid Username!")

            End If
        ElseIf (cmbAccount.Text = "Doctor") Then 'Uses Doctor table to login
            If (UsernameValidation(txtLogin.Text, cmbAccount.Text) = True) Then 'Checks to see if username is in table
                username = getusername(txtLogin.Text, cmbAccount.Text)
                password = getPassword(txtLogin.Text, cmbAccount.Text)
                If (username.Equals(txtLogin.Text) And password.Equals(txtPassword.Text)) Then 'checks to see if username and password match
                    MessageBox.Show("You are logged in!")
                    user = username
                    accType = cmbAccount.Text
                    Home.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Password is wrong!") 'passwords do not match

                End If
            ElseIf (UsernameValidation(txtLogin.Text, cmbAccount.Text) = False) Then 'no username in database
                MessageBox.Show("Invalid Username!")

            End If
        End If




    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateAccount.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAccount.Items.Add("Doctor")
        cmbAccount.Items.Add("Employee")
    End Sub
    'gets the password for that user
    Private Function getPassword(name As String, table As String) As String
        Dim password As String

        myconn.Open()
        mycmd = New SqlCommand("Select Password from " + table + " where Username = '" + name + "'", myconn)

        myreader = mycmd.ExecuteReader()
        myreader.Read()
        password = myreader(0)
        myreader.Close()
        myconn.Close()
        Return password

    End Function
    'gets the username
    Private Function getusername(name As String, table As String) As String
        Dim uname As String

        myconn.Open()
        mycmd = New SqlCommand("Select Username from " + table + " where Username = '" + name + "'", myconn)

        myreader = mycmd.ExecuteReader()
        myreader.Read()
        uname = myreader(0)


        myreader.Close()
        myconn.Close()
        Return uname

    End Function
    'checks to see if the username is in the database
    Private Function UsernameValidation(name As String, table As String) As Boolean
        Dim valid As Boolean
        Dim uname As String

        myconn.Open()
        mycmd = New SqlCommand("Select Username from " + table + " where Username = '" + name + "'", myconn)
        Try
            myreader = mycmd.ExecuteReader()
            myreader.Read()
            uname = myreader(0)
            valid = True
            myreader.Close()
            myconn.Close()
            Return valid
        Catch ex As Exception
            valid = False
            myreader.Close()
            myconn.Close()
            Return valid
        End Try


    End Function

End Class
