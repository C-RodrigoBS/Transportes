
Public Class registroControl

    Private nombreUsuario As String
    Private apeNombres As String
    Private contraseña As String
    Private tipoUsuario As String
    Private fechaCreacion As Date
    Private fechalog As Date

    Public Function getFechaCreacion() As Date
        Return fechaCreacion
    End Function
    Public Function getFechaLog() As Date
        Return fechalog
    End Function
    Public Function getNombreUsuario() As String
        Return nombreUsuario
    End Function

    Public Function getApeNombres() As String
        Return apeNombres
    End Function

    Public Function getContraseña() As String
        Return contraseña
    End Function

    Public Function getTipoUsuario() As String
        Return tipoUsuario
    End Function

    Public Sub setNombreUsuario(nu As String)
        nombreUsuario = nu
    End Sub

    Public Sub setApeNombres(an As String)
        apeNombres = an
    End Sub

    Public Sub setContraseña(pass As String)
        contraseña = pass
    End Sub

    Public Sub setTipoUsuario(tu As String)
        tipoUsuario = tu
    End Sub

    Public Sub setFechaCreacion(fc As Date)
        fechaCreacion = fc
    End Sub

    Public Sub setFechaLog(fl As Date)
        FechaLog = fl
    End Sub
End Class
