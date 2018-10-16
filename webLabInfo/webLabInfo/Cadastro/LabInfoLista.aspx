<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabInfoLista.aspx.cs" Inherits="webLabInfo.Cadastro.LabInfoLista" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    /**{ border: solid 1px black; }*/
    @media screen and (max-width: 931px)
    {
        #txtNome
        {
            max-width:1008%;
        }
    }
    @media screen and (min-width: 929px)
    {
        #txtNome
        {
            max-width:95%;
        }
    }
  
    
</style>
<h2>Pesquisa</h2>   
    
    <div class="form-row col-md-12">
        <h4>Laboratorio de Informatica</h4>
        <hr />
        <div class="form-row col-md-10">
            <div class="col-md-12">
                <asp:Label runat="server" ID="lblLab" Text="Laboratorio:" class="control-label"></asp:Label>
            </div>
            <div class="form-group col-md-2">
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-10">
                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-row col-md-10">
             <div class="form-group col-md-4">
                <asp:Label runat="server" ID="lblqtdComputadores" Text="Qtd. Comput.:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtqtdComputadores" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                 <asp:Label runat="server" ID="lblqtdAlunos" Text="Qtd. Alunos:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtqtdAlunos" CssClass="form-control" ></asp:TextBox>
            </div>
        </div>
       
        <div class="form-row col-md-10">
             <div class="form-group col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Projetor:" class="control-label"></asp:Label>
                <asp:DropDownList ID="ddlProjetor" runat="server" class="form-control" style="width:280px;">
                    <asp:ListItem Text="Ambas" Value="Ambas"></asp:ListItem>
                    <asp:ListItem Text="Sim" Value="true"></asp:ListItem>
                    <asp:ListItem Text="Não" Value="false"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        
         <div class="form-row col-md-10">
             <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label3" Text="Software 1:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware1" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                 <asp:Label runat="server" ID="Label4" Text="Software 2:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware2" CssClass="form-control" ></asp:TextBox>
            </div>
        </div>
        
         <div class="form-row col-md-10">
             <div class="form-group col-md-4">
                <asp:Label runat="server" ID="Label2" Text="Software 3:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsoftware3" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                 <asp:Label runat="server" ID="Label5" Text="Sistema Operacional:" class = "control-label"></asp:Label>
                <asp:TextBox runat="server" ID="txtsistemaOperacional" CssClass="form-control" ></asp:TextBox>
            </div>
        </div>
         <div class="form-row col-md-10">
            <div class="form-group col-sm-offset-2 col-sm-10">
                <asp:LinkButton ID="btnPesquisar" runat="server" Text="Pesquisar" class="btn btn-primary" OnClick="btnPesquisar_Click" ></asp:LinkButton>
                <asp:LinkButton ID="btnNovo" runat="server" Text="Novo"  class="btn btn-success" OnClick="btnNovo_Click"></asp:LinkButton>  
                <asp:LinkButton ID="btnLimpar" runat="server" Text="Limpar"  class="btn btn-warning" OnClick="btnLimpar_Click"></asp:LinkButton>    
            </div>
        </div>  
         
        <div class="form-row">
            <asp:GridView ID="gvLab" runat="server" EmptyDataText="Sem Itens" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField>
                        <ItemStyle />
                        <ItemTemplate>
                            <asp:ImageButton runat="server" ID="igbEditar"  Width="30px" ImageUrl="~/Imagem/ico/md-editar.svg" OnClick="igbEditar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemStyle />
                        <ItemTemplate>
                            <asp:ImageButton runat="server" ID="igbExcluir" Width="30px" ImageUrl="~/Imagem/ico/ico_excluir.svg" OnClientClick="return ConfirmarExclusao();"  OnClick="igbExcluir_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id" HeaderText="Id" />
                    <asp:BoundField DataField="nome" HeaderText="Lab." />
                    <asp:BoundField DataField="projetor" HeaderText="Tem Projetor" />
                    <asp:BoundField DataField="qtdAlunos" HeaderText="Qtde. Aluno" />
                    <asp:BoundField DataField="qtdComputadores" HeaderText="Qtde Computadores" />
                    <asp:BoundField DataField="sistemaOperacional" HeaderText="S.O." />
                    <asp:BoundField DataField="software1" HeaderText="software 1" />
                    <asp:BoundField DataField="software2" HeaderText="software 2" />
                    <asp:BoundField DataField="software3" HeaderText="software 3" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
           
    </div>
<script type="text/javascript">
function ConfirmarExclusao(controle)
{
    var Confirmar = confirm("Deseja excluir o registro?");
    if (Confirmar) {
        return true;
    }
    else
    {
        return false;
    }            
}
</script>
</asp:Content>
