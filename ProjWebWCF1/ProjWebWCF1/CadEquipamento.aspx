<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadEquipamento.aspx.cs" Inherits="ProjWebWCF1.CadEquipamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
    </div>
    <form id="form1" runat="server">
        <asp:Label ID="Label4" runat="server" Text="Id:"></asp:Label>
        <br />
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <br />
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Valor:"></asp:Label>
        <br />
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Dt. Cadastro"></asp:Label>
        <br />
        <asp:TextBox ID="txtDataCadastro" runat="server"></asp:TextBox>
        <div>
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
