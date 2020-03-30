<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasProfesor.aspx.vb" Inherits="WebApplicationRegistro_.TareasProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="logout" runat="server" Font-Names="Verdana" Font-Size="10pt">&lt;- Ir atrás</asp:LinkButton>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Text="PROFESOR"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Verdana" Text="GESTIÓN DE TAREAS GENÉRICAS"></asp:Label>
        </div>
            <asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="10pt" Text="Seleccionar asignatura"></asp:Label>
            <br />
        <br />
            <asp:DropDownList ID="asignaturas" runat="server" Font-Names="Verdana" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
                <asp:ListItem Selected="True" Value="-- Asignatura --"></asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT DISTINCT GruposClase.codigoasig 
FROM GruposClase 
INNER JOIN ProfesoresGrupo
ON codigo = codigogrupo
WHERE email = @correo">
                <SelectParameters>
                    <asp:SessionParameter Name="correo" SessionField="email" />
                </SelectParameters>
        </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 520px">
            <asp:Button ID="Button1" runat="server" Text="Insertar Tarea" />
        </div>
        <br />
        <br />
        <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Codigo" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                    <asp:BoundField DataField="CodAsig" HeaderText="CodAsig" SortExpression="CodAsig" />
                    <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                    <asp:CheckBoxField DataField="Explotacion" HeaderText="Explotacion" SortExpression="Explotacion" />
                    <asp:BoundField DataField="TipoTarea" HeaderText="TipoTarea" SortExpression="TipoTarea" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT * FROM [TareasGenericas] WHERE ([CodAsig] = @CodAsig)" UpdateCommand="UPDATE [TareasGenericas] SET [Descripcion] = @Descripcion, [CodAsig] = @CodAsig, [HEstimadas] = @HEstimadas, [Explotacion] = @Explotacion, [TipoTarea] = @TipoTarea WHERE [Codigo] = @original_Codigo AND (([Descripcion] = @original_Descripcion) OR ([Descripcion] IS NULL AND @original_Descripcion IS NULL)) AND (([CodAsig] = @original_CodAsig) OR ([CodAsig] IS NULL AND @original_CodAsig IS NULL)) AND (([HEstimadas] = @original_HEstimadas) OR ([HEstimadas] IS NULL AND @original_HEstimadas IS NULL)) AND (([Explotacion] = @original_Explotacion) OR ([Explotacion] IS NULL AND @original_Explotacion IS NULL)) AND (([TipoTarea] = @original_TipoTarea) OR ([TipoTarea] IS NULL AND @original_TipoTarea IS NULL))" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [TareasGenericas] WHERE [Codigo] = @original_Codigo AND (([Descripcion] = @original_Descripcion) OR ([Descripcion] IS NULL AND @original_Descripcion IS NULL)) AND (([CodAsig] = @original_CodAsig) OR ([CodAsig] IS NULL AND @original_CodAsig IS NULL)) AND (([HEstimadas] = @original_HEstimadas) OR ([HEstimadas] IS NULL AND @original_HEstimadas IS NULL)) AND (([Explotacion] = @original_Explotacion) OR ([Explotacion] IS NULL AND @original_Explotacion IS NULL)) AND (([TipoTarea] = @original_TipoTarea) OR ([TipoTarea] IS NULL AND @original_TipoTarea IS NULL))" InsertCommand="INSERT INTO [TareasGenericas] ([Codigo], [Descripcion], [CodAsig], [HEstimadas], [Explotacion], [TipoTarea]) VALUES (@Codigo, @Descripcion, @CodAsig, @HEstimadas, @Explotacion, @TipoTarea)" OldValuesParameterFormatString="original_{0}">
                <DeleteParameters>
                    <asp:Parameter Name="original_Codigo" Type="String" />
                    <asp:Parameter Name="original_Descripcion" Type="String" />
                    <asp:Parameter Name="original_CodAsig" Type="String" />
                    <asp:Parameter Name="original_HEstimadas" Type="Int32" />
                    <asp:Parameter Name="original_Explotacion" Type="Boolean" />
                    <asp:Parameter Name="original_TipoTarea" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Codigo" Type="String" />
                    <asp:Parameter Name="Descripcion" Type="String" />
                    <asp:Parameter Name="CodAsig" Type="String" />
                    <asp:Parameter Name="HEstimadas" Type="Int32" />
                    <asp:Parameter Name="Explotacion" Type="Boolean" />
                    <asp:Parameter Name="TipoTarea" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="asignaturas" Name="CodAsig" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Descripcion" Type="String" />
                    <asp:Parameter Name="CodAsig" Type="String" />
                    <asp:Parameter Name="HEstimadas" Type="Int32" />
                    <asp:Parameter Name="Explotacion" Type="Boolean" />
                    <asp:Parameter Name="TipoTarea" Type="String" />
                    <asp:Parameter Name="original_Codigo" Type="String" />
                    <asp:Parameter Name="original_Descripcion" Type="String" />
                    <asp:Parameter Name="original_CodAsig" Type="String" />
                    <asp:Parameter Name="original_HEstimadas" Type="Int32" />
                    <asp:Parameter Name="original_Explotacion" Type="Boolean" />
                    <asp:Parameter Name="original_TipoTarea" Type="String" />
                </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
