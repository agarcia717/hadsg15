Public Class ConfirmarCorreo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim bd As New dataBase.AccesoBD
        Dim email = Request.QueryString("email")
        bd.Conectar()
        hola.Text = "Aló preeesidente " + bd.ConfirmarReg(email)
        bd.CerrarConexion()
        hola.Text = "¡Hola " + email + ",gracias por registrarte en nuestra aplicación!"

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("~/Inicio.aspx")
    End Sub
End Class