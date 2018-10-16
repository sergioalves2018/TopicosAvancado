<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfCarroPesquisa.aspx.cs" Inherits="waEstacionamento.wfCarroPesquisa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<style type="text/css">
.centralizado 
{
	margin: 0 auto;
}

.bloco
{
    display: block;
}
.larguraCampo
{
    width: 23.5%;
}

.larguraLista{
    width: 70%;
}

.checkBox label
{
    text-align: left;
    padding-left: 10px;
}
/**** Modal Popup ****************/
.modalBackground
{
    background-color: #999;
    filter: alpha(opacity-]=70);
    opacity:0.7;
}
.modalPopUp
{
    background-color: #fff;
    border-width: 3px;
    border-style: solid;
    border-color: gray;
    padding: 3px;
    width: 250px;
}


/**{border: 1px solid black;}*/
</style>
    <fieldset>
        <legend>Cadastro</legend>
        <div id="divId" class="row" runat="server">
            <div class="bloco centralizado larguraCampo">
                <asp:Label runat="server" ID="Label6">Código: </asp:Label> 
                <asp:TextBox ID="txtId" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="bloco centralizado larguraCampo">
                <asp:Label ID="lbl1" runat="server">Ano de Fabricação:</asp:Label>
                <asp:TextBox ID="txtAnoFabricacao" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="bloco centralizado larguraCampo">
                <asp:Label ID="Label1" runat="server">Ano Modelo:</asp:Label>
                <asp:TextBox ID="txtAnoModelo" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="bloco centralizado larguraCampo">
                <asp:Label ID="Label2" runat="server">Cor:</asp:Label>
                <asp:TextBox ID="txtCor" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="bloco centralizado larguraCampo">
                <asp:Label ID="Label3" runat="server">Marca:</asp:Label>
                <asp:TextBox ID="txtMarca" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="bloco centralizado larguraCampo">
            <asp:Label ID="Label5" runat="server">Modelo:</asp:Label>
            <asp:TextBox ID="txtModelo" runat="server" class="form-control"></asp:TextBox>
        </div>
    </fieldset>
    <br />
    <div class="row">
            <div class="bloco centralizado larguraCampo">
            <center>
                <asp:LinkButton ID="lbkPesquisar" runat="server" class="btn btn-success">Pesquisar</asp:LinkButton>                    
                <asp:LinkButton ID="lbkLimpar" runat="server" class="btn btn-default" OnClick="lbkLimpar_Click" BackColor="Gray">Limpar</asp:LinkButton>
            </center>
        </div>
    </div>
    <fieldset>
        <legend>Lista</legend>
        <div class="row">
            <div class="bloco centralizado larguraLista">
                <asp:GridView ID="gvCad" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemStyle Width="225px" />
                            <ItemTemplate>
                                <asp:LinkButton ID="lkbEditar" runat="server" class="btn btn-warning" OnClick="lkbEditar_Click">Editar</asp:LinkButton>
                                <asp:LinkButton ID="lkbImprimir" runat="server" class="btn btn-info" OnClick="lkbImprimir_Click">Imprimir</asp:LinkButton>
                                <asp:LinkButton ID="lkbExcluir" runat="server" class="btn btn-danger" OnClick="lkbExcluir_Click">Excluir</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="id" HeaderText="Id" />
                        <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                        <asp:BoundField DataField="qtdCamera" HeaderText="Qtde. Cameras" />
                        <asp:BoundField DataField="nomeCleinte" HeaderText="Cleinte" />
                        <asp:BoundField DataField="valorBasePacote" HeaderText="Vr. Base Pacote" />
                        <asp:BoundField DataField="fidelidade" HeaderText="Fidelidade" />
                        <asp:BoundField DataField="idPacote" HeaderText="Id Pacote" />
                        <asp:BoundField DataField="valorPacote" HeaderText="Vr. Pacote"/>
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </div>
        </div>
    </fieldset>
    	
</asp:Content>
