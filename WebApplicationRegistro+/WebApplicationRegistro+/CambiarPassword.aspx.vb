Public Class CambiarPassword1
    Inherits System.Web.UI.Page
    Public email As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        email = Request.QueryString("email")

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As New dataBase.AccesoBD
        Dim contraseña As String = TextBox2.Text
        bd.Conectar()
        bd.ModPass(email, contraseña)
        bd.CerrarConexion()

        Label4.Visible = True
        Button1.Visible = False
        Button2.Visible = True

    End Sub
End Class