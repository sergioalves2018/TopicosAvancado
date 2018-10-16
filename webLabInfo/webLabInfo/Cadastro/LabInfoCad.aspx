<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabInfoCad.aspx.cs" Inherits="webLabInfo.Cadastro.LabInfoCad" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        /**{ border: solid 1px black; }*/
    </style>
    <h2>Cadastro</h2>

     <div class="form-row col-md-12">
        <h4>Laboratorio de Informatica</h4>
        <hr />
        <div class="form-row col-md-10">
            <div class="col-md-12">
                <asp:Label runat="server" ID="lblLab" Text="Pessoa:" class="control-label"></asp:Label>
            </div>
            <div class="form-group col-md-2">
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div class="form-group col-md-10">
                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-row col-md-10">
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="lblqtdComputadores" Text="Qtd. Comput.:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtqtdComputadores" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="lblqtdAlunos" Text="Qtd. Alunos:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtqtdAlunos" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-row col-md-10">
            <div class="form-group col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Projetor:" class="control-label"></asp:Label>
                <asp:DropDownList ID="ddlProjetor" runat="server" class="form-control" Style="width: 280px;" AutoPostBack="true" OnSelectedIndexChanged="ddlProjetor_SelectedIndexChanged">
                    <asp:ListItem Text="Sim" Value="true"></asp:ListItem>
                    <asp:ListItem Text="Não" Value="false" Selected="True"></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="lblmsg" runat="server" class="control-label" ForeColor="Red"></asp:Label>
            </div>
        </div>

        <div class="form-row col-md-10">
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label3" Text="Software 1:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware1" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label4" Text="Software 2:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware2" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-row col-md-10">
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label2" Text="Software 3:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware3" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label5" Text="Sistema Operacional:" class="control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsistemaOperacional" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-row col-md-12">
            <div class="form-group col-sm-10">
                <asp:LinkButton ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-success"></asp:LinkButton>
                <asp:LinkButton ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" class="btn btn-warning"></asp:LinkButton>
            </div>
        </div>
    </div>

</asp:Content>
