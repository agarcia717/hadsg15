<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConfirmarCorreo.aspx.vb" Inherits="WebApplicationRegistro_.ConfirmarCorreo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="hola" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="i"></asp:Label>

        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Inicio.aspx" Text="Iniciar Sesion" />

    </form>
</body>
</html>
