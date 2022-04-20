<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmconsultasLambda.aspx.cs" Inherits="Tallerlinq2.frmconsultasLambda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Expresiones Lambda<br />
            <br />
            Productos cuyo stock es mayor a
            <asp:TextBox ID="txtconsultar" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
            <br />
            <br />
            Ordenes de primer semestre del 1997
            <asp:Button ID="Consultar" runat="server" OnClick="Consultar_Click" Text="Button" />
            <br />
            <br />
            <br />
            Traer nombres de categorias<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT DISTINCT [CategoryName] FROM [Categories]"></asp:SqlDataSource>
            <br />
            ----------------------------------------------------------------<br />
            Clases parciales<br />
            <br />
            Consultar total de cantidad * precio unitario
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
            <br />
            <br />
            Consultar los datos completos de empleados <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Consultar" />
            <br />
            <br />
            Consultar los productos y stock&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Consultar" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
