Public Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bd As dataBase.AccesoBD
        Dim msg As String
        bd.Conectar()
        msg = bd.AddTareaGenerica(TextBox1.Text, TextBox3.Text, DropDownList1.SelectedValue, CInt(TextBox2.Text), True, DropDownList2.SelectedValue)
        bd.CerrarConexion()
        MsgBox(msg)
    End Sub
    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("TareasProfesor.aspx")
    End Sub
End Class