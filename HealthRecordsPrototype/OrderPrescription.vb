Imports System.Data.SqlClient

Public Class OrderPrescription
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim myreader As SqlDataReader


    Private Sub OrderPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Loads the pharmacy names in the combo box
        myconn.Open()
        mycmd = New SqlCommand("Select PharName from Pharmacy", myconn)
        myreader = mycmd.ExecuteReader()
        While (myreader.Read())
            cmbPharmacy.Items.Add(myreader("PharName"))
        End While
        myreader.Close()
        myconn.Close()





    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim pharmID As Integer
        Dim pid As Integer
        Dim docID As Integer
        Dim first As String
        Dim last As String
        Dim name As String
        Dim space As Integer
        Dim nameFlag As Boolean = False
        Dim patientFound As Boolean = False


        'error checks to see if all the information needed is filled out
        If (txtDrug.Text = "" Or txtDosage.Text = "" Or txtName.Text = "" Or cmbPharmacy.Text = "") Then
            MessageBox.Show("Please fill in all the information!")
        Else
            'Error checks so the user enters in a first and last name
            name = txtName.Text
            Try
                space = name.IndexOf(" ")
                first = name.Substring(0, space)
                last = name.Substring(space + 1)
                nameFlag = True
            Catch ex As Exception
                MessageBox.Show("Please enter in first AND last name!")
            End Try

            'searching for patient in the patient table
            If (nameFlag = True) Then
                myconn.Open()
                mycmd = New SqlCommand("Select PatientID from Patient where LastName = '" + last + "' and FirstName = '" + first + "'", myconn)

                Try
                    myreader = mycmd.ExecuteReader()
                    myreader.Read()
                    pid = myreader("PatientID")
                    myreader.Close()
                    patientFound = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                myreader.Close()
                myconn.Close()
            End If


            If (patientFound = True) Then ' patient is in database
                'getting doctorID
                myconn.Open()
                mycmd = New SqlCommand("Select DoctorID from Doctor where Username = '" + Home.currentUser + "'", myconn)
                myreader = mycmd.ExecuteReader()
                myreader.Read()
                docID = myreader("DoctorID")
                myreader.Close()
                pharmID = AddPatient.getPharmID(cmbPharmacy.Text)

                'adding the order to prescription table
                mycmd = New SqlCommand("AddPrescription", myconn) With
                {
                    .CommandType = CommandType.StoredProcedure
                }

                mycmd.Parameters.AddWithValue("@DrugName", txtDrug.Text)
                mycmd.Parameters.AddWithValue("@Dosage", txtDosage.Text)
                mycmd.Parameters.AddWithValue("@Refills", txtRefills.Text)
                mycmd.Parameters.AddWithValue("@PatientID", pid)
                mycmd.Parameters.AddWithValue("@PharmacyID", pharmID)
                mycmd.Parameters.AddWithValue("@DoctorID", docID)

                Try
                    mycmd.ExecuteNonQuery()
                    MessageBox.Show("Order Sent!")
                    myconn.Close()
                    Home.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    myconn.Close()
                End Try



            End If

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Me.Close()
    End Sub
End Class