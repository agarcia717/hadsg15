Public Class ConfirmarCorreo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim bd As New dataBase.AccesoBD
        Dim email = Request.QueryString("email")
        bd.Conectar()
        Label1.Text = "Aló preeesidente " + bd.ConfirmarReg(email)
        bd.CerrarConexion()
        hola.Text = "¡Hola " + email + ",gracias por registrarte en nuestra aplicación!"

    End Sub

End Class