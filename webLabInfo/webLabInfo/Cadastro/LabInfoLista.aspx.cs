using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webLabInfo.ServicoCrud;
using Entidade;
using Persistencia;

namespace webLabInfo.Cadastro
{
    public partial class LabInfoLista : System.Web.UI.Page
    {
        private int? id;
        private string nome;
        private bool? isprojetor;
        private int? qtdAlunos;
        private int? qtdComputadores;
        private string sistemaOperacional;
        private string software1;
        private string software2;
        private string software3;

        List<LabInfo> lstLabInfo
        {
            get
            {
                if (Session["codObj"] == null)
                    return null;

                return ((List<LabInfo>)Session["codObj"]);
            }
            set
            {
                if (value == null)
                    Session.Remove("codObj");
                else
                    Session["codObj"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/cadastro/LabInfoCad.aspx");
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LinmparForm();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            RecuperarForm();
            ServicoClient servicoClient = new ServicoClient();
            lstLabInfo = servicoClient.PesquisaLabInfo(id
                                                       , nome
                                                       , isprojetor
                                                       , qtdAlunos
                                                       , qtdComputadores
                                                       , sistemaOperacional
                                                       , software1
                                                       , software2
                                                       , software3).ToList();

            gvLab.DataSource = lstLabInfo;
            gvLab.DataBind();
        }

        private void RecuperarForm()
        {
            if (!String.IsNullOrEmpty(txtId.Text))
                id = Convert.ToInt32(txtId.Text);

            if (!String.IsNullOrEmpty(txtNome.Text))
                nome = txtNome.Text;

            if (!String.IsNullOrEmpty(txtqtdAlunos.Text))
                qtdAlunos = int.Parse(txtqtdAlunos.Text);

            if (!String.IsNullOrEmpty(txtqtdComputadores.Text))
                qtdAlunos = int.Parse(txtqtdComputadores.Text);

            if (!String.IsNullOrEmpty(txtsistemaOperacional.Text))
                sistemaOperacional = txtsistemaOperacional.Text;

            if (!String.IsNullOrEmpty(txtsoftware1.Text))
                software1 = txtsoftware1.Text;

            if (!String.IsNullOrEmpty(txtsoftware2.Text))
                software2 = txtsoftware2.Text;

            if (!String.IsNullOrEmpty(txtsoftware3.Text))
                software3 = txtsoftware3.Text;

            if (ddlProjetor.SelectedValue != "Ambas")
                isprojetor = bool.Parse(ddlProjetor.SelectedValue);
            else
                isprojetor = null;
        }

        private void LinmparForm()
        {
            txtId.Text =
            txtNome.Text =
            txtqtdAlunos.Text =
            txtqtdComputadores.Text =
            txtsistemaOperacional.Text =
            txtsoftware1.Text =
            txtsoftware2.Text =
            txtsoftware3.Text = String.Empty;

            ddlProjetor.SelectedValue = "Ambas";

            gvLab.DataSource = null;
            gvLab.DataBind();
        }

        protected void igbEditar_Click(object sender, ImageClickEventArgs e)
        {
            string id = ((GridViewRow)((ImageButton)sender).Parent.Parent).Cells[2].Text;
            LabInfo lab = (LabInfo)lstLabInfo.Where(x => x.id == int.Parse(id)).First();
            Session["objLabCadastro"] = lab;
            lstLabInfo = null;
            Response.Redirect("~/Cadastro/LabInfoCad.aspx?id=objLabCadastro");
        }

        protected void igbExcluir_Click(object sender, ImageClickEventArgs e)
        {
            string id = ((GridViewRow)((ImageButton)sender).Parent.Parent).Cells[2].Text;
            LabInfo lab = (LabInfo)lstLabInfo.Where(x => x.id == int.Parse(id)).First();
            LabInfoPersis.ExcluirEntidade(lab);
            lstLabInfo.Remove(lab);

            gvLab.DataSource = lstLabInfo;
            gvLab.DataBind();
        }
    }
}