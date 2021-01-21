Imports System.Data.SqlClient

Public Class AddPatient
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim myreader As SqlDataReader

    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'displaying the months days and years in the combobox
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(i)
        Next

        For i As Integer = 1 To 31
            cmbDay.Items.Add(i)
        Next

        For i As Integer = 1930 To 2020
            cmbYear.Items.Add(i)
        Next

        'Loads all the doctors in the combo box from the doctor table
        myconn.Open()
        mycmd = New SqlCommand("Select LastName from Doctor", myconn)
        myreader = mycmd.ExecuteReader()
        While (myreader.Read())
            cmbDoctor.Items.Add("Dr." + myreader(("LastName")))
        End While
        myreader.Close()

        'Loads the pharmacy names in the combo box
        mycmd = New SqlCommand("Select PharName from Pharmacy", myconn)
        myreader = mycmd.ExecuteReader()
        While (myreader.Read())
            cmbPharmacy.Items.Add(myreader("PharName"))
        End While
        myreader.Close()
        myconn.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim errorFlag As Boolean = False
        Dim errorMsg As String = ""

        'errorchecking making sure all the information needed is filled out
        If (txtFname.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please Enter in a Name!" + vbCrLf

        End If
        If (txtLname.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in a last Name!" + vbCrLf

        End If
        If (txtAddress.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in their address!" + vbCrLf
        End If
        If (txtPhone.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in their phone number!" + vbCrLf

        End If
        If (cmbMonth.Text = "" Or cmbDay.Text = "" Or cmbYear.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in their Birithday!" + vbCrLf

        End If
        If (cmbDoctor.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in their primary doctor" + vbCrLf

        End If
        If (cmbPharmacy.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter in their pharmacy!"
        End If

        'displays errormessage of what needs to be filled out
        If (errorFlag = True) Then
            MessageBox.Show(errorMsg)

        Else
            Dim dob As String
            Dim docID As Integer
            Dim pharmID As Integer

            'puting the birtday in date format
            dob = cmbMonth.Text + "/" + cmbDay.Text + "/" + cmbYear.Text

            docID = getDocID(cmbDoctor.Text)

            pharmID = getPharmID(cmbPharmacy.Text)

            myconn.Open()
            'inserting the values into the patient table
            mycmd = New SqlCommand("AddPatient", myconn) With
            {
                .CommandType = CommandType.StoredProcedure
            }

            mycmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
            mycmd.Parameters.AddWithValue("@LastName", txtLname.Text)
            mycmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            mycmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            mycmd.Parameters.AddWithValue("@DOB", dob)
            mycmd.Parameters.AddWithValue("@DoctorID", docID)
            mycmd.Parameters.AddWithValue("@PharmacyID", pharmID)

            Try
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Patient Added!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            myconn.Close()

            Home.Show()
            Me.Close()

        End If
    End Sub
    'gets the doctorID from the doctor table
    Public Function getDocID(name As String) As Integer
        Dim id As Integer
        Dim docName As String

        docName = name.Substring(3)
        myconn.Open()
        mycmd = New SqlCommand("Select DoctorID from Doctor where LastName = '" + docName + "'", myconn)
        myreader = mycmd.ExecuteReader()
        myreader.Read()
        id = myreader("DoctorID")
        myreader.Close()
        myconn.Close()


        Return id
    End Function
    'gets the pharmacyID from pharmacy table
    Public Function getPharmID(name As String) As Integer
        Dim id As Integer

        myconn.Open()
        mycmd = New SqlCommand("Select PharmID from Pharmacy where PharName ='" + name + "'", myconn)
        myreader = mycmd.ExecuteReader()
        myreader.Read()
        id = myreader(0)
        myreader.Close()
        myconn.Close()


        Return id
    End Function


End Class