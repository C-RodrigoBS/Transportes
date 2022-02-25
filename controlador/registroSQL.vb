
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class registroSQL
    Inherits conexion

    Private cmb As SqlCommandBuilder

    Public Function registrar(rc As registroControl) As Boolean
        Try
            Conectar()
            Dim sql As String = "INSERT INTO TabUsers(NickName,Fullname,TipUser,FecCre,PwdUsr,UltFecLog)VALUES('" & rc.getNombreUsuario & "','" & rc.getApeNombres & "','" & rc.getTipoUsuario & "','" & rc.getFechaCreacion & "','" & rc.getContraseña & "','" & rc.getFechaLog & "')"



            cmb = New SqlCommandBuilder(sql, con)

        Catch ex As Exception

        End Try

    End Function
End Class
