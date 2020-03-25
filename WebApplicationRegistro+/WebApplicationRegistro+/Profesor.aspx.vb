Public Class HomeProfe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label2.Text = "¡Bienvenido, " + Session.Contents("email")
    End Sub

    Protected Sub generic_Click(sender As Object, e As EventArgs) Handles generic.Click
        Response.Redirect("~/TareasProfesor.aspx")
    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Session.Abandon()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub group0_Click(sender As Object, e As EventArgs) Handles group0.Click
        Response.Redirect("~/Estadisticas.aspx")
    End Sub

    Protected Sub own0_Click(sender As Object, e As EventArgs) Handles own0.Click
        Response.Redirect("~/ImportarDocumentoXML.aspx")
    End Sub

    Protected Sub own1_Click(sender As Object, e As EventArgs) Handles own1.Click
        Response.Redirect("~/ExportarDocumentoXML.aspx")
    End Sub
End Class