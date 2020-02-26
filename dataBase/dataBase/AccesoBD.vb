
Imports System.Data.SqlClient
Public Class AccesoBD



    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand


    Public Shared Function Conectar() As String
        Try
            conexion.ConnectionString = "Server=tcp:hads.database.windows.net,1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Sub CerrarConexion()
        conexion.Close()
    End Sub



    Public Shared Function Insertar(ByVal email As String, ByVal nombre As String, ByVal apellidos As String, ByVal numconf As Integer, ByVal confirmado As Boolean, ByVal tipo As String, ByVal pass As String, ByVal codpass As Integer) As String
        Dim st = "insert into Usuarios values ('" & email & " ','" & nombre & " ','" & apellidos & " '," & numconf & ",'" & confirmado & "','" & tipo & " ','" & pass & " '," & codpass & ")"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return (numregs & " registro(s) insertado(s) en la BD ")
    End Function

    Public Shared Function ConfirmarReg(ByVal email As String) As String
        Dim st = "Update Usuarios Set [confirmado]='1' Where email='" & email & " '"
        comando = New SqlCommand(st, conexion)
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return email
    End Function

    Public Shared Function SetCodPass(ByVal email As String, ByVal codigo As Integer) As String
        Dim st = "Update Usuarios Set [codpass]='" & codigo & " ' Where email='" & email & " '"
        comando = New SqlCommand(st, conexion)
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return email
    End Function

    Public Shared Function GetCodPass(ByVal email As String) As Integer
        'Dim data As SqlDataReader
        Dim st = "Select codpass From Usuarios Where email='" & email & " '"
        comando = New SqlCommand(st, conexion)
        Dim result As Object = comando.ExecuteScalar()

        '
        'data = comando.ExecuteReader()
        'Catch ex As Exception
        'End Try
        Return result
    End Function

    Public Shared Function ModPass(ByVal email As String, ByVal pass As String) As String
        Dim st = "Update Usuarios Set [pass]='" & pass & " ' Where email='" & email & " '"
        comando = New SqlCommand(st, conexion)
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return email
    End Function

    Public Shared Function Login(ByVal email As String) As SqlDataReader
        Dim st = "Select email, pass, confirmado From Usuarios Where email='" & email & "'"
        comando = New SqlCommand(st, conexion)
        Return (comando.ExecuteReader())

    End Function
End Class
