Imports System.Data.SqlClient

Public Class WebFormRegistro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As New dataBase.AccesoBD
        Dim email As String = TextBox1.Text + " "
        Dim pass As String = TextBox2.Text + " "

        Dim result As SqlDataReader

        Dim mail As String
        Dim password As String
        Dim estado As String

        bd.Conectar()
        result = bd.Login(email)
        While result.Read

            mail = result.Item("email")
            password = result.Item("pass")
            estado = result.Item("confirmado").ToString()
        End While
        bd.CerrarConexion()

        If estado = "False" Then
            Label4.Visible = True
            Label4.Text = "El registro todavia no se ha completado, en su correo " + email + " encontrará el enlace de confirmación"
        ElseIf email <> mail Or pass <> password Then
            Label4.Visible = True
            Label4.Text = "Email o Contraseña incorrecto"
        Else
            Label4.Visible = False
            Response.Redirect("~/Home.aspx")

        End If

    End Sub
End Class