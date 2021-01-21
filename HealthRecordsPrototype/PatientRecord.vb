Imports System.Data.SqlClient

Public Class PatientRecord
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim mycmd2 As SqlCommand
    Dim myreader As SqlDataReader
    Dim pID As Integer
    Private Sub PatientRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String
        Dim first As String
        Dim last As String
        Dim space As Integer
        Dim nameFlag As Boolean = False
        Dim dataFlag As Boolean = False

        'Error checks so the user enters in a first and last name
        While (dataFlag = False)
            name = InputBox("Please enter in Patient's First and Last Name", "Name")
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
                mycmd = New SqlCommand("Select PatientID, FirstName, LastName from Patient where LastName = '" + last + "' and FirstName = '" + first + "'", myconn)

                Try
                    myreader = mycmd.ExecuteReader()
                    myreader.Read()
                    pID = myreader("PatientID")
                    txtFname.Text = myreader("FirstName")
                    txtLname.Text = myreader("LastName")
                    dataFlag = True

                Catch ex As Exception
                    MessageBox.Show("Invalid Patient")
                    nameFlag = False
                End Try
                myreader.Close()
                myconn.Close()
            End If
        End While
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim errorFlag As Boolean = False
        Dim errorMsg As String = ""
        Dim day As Date = Today
        Dim allergies() As String
        Dim allgy As String
        Dim delimiters() As String = {", ", ";", ":", "/", "."}

        'error Checking user input
        If (txtHeight.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in patients height!" + vbCrLf
        End If

        If (txtWeight.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in patients weight! " + vbCrLf
        End If

        If (txtVisit.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in the reason the patient is here today" + vbCrLf
        End If

        If (txtSummary.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in the appointment went."
        End If
        If (errorFlag = True) Then
            MessageBox.Show(errorMsg)
        Else

            'opening connection
            myconn.Open()

            'adding user input to parameters
            mycmd = New SqlCommand("AddRecord", myconn) With
            {
                .CommandType = CommandType.StoredProcedure
            }

            mycmd.Parameters.AddWithValue("@Date", day)
            mycmd.Parameters.AddWithValue("@Visit", txtVisit.Text)
            mycmd.Parameters.AddWithValue("@Height", txtHeight.Text)
            mycmd.Parameters.AddWithValue("@Weight", txtWeight.Text)
            mycmd.Parameters.AddWithValue("@Summary", txtSummary.Text)
            mycmd.Parameters.AddWithValue("@PatientID", pID)

            'Adding Allergies if it is not blank
            If (txtAllergies.Text <> "") Then
                allgy = txtAllergies.Text
                'Replace any of the delimiters that user could input and replacing them with a ","
                For j As Integer = 0 To delimiters.Length() - 1
                    allgy = allgy.Replace(delimiters(j), ",")
                Next
                'Spliting each allergy at the , and putting them in an array
                allergies = allgy.Split(",")

                'Adding each allergy to the allergy table one at a time
                For i As Integer = 0 To allergies.Length() - 1

                    mycmd2 = New SqlCommand("AddAllergy", myconn) With
                     {
                        .CommandType = CommandType.StoredProcedure
                     }

                    mycmd2.Parameters.AddWithValue("@AllergyName", allergies(i))
                    mycmd2.Parameters.AddWithValue("@PatID", pID)

                    Try
                        mycmd2.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Next

            End If

            'adding the patients record to the record table
            Try
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Patient Record Added!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'closing the connection
            myconn.Close()
            Home.Show()
            Me.Close()

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Me.Close()
    End Sub
End Class