Public Class HomeProfe
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
        Response.Redirect("TareasProfesor.aspx")
    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        System.Web.Security.FormsAuthentication.SignOut()
        Session.Abandon()
        Global.WebApplicationRegistro_.Global_asax.Update_CountP(-1)
        Global.WebApplicationRegistro_.Global_asax.Update_RemoveList(Session("email"), Global.WebApplicationRegistro_.Global_asax.Get_listP)
        Response.Redirect("~/Inicio.aspx")
    End Sub


    Protected Sub own0_Click(sender As Object, e As EventArgs) Handles own0.Click
        Response.Redirect("ImportarDocumentoXML.aspx")
    End Sub

    Protected Sub own1_Click(sender As Object, e As EventArgs) Handles own1.Click
        Response.Redirect("ExportarDocumentoXML.aspx")
    End Sub

    Protected Sub own2_Click(sender As Object, e As EventArgs) Handles own2.Click
        Response.Redirect("coordinador.aspx")
    End Sub
End Class