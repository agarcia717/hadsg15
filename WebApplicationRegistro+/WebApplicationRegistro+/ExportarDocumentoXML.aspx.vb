Imports System.IO
Imports System.Xml

Public Class ExportarDocumentoXML
    Inherits System.Web.UI.Page
    Dim dt As New DataTable
    Dim bd As New dataBase.AccesoBD
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim correo As String = Session("email")

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bd.Conectar()
        Dim dt As DataTable = bd.DataT(DropDownList1.SelectedValue.ToString)
        Dim ds As DataSet = bd.DataSetT(DropDownList1.SelectedValue.ToString)
        bd.CerrarConexion()



        Dim tareas As XmlElement
        Dim tarea As XmlElement
        Dim descripcion As XmlElement
        Dim hestimadas As XmlElement
        Dim explotacion As XmlElement
        Dim tipotarea As XmlElement

        Dim codigo As XmlAttribute

        Dim document As New XmlDocument
        tareas = document.CreateElement("tareas")
        Try


            For Each r As DataRow In dt.Rows



                tarea = document.CreateElement("tarea")
                descripcion = document.CreateElement("descripcion")
                hestimadas = document.CreateElement("hestimadas")
                explotacion = document.CreateElement("explotacion")
                tipotarea = document.CreateElement("tipotarea")

                codigo = document.CreateAttribute("codigo")

                descripcion.AppendChild(document.CreateTextNode(r.Item("Descripcion")))
                hestimadas.AppendChild(document.CreateTextNode(r.Item("HEstimadas")))
                explotacion.AppendChild(document.CreateTextNode(r.Item("Explotacion")))
                tipotarea.AppendChild(document.CreateTextNode(r.Item("TipoTarea")))
                codigo.AppendChild(document.CreateTextNode(r.Item("Codigo")))

                tarea.Attributes.Append(codigo)
                tarea.AppendChild(descripcion)
                tarea.AppendChild(hestimadas)
                tarea.AppendChild(explotacion)
                tarea.AppendChild(tipotarea)

                tareas.AppendChild(tarea)

            Next


        Catch ex As Exception
            Label1.Text = "Error al exportar"
        End Try

        Label1.Text = "Tareas exportadas correctamente "
        document.AppendChild(tareas)
        document.Save(Server.MapPath("~/App_Data/" & DropDownList1.SelectedValue.ToString & ".xml"))


    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("~/Profesor.aspx")
    End Sub


End Class