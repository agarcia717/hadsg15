Public Class coordinador1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim sw As New localhost.Service1
        Label3.Text = sw.MediaAlumnos(DropDownList1.SelectedValue)

        System.Threading.Thread.Sleep(1000)
    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub

    Protected Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Response.Redirect("Profesor.aspx")
    End Sub
End Class