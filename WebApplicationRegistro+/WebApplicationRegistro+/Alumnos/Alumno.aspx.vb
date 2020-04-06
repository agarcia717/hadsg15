Public Class Sesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBoxAlumnos.DataSource = Global.WebApplicationRegistro_.Global_asax.Get_listA()
        ListBoxAlumnos.DataBind()
        ListBoxProfesor.DataSource = Global.WebApplicationRegistro_.Global_asax.Get_listP()
        ListBoxProfesor.DataBind()
        Label4.Text = "Usuarios Logeados: " + Global.WebApplicationRegistro_.Global_asax.Get_CountA().ToString + " Alumnos Y " + Global.WebApplicationRegistro_.Global_asax.Get_CountP().ToString + " Profesores"
        Label2.Text = "¡Bienvenido, " + Session.Contents("email")
    End Sub

    Protected Sub generic_Click(sender As Object, e As EventArgs) Handles generic.Click
        Response.Redirect("TareasAlumno.aspx")
    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        System.Web.Security.FormsAuthentication.SignOut()
        Session.Abandon()
        Global.WebApplicationRegistro_.Global_asax.Update_CountA(-1)
        Global.WebApplicationRegistro_.Global_asax.Update_RemoveList(Session("email"), Global.WebApplicationRegistro_.Global_asax.Get_listA)
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub group_Click(sender As Object, e As EventArgs) Handles group.Click

    End Sub
End Class