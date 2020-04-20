' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports System.Data.SqlClient
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function MediaAlumnos(ByVal asig As String) As Double Implements IService1.MediaAlumnos

        Dim con As New SqlConnection("Server=tcp:hads.database.windows.net,1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim da = "SELECT AVG(HReales) FROM TareasGenericas INNER JOIN EstudiantesTareas ON TareasGenericas.Codigo=EstudiantesTareas.CodTarea WHERE CodAsig ='" & asig & "'"
        Dim comando = New SqlCommand(da, con)
        con.Open()
        Dim result As Object = comando.ExecuteScalar()
        con.Close()

        If result Is DBNull.Value Then
            Return 0
        End If

        Return result
    End Function

End Class
