Imports System.Data.SqlClient
Imports System.Xml

Public Class ImportarDocumentoXML

    Inherits System.Web.UI.Page
    Dim bd As New dataBase.AccesoBD
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim correo As String = Session("email")

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Xml1.DocumentSource = Server.MapPath("~/App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("~/App_Data/XSLTFile.xsl")
    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("Profesor.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bd.Conectar()

        Dim doc As New XmlDocument
        doc.Load(Server.MapPath("~/App_Data/" & DropDownList1.SelectedValue & ".xml"))
        Dim tareas As XmlNodeList
        tareas = doc.GetElementsByTagName("tarea")


        If bd.ImportarTareasXML(tareas, DropDownList1.SelectedValue.ToString) = "OK" Then
            Label1.Text = "Insertado en la base de datos "
        Else
            Label1.Text = "Error ya ha sido insertada la tarea"
        End If
        bd.CerrarConexion()
    End Sub

End Class