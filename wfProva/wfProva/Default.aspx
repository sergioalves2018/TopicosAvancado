<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wfProva._Default" %>

<%@ Register src="~/Controles/ucPopUpOk.ascx" tagname="PopUpOk" tagprefix="uc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        /**{border: 1px solid black;}*/
    </style>
    <div class="container-fluid">
        <div class="row-fluid">
            <form class="form-group">
                <fieldset>
                    <legend>Cadastro</legend>
                    <div class="form-row">
                        <div class="form-group col-md-4">
                            <asp:Label runat="server" ID="Label6">Código: </asp:Label>
                            <asp:TextBox ID="txtId" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-4">
                            <asp:Label ID="lbl1" runat="server">Descrição:</asp:Label>
                            <asp:TextBox ID="txtdescricao" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label1" runat="server">Data:</asp:Label>
                            <asp:TextBox ID="txtdata" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label5" runat="server">Nota 1:</asp:Label>
                            <asp:TextBox ID="txtnota1" runat="server" class="form-control" OnTextChanged="txtnota1_TextChanged"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label3" runat="server">Nota 2:</asp:Label>
                            <asp:TextBox ID="txtnota2" runat="server" class="form-control" AutoPostBack="true" OnTextChanged="txtnota2_TextChanged" ></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                            <asp:Label ID="Label2" runat="server">Media:</asp:Label>
                            <asp:TextBox ID="txtmedia" runat="server" class="form-control" ReadOnly="true" ></asp:TextBox>
                        </div>
                    </div>
                </fieldset>
             </form>
            <div class="controls">
                <center>
                    <%--<asp:LinkButton ID="lbkNovo" runat="server" class="btn btn-success">Novo</asp:LinkButton>--%>
                    <asp:LinkButton ID="lkbSalvar" runat="server" class="btn btn-success" OnClick="lkbSalvar_Click">Salvar</asp:LinkButton>
                    <asp:LinkButton ID="lbkCancelar" runat="server" class="btn btn-warning" OnClick="lbkCancelar_Click">Cancelar</asp:LinkButton>
                    <%--<asp:LinkButton ID="lbkExcluir" runat="server" class="btn btn-danger" OnClick="lkbExcluir_Click">Excluir</asp:LinkButton>--%>
                </center>
            </div>
            <fieldset>
        <legend>Lista</legend>
        <div class="row">
            <center>
                <asp:GridView ID="gvCad" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemStyle Width="225px" />
                            <ItemTemplate>
                                <asp:LinkButton ID="lkbEditar" runat="server" class="btn btn-warning" OnClick="lkbEditar_Click">Editar</asp:LinkButton>
                                <asp:LinkButton ID="lkbExcluir" runat="server" class="btn btn-danger" OnClick="lkbExcluir_Click">Excluir</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="id" HeaderText="Id" />
                        <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                        <asp:BoundField DataField="data" HeaderText="data" />
                        <asp:BoundField DataField="nota1" HeaderText="nota1" />
                        <asp:BoundField DataField="nota2" HeaderText="nota2" />
                        <asp:BoundField DataField="media" HeaderText="media" />
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
            </center>
        </div>
    </fieldset>
        </div>
    </div>
    <uc:PopUpOk  runat="server" ID="ucPopUpOk" ></uc:PopUpOk>
</asp:Content>

