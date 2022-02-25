Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class conexion
    Public con As New SqlConnection("Data Source=LAPTOP-UI924M90\SQLSERVER;Initial Catalog=DataTour;Integrated Security=True")

    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand


    Public Function Conectar() As Boolean
        Try
            con.Open()
            Return True

        Catch ex As Exception

            MessageBox.Show("Error al conectar")
            Return False

        End Try
    End Function
    Public Sub desconectar()
        Try
            If con.State = ConnectionState.Open Then

                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
