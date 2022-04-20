<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCrudShippers.aspx.cs" Inherits="Tallerlinq2.frmCrudShippers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            IdShippers&nbsp;
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre de compania<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefono<asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
