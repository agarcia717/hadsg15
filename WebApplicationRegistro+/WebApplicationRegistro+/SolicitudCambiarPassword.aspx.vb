Public Class CambiarPassword
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim key As Integer
        Dim randomNumber As Integer
        Randomize()
        randomNumber = Int((100000 * Rnd()) + 1)
        key = randomNumber

        Dim email As String = TextBox1.Text
        Dim send As New RegistroEmail.Class1

        If send.EnviarEmailclave(email, randomNumber) Then

            Dim bd As New dataBase.AccesoBD
            bd.Conectar()
            bd.SetCodPass(email, randomNumber)
            bd.CerrarConexion()

            confirmacion.Text = "Revise su correo eletronico"
        Else
            confirmacion.Text = "Fallo al enviar la clave, por favor intentelo mas tarde"
        End If








    End Sub

    Protected Sub Button2_Click1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim email As String = TextBox1.Text
        Dim key As String
        Dim clave As String = TextBox2.Text

        Dim bd As dataBase.AccesoBD
        bd.Conectar()
        key = bd.GetCodPass(email)
        bd.CerrarConexion()


        If key = clave Then
            Label6.Visible = False
            'Button2.PostBackUrl = "~/CambiarPassword.aspx?email=" & email
            Response.Redirect("~/CambiarPassword.aspx?email=" & email)

        Else
            Label6.Text = "Clave Incorrecta"
            Return
        End If




    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub


End Class