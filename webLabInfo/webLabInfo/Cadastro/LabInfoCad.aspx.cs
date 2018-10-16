using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webLabInfo.ServicoCrud;
using Entidade;
using Persistencia;
using System.Text;

namespace webLabInfo.Cadastro
{
    public partial class LabInfoCad : System.Web.UI.Page
    {
        LabInfo objLab
        {
            get
            {
                if (Session["codObj"] == null)
                    return null;

                return (LabInfo)Session["codObj"];
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
            string cobObjLab = Request.QueryString["id"];
            if (cobObjLab != null)
            {
                objLab = (LabInfo)Session[cobObjLab];

                if (!this.IsPostBack)
                    CarregarForm();
            }
            else
            {
                objLab = new LabInfo();
            }

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (String.IsNullOrEmpty(txtqtdComputadores.Text) || int.Parse(txtqtdComputadores.Text) < 2)
                {
                    sb.AppendLine("Informe uma quantidade de computadores maior que 1!");
                }
                else if (String.IsNullOrEmpty(txtqtdAlunos.Text) || int.Parse(txtqtdAlunos.Text) < 5)
                {
                    sb.AppendLine("Informe uma quantidade de alunos maior que 4!");
                }
                else if (String.IsNullOrEmpty(txtNome.Text) || txtNome.Text.Length < 4)
                {
                    sb.AppendLine("O Nome do laboratorio deve conter mais de 3 caracteres!");
                }

                if (sb != null)
                {
                    Msg(sb.ToString());
                }
                else
                {
                    ServicoClient servicoClient = new ServicoClient();
                    var labinfo = servicoClient.LabInfoStart();

                    if (!string.IsNullOrEmpty(txtId.Text))
                        labinfo.id = int.Parse(txtId.Text);

                    if (!string.IsNullOrEmpty(txtqtdComputadores.Text))
                        labinfo.qtdComputadores = int.Parse(txtqtdComputadores.Text);

                    if (!string.IsNullOrEmpty(txtqtdAlunos.Text))
                        labinfo.qtdAlunos = int.Parse(txtqtdAlunos.Text);

                    labinfo.projetor = bool.Parse(ddlProjetor.SelectedValue);
                    labinfo.nome = txtNome.Text;
                    labinfo.software1 = txtsoftware1.Text;
                    labinfo.software2 = txtsoftware2.Text;
                    labinfo.software3 = txtsoftware3.Text;
                    labinfo.sistemaOperacional = txtsistemaOperacional.Text;


                    int idregistro = servicoClient.Inserir(labinfo);
                    if (idregistro > 0)
                    {
                        Msg(string.Format("Registro {0} salvo!", idregistro.ToString()));
                        txtId.Text = idregistro.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar registro!\n" + ex.Message);
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro/LabInfoLista.aspx");
        }

        private void CarregarForm()
        {
            txtId.Text = objLab.id.ToString(); ;
            txtNome.Text = objLab.nome;
            txtqtdAlunos.Text = objLab.qtdAlunos.ToString();
            txtqtdComputadores.Text = objLab.qtdComputadores.ToString();
            txtsistemaOperacional.Text = objLab.sistemaOperacional;
            txtsoftware1.Text = objLab.software1;
            txtsoftware2.Text = objLab.software2;
            txtsoftware3.Text = objLab.software3;
        }

        private void Msg(string msg)
        {
            string script = String.Format("alert('{0}')", msg);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
        }

        protected void ddlProjetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProjetor.SelectedValue == "true")
                lblmsg.Text = "Para utilização do projetor é necessário abrir uma solicitação para o help desk";
            else
                lblmsg.Text = null;
        }
    }
}