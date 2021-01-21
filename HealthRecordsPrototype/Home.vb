Imports System.Data.SqlClient

Public Class Home
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim myreader As SqlDataReader
    Dim pid As Integer
    Public currentUser As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentUser = Login.user
        lblUser.Text = currentUser

        'disables prescriptions if not a doctor type login
        'disables payment if not an employee
        If (Login.accType = "Employee") Then
            prescriptions.Enabled = False
            payments.Enabled = True
        ElseIf (Login.accType = "Doctor") Then
            prescriptions.Enabled = True
            payments.Enabled = False
        End If
        'Loads all the doctors in the combo box from the doctor database
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

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles payments.Click
        Payment.Show()
        Me.Hide()
        clearOutput()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub AddPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPatientToolStripMenuItem.Click
        AddPatient.Show()
        Me.Hide()
        clearOutput()
    End Sub

    Private Sub EditPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPatientToolStripMenuItem.Click
        'enables all the textboxs to edit patient record when searched for a patient
        If (txtFname.Text = "" Or txtLname.Text = "") Then
            MessageBox.Show("Please search for a Patient!")
        Else
            txtFname.Enabled = True
            txtLname.Enabled = True
            txtPhone.Enabled = True
            txtAddress.Enabled = True
            cmbDoctor.Enabled = True
            cmbPharmacy.Enabled = True


        End If
    End Sub

    Private Sub AddPatientRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPatientRecordToolStripMenuItem.Click
        PatientRecord.Show()
        Me.Hide()
        clearOutput()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim name As String
        Dim first As String
        Dim last As String
        Dim space As Integer
        Dim nameFlag As Boolean = False


        If (txtSearch.Text = "") Then
            MessageBox.Show("Please search for a Patient!")
        ElseIf (nameFlag = False) Then

            name = txtSearch.Text
            Try

                space = name.IndexOf(" ")
                first = name.Substring(0, space)
                last = name.Substring(space + 1)
                nameFlag = True

            Catch ex As Exception
                MessageBox.Show("Please Enter in a first AND last name")
            End Try
        End If

        If (nameFlag = True) Then
            displayPatientData(first, last)

        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim docID As Integer
        Dim pharmID As Integer

        'have to search for a patient first
        If (txtFname.Text = "" Or txtLname.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "") Then
            MessageBox.Show("Please search for a patient or don't leave anything Blank!")
        Else
            'get pharmID and docID 
            docID = AddPatient.getDocID(cmbDoctor.Text)
            pharmID = AddPatient.getPharmID(cmbPharmacy.Text)
            'updates the patient table with the patient records
            myconn.Open()
            mycmd = New SqlCommand("UpdatePatient", myconn) With
            {
                .CommandType = CommandType.StoredProcedure
            }

            mycmd.Parameters.AddWithValue("@PatientID", pid)
            mycmd.Parameters.AddWithValue("@FirstName", txtFname.Text)
            mycmd.Parameters.AddWithValue("@LastName", txtLname.Text)
            mycmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            mycmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
            mycmd.Parameters.AddWithValue("@DoctorID", docID)
            mycmd.Parameters.AddWithValue("@PharmacyID", pharmID)

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            myconn.Close()

            disableInput()

        End If




    End Sub
    'selects all the patient records from the patientInfo view based on their first and last name
    Private Sub displayPatientData(first As String, last As String)
        myconn.Open()
        mycmd = New SqlCommand("Select * from PatientInfo where FirstName = '" + first + "' and LastName = '" + last + "'", myconn)
        Try
            myreader = mycmd.ExecuteReader()
            myreader.Read()
            pid = myreader("PatientID")
            txtFname.Text = myreader("FirstName")
            txtLname.Text = myreader("LastName")
            txtPhone.Text = myreader("Phone")
            txtAddress.Text = myreader("Address")
            txtDOB.Text = myreader("DOB")
            cmbDoctor.Text = "Dr." + myreader("DoctorName")
            cmbPharmacy.Text = myreader("PharName")


        Catch ex As Exception
            MessageBox.Show("Invaild Patient")
        End Try
        myreader.Close()
        myconn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        clearOutput()



    End Sub

    'clears all the outputs
    Private Sub clearOutput()
        txtFname.Text = ""
        txtLname.Text = ""
        txtAddress.Text = ""
        txtDOB.Text = ""
        txtPhone.Text = ""
        cmbDoctor.SelectedIndex = -1
        cmbPharmacy.SelectedIndex = -1
        txtSearch.Text = ""
        disableInput()
    End Sub
    Private Sub disableInput()
        txtFname.Enabled = False
        txtLname.Enabled = False
        txtAddress.Enabled = False
        txtPhone.Enabled = False
        cmbDoctor.Enabled = False
        cmbPharmacy.Enabled = False
    End Sub



    Private Sub prescriptions_Click(sender As Object, e As EventArgs) Handles prescriptions.Click
        OrderPrescription.Show()
        Me.Hide()
        clearOutput()
    End Sub
End Class