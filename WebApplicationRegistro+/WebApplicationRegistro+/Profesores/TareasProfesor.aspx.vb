Public Class TareasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim correo As String = Session("email")

    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("Profesor.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect(“InsertarTarea.aspx")
    End Sub

    Protected Sub asignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles asignaturas.SelectedIndexChanged
        System.Threading.Thread.Sleep(1000)
    End Sub
End Class