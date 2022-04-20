<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultasJoin.aspx.cs" Inherits="Tallerlinq2.frmConsultasJoin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Tabla empleados territorios, territorios (Territorio de empleados x territorio)<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
            <br />
            <br />
            Tabla Shippers y Orders (consulttar id shippers, nombre de la compania, Companias con ordenes) <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
            <br />
            <br />
            Tabla categoria y Producto(Consultar Idcategoria, nombre de la categoria y productos x Categoria)
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Consultar" />
            <br />
            <br />
            Tabla empleados y Ordenes (Consultar Apellido, Ciudad, Pais y Ordenes x empleado)
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Consultar" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
