Imports System.Data.SqlClient

Public Class Payment
    Dim myconn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\HealthRecordsPrototype\HealthRecordsDB.mdf;Integrated Security=True")
    Dim mycmd As SqlCommand
    Dim myreader As SqlDataReader
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPayment.Items.Add("Check")
        cmbPayment.Items.Add("Credit Card")


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim errorFlag As Boolean = False
        Dim errorMsg As String = ""
        Dim first As String
        Dim last As String
        Dim space As Integer
        Dim name As String
        Dim nameFlag As Boolean = False
        Dim pid As Integer
        Dim patientFound = False
        Dim eID As Integer

        'errorchecking 
        If cmbPayment.Text = "" Then
            errorFlag = True
            errorMsg = errorMsg + "Please select a payment method" + vbCrLf
        End If

        If (cmbPayment.Text = "Check" And txtCheck.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in the check number" + vbCrLf

        End If

        If (cmbPayment.Text = "Credit Card" And txtCard.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill in the card number" + vbCrLf
        End If

        If (txtName.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please enter the patients name" + vbCrLf
        End If

        If (txtAmount.Text = "") Then
            errorFlag = True
            errorMsg = errorMsg + "Please fill the amount!" + vbCrLf
        End If
        'displays all the information that needs to be filled out
        If (errorFlag = True) Then
            MessageBox.Show(errorMsg)
        Else

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
                'gets employeeID from database
                mycmd = New SqlCommand("Select PatientID from Patient where LastName = '" + last + "' and FirstName = '" + first + "'", myconn)

                Try
                    myreader = mycmd.ExecuteReader()
                    myreader.Read()
                    pid = myreader("PatientID")
                    myreader.Close()
                    patientFound = True
                Catch ex As Exception
                    MessageBox.Show("Invaild Patient")
                End Try
                myreader.Close()
                myconn.Close()
            End If
            'patient is in the database
            If (patientFound = True) Then
                myconn.Open()
                mycmd = New SqlCommand("Select EmployeeID from Employee where Username = '" + Home.currentUser + "'", myconn)
                Try
                    myreader = mycmd.ExecuteReader()
                    myreader.Read()
                    eID = myreader("EmployeeID")
                    myreader.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                myconn.Close()
                If (cmbPayment.Text = "Check") Then

                    myconn.Open()
                    'adding the payment record that is a check
                    mycmd = New SqlCommand("AddCheck", myconn) With
                    {
                        .CommandType = CommandType.StoredProcedure
                    }
                    'adding values to the parameters. 
                    mycmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
                    mycmd.Parameters.AddWithValue("@PaymentMethod", cmbPayment.Text)
                    mycmd.Parameters.AddWithValue("@CheckNum", txtCheck.Text)
                    mycmd.Parameters.AddWithValue("@PatientID", pid)
                    mycmd.Parameters.AddWithValue("@EmployeeID", eID)

                    Try
                        mycmd.ExecuteNonQuery()
                        MessageBox.Show("Payment Confirmed")
                        myconn.Close()
                        Home.Show()
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        myconn.Close()
                    End Try

                    'adding payment records if credit card is selected
                ElseIf (cmbPayment.Text = "Credit Card") Then
                    myconn.Open()
                    mycmd = New SqlCommand("AddCard", myconn) With
                    {
                        .CommandType = CommandType.StoredProcedure
                    }

                    mycmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
                    mycmd.Parameters.AddWithValue("@PaymentMethod", cmbPayment.Text)
                    mycmd.Parameters.AddWithValue("@CardNumber", txtCard.Text)
                    mycmd.Parameters.AddWithValue("@PatientID", pid)
                    mycmd.Parameters.AddWithValue("@EmployeeID", eID)

                    Try
                        mycmd.ExecuteNonQuery()
                        MessageBox.Show("Payment Confirmed")
                        myconn.Close()
                        Home.Show()
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        myconn.Close()
                    End Try

                End If
            End If

        End If
    End Sub
End Class