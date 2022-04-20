<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultasProyeccion.aspx.cs" Inherits="Tallerlinq2.frmConsultasProyeccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Consultas de proyeccion<br />
            <br />
            <asp:Button ID="btncategorias" runat="server" OnClick="btncategorias_Click" Text="Categorias" />
            <asp:Button ID="btnregion" runat="server" OnClick="btnregion_Click" Text="Region" />
            <asp:Button ID="btnProductos" runat="server" OnClick="btnProductos_Click" Text="Productos" />
            <br />
            <br />
            <asp:TextBox ID="txtConsulta" runat="server"></asp:TextBox>
            <asp:Button ID="btncategoriapro" runat="server" OnClick="btncategoriapro_Click" Text="Categoria con proyeccion" />
            <asp:Button ID="btnRegionpro" runat="server" OnClick="btnRegionpro_Click" Text="region con proyeccion" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Productos con proyeccion" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
