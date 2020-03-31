Imports System.Data.SqlClient

Public Class WebFormRegistro
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim bd As New dataBase.AccesoBD
        Dim email As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        Dim has As New Crypto.Security
        pass = has.Crypt(pass)
        Dim result As SqlDataReader

        Dim mail As String
        Dim password As String
        Dim estado As String
        Dim tipo As String
        bd.Conectar()
        result = bd.Login(email)


        While result.Read

            mail = result.Item("email")
            password = result.Item("pass")
            estado = result.Item("confirmado").ToString()
            tipo = result.Item("tipo")
        End While
        bd.CerrarConexion()

        If estado = "False" Then
            Label4.Visible = True
            Label4.Text = "El registro todavia no se ha completado, en su correo " + email + " encontrará el enlace de confirmación"
        ElseIf email <> mail Or pass <> password Then
            Label4.Visible = True
            Label4.Text = "Email o Contraseña incorrecto"
        ElseIf tipo = "Alumno" Then
            Session("email") = mail
            Label4.Visible = False
            System.Web.Security.FormsAuthentication.SetAuthCookie("alumno", False)
            Response.Redirect("~/Alumnos/Alumno.aspx")

        ElseIf tipo = "Profesor" Then
            Session("email") = mail
            Label4.Visible = False
            If Session("email") = "vadillo@ehu.es" Then
                System.Web.Security.FormsAuthentication.SetAuthCookie(Session("email"), False)
            Else
                System.Web.Security.FormsAuthentication.SetAuthCookie("profesor", False)
            End If
            Response.Redirect("~/Profesores/Profesor.aspx")

            End If

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("~/Registro.aspx")
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Response.Redirect("~/SolicitudCambiarPassword.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


End Class