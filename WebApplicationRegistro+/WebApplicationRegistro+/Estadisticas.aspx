<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estadisticas.aspx.vb" Inherits="WebApplicationRegistro_.Estadisticas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ESTADISTICAS</div>
        <p>
            &nbsp;</p>
        <p>
            Dedicacion MEDIA/MINIMA/MAXIMA por tarea</p>
        <p>
            Dedicacion MEDIA/MINIMA/MAXIMA por asignatura</p>
        <p>
            Dedicacion total de un alumno a una asignatura</p>
        <p>
            &nbsp;</p>
        <p>
            Seleccione el correo del alumno:</p>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="email" DataValueField="email" Height="16px" Width="255px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT DISTINCT [email] FROM [Usuarios]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
