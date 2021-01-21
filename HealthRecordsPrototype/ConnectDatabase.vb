Imports System.Data.SqlClient
Public Class ConnectDatabase
    Public conn As SqlConnection
    Public Sub ServerConnection()
        Try
            conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cole\Documents\WindowsApp1\HealthRecordsDB.mdf;Integrated Security=True;Connect Timeout=30")
            conn.Open()
            MessageBox.Show("Connected to database")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
