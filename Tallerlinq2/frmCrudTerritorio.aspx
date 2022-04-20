<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCrudTerritorio.aspx.cs" Inherits="Tallerlinq2.frmCrudTerritorio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Operaciones Crud territorio<br />
            <br />
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
&nbsp;Id de territorio<br />
            <br />
            <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
            Descripcion de territorio<br />
            <br />
            <asp:TextBox ID="txtidregion" runat="server"></asp:TextBox>
&nbsp;Id de region<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
