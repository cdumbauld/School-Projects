Imports System.Data.SqlClient


Public Class CreateAccount
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim errorFlag As Boolean = False
        Dim errorMsg As String = ""
        Dim username As String
        Dim jobtitle As String = ""
        Dim dob As String = ""



        'Error Handler
        If txtFname.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please Enter your First Name!" + vbCrLf
        End If
        If txtLname.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter your Last Name!" + vbCrLf
        End If
        If txtPassword.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in a password!" + vbCrLf
        End If

        If txtCpassword.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter your password again!" + vbCrLf
        End If

        If txtPassword.Text <> txtCpassword.Text Then
            errorFlag = True
            errorMsg = errorMsg + "Your Passwords do not match!" + vbCrLf

        End If

        If cmbMonth.Text = "" Or cmbDay.Text = "" Or cmbYear.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please Enter in your birthday" + vbCrLf
        Else
            dob = cmbMonth.Text + "/" + cmbDay.Text + "/" + cmbYear.Text
        End If

        If rdDoctor.Checked = False And rdRep.Checked = False And rdNurse.Checked = False Then
            errorFlag = True
            errorMsg = errorMsg + "Please select a job title!"
        End If
        If (rdRep.Checked = True) Then
            jobtitle = "Rep"
        ElseIf (rdNurse.Checked = True) Then
            jobtitle = "Nurse"
        ElseIf (rdDoctor.Checked = True) Then
            jobtitle = "Doctor"
        End If

        If rdDoctor.Checked = True And txtSpeciality.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in your speciality!"
        End If



        'displays what information needs to be filled out
        If errorFlag = True Then
            MessageBox.Show(errorMsg)
        ElseIf (errorFlag = False And rdDoctor.Checked = False) Then 'goes to employee table

            'generates Username
            username = generateUsername(txtFname.Text, txtLname.Text)


            'Assign data to variables
            Dim mycmd As New SqlCommand("AddEmployee", myconn) With
            {
                .CommandType = CommandType.StoredProcedure
            }

            mycmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
            mycmd.Parameters.AddWithValue("@LastName", txtLname.Text)
            mycmd.Parameters.AddWithValue("@Username", username)
            mycmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            mycmd.Parameters.AddWithValue("@JobTitle", jobtitle)
            mycmd.Parameters.AddWithValue("@DOB", dob)

            'Open Connection
            myconn.Open()

            'ErrorCheck
            Try
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Username:" & username & vbCrLf & "You can login in now!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Close Connection
            myconn.Close()

            Login.Show()
            Me.Close()

        ElseIf (errorFlag = False And rdDoctor.Checked = True) Then 'Goes to doctor table
            'generates username
            username = generateUsername(txtFname.Text, txtLname.Text)


            'Assign data to variables
            Dim mycmd As New SqlCommand("AddDoctor", myconn) With {
                .CommandType = CommandType.StoredProcedure
            }

            mycmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
            mycmd.Parameters.AddWithValue("@LastName", txtLname.Text)
            mycmd.Parameters.AddWithValue("@Username", username)
            mycmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            mycmd.Parameters.AddWithValue("@DOB", dob)
            mycmd.Parameters.AddWithValue("@Speciality", txtSpeciality.Text)

            'Open Connection
            myconn.Open()

            'ErrorCheck
            Try
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Username:" & username & vbCrLf & "You can login in now!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Close Connection
            myconn.Close()

            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads all the months days and years.
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(i)
        Next

        For i As Integer = 1 To 31
            cmbDay.Items.Add(i)
        Next

        For i As Integer = 1930 To 2020
            cmbYear.Items.Add(i)
        Next

    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtPassword.PasswordChar = ""
            txtCpassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            txtCpassword.PasswordChar = "*"
        End If
    End Sub

    'generate a username for user
    Private Function generateUsername(first As String, last As String) As String
        Dim randDigit As New Random
        Dim digit As String = ""
        Dim num As String = ""
        Dim username As String
        For i As Integer = 0 To 3
            digit = randDigit.Next(0, 10)
            num = num + digit
        Next

        username = (first(0) + last(0)).ToLower + num

        Return username
    End Function
End Class