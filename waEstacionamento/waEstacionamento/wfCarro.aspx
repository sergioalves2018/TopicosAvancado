<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfCarro.aspx.cs" Inherits="waEstacionamento.wfCarro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        /**{border: 1px solid black;}*/
    </style>
    <div class="container-fluid">
        <div class="row-fluid">
            <form class="form-horizontal">
                <fieldset>
                    <legend>Cadastro</legend>
                    <div class="form-group">
                        <div>
                            <asp:Label runat="server" ID="Label6">Código: </asp:Label>
                            <asp:TextBox ID="txtId" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-4">
                            <asp:Label ID="lbl1" runat="server">Ano de Fabricação:</asp:Label>
                            <asp:TextBox ID="txtAnoFabricacao" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label1" runat="server">Ano Modelo:</asp:Label>
                            <asp:TextBox ID="txtAnoModelo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label2" runat="server">Cor:</asp:Label>
                            <asp:TextBox ID="txtCor" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label5" runat="server">Modelo:</asp:Label>
                            <asp:TextBox ID="txtModelo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label3" runat="server">Marca:</asp:Label>
                            <asp:TextBox ID="txtMarca" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </fieldset>
             </form>
            <div class="controls">
                <center>
                    <asp:LinkButton ID="lbkNovo" runat="server" class="btn btn-success">Novo</asp:LinkButton>
                    <asp:LinkButton ID="lkbSalvar" runat="server" class="btn btn-success" OnClick="lkbSalvar_Click">Salvar</asp:LinkButton>
                    <asp:LinkButton ID="lbkImprimir" runat="server" class="btn btn-primary" OnClick="lbkImprimir_Click">Imprimir</asp:LinkButton>
                    <asp:LinkButton ID="lbkCancelar" runat="server" class="btn btn-warning" OnClick="lbkCancelar_Click">Voltar</asp:LinkButton>
                    <asp:LinkButton ID="lbkExcluir" runat="server" class="btn btn-danger" OnClick="lkbExcluir_Click">Excluir</asp:LinkButton>
                </center>
            </div>
        </div>
    </div>
</asp:Content>
