Imports System.Net.Mail

Public Class Registro
    Inherits System.Web.UI.Page
    Dim bd As New dataBase.AccesoBD

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim email As String
        Dim nombre As String
        Dim apellidos As String
        Dim password As String
        Dim repassword As String
        Dim rol As String

        email = TextBox1.Text
        nombre = TextBox2.Text
        apellidos = TextBox3.Text
        password = TextBox4.Text
        repassword = TextBox5.Text

        If RadioButton1.Checked Then
            rol = "Alumno"
        ElseIf RadioButton2.Checked Then
            rol = "Profesor"
        Else
            Label8.Visible = True

            Return

        End If

        Label8.Visible = False
        Button1.Visible = False

        Dim randomNumber As Integer
        Randomize()
        randomNumber = CLng(9000000 * Rnd()) + 1000000
        Dim send As New RegistroEmail.Class1
        Dim link = "http://localhost:2942/ConfirmarCorreo.aspx?email=" & email
        If send.EnviarEmail(email, link) Then
            Dim sec As New Crypto.Security
            bd.Conectar()
            password = sec.Crypt(password)
            bd.Insertar(email, nombre, apellidos, randomNumber, 0, rol, password, 0)
            bd.CerrarConexion()

            feedback.Text = "Para completar el registro, accede al correo " + email + " o haz click en el siguiente enlace "
            verify.Visible = True
            verify.NavigateUrl = link '& "?nconf=" & randomNumber

        Else
            feedback.Text = "Lo sentimos no ha sido posible enviar el correo de confirmación"


        End If
    End Sub





End Class