Imports System.Data.SqlClient


Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Dim bd As New dataBase.AccesoBD

    Dim coreo As String
    Dim res As SqlDataReader
    Dim dttabla As New DataTable


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        coreo = Session("email")
        If Page.IsPostBack Then
            dttabla = Session("datos")
        Else
            Dim seleccionar As New CommandField
            seleccionar.ButtonType = 0
            seleccionar.ShowSelectButton = True
            GridView1.Columns.Add(seleccionar)
            Dim asigs As New ArrayList
            asigs.Add("-- Asignatura --")
            bd.Conectar()

            res = bd.AsignaturasAlumno(coreo)
            While res.Read
                asigs.Add(res.Item("codigoasig"))
            End While
            asignaturas.DataSource = asigs
            asignaturas.DataBind()
            res.Close()

            bd.CerrarConexion()


        End If

    End Sub

    Protected Sub asignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles asignaturas.SelectedIndexChanged
        bd.Conectar()
        Session("datos") = bd.DataT(asignaturas.SelectedValue)
        bd.CerrarConexion()

        dttabla = Session("datos")




        GridView1.DataSource = dttabla
        GridView1.DataBind()



    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Response.Redirect(“InstanciarTarea.aspx?codigo=" & GridView1.SelectedRow.Cells(1).Text.ToString + "&horasestimadas=" & GridView1.SelectedRow.Cells(4).Text.ToString)
    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("Alumno.aspx")
    End Sub
End Class




