Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient


' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Coordinador
    Inherits System.Web.Services.WebService
    Dim bd As New dataBase.AccesoBD
    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()>
    Public Function getHoras(ByVal asi As String) As Integer
        Dim aux As Integer
        bd.Conectar()
        aux = bd.getHoras(asi)
        bd.CerrarConexion()
        Return aux
    End Function

End Class