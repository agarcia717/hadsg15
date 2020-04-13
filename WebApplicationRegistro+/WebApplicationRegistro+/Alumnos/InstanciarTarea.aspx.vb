Imports System.Data.SqlClient


Public Class InstanciarTarea
    Inherits System.Web.UI.Page
    Dim bd As New dataBase.AccesoBD

    Dim dttabla As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Label1.Text = Session("email")
        Label2.Text = Request.QueryString("codigo")
        Label3.Text = Request.QueryString("horasestimadas")


        bd.Conectar()
        Session("datosA") = bd.DataTEstudiantesTarea(Session("email"))
        bd.CerrarConexion()
        dttabla = Session("datosA")
        GridView1.DataSource = dttabla
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tarea As SqlDataReader
        Dim cod As String
        bd.Conectar()


        tarea = bd.getTarea(Session("email"), Request.QueryString("codigo"))
        While tarea.Read
            cod = tarea.Item("CodTarea")
        End While
        tarea.Close()

        Dim hr As Integer = CInt(TextBox1.Text)
        If cod = Label2.Text Then
            bd.ModTarea(Label1.Text, cod, hr)
        Else
            bd.AddTarea(Label1.Text, Label2.Text, CInt(Label3.Text), hr)
        End If


        Session("datosA") = bd.DataTEstudiantesTarea(Session("email"))
        bd.CerrarConexion()
        dttabla = Session("datosA")
        GridView1.DataSource = dttabla
        GridView1.DataBind()

    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("TareasAlumno.aspx")
    End Sub

End Class