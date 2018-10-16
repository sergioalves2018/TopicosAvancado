using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsBanco;
using clsProva;

namespace wfProva
{
    public partial class _Default : Page
    {
        enum enmGvCadColuna
        {
            acao = 0,
            id = 1
        }

        private clsBanco.Prova objPro;

        private List<clsBanco.Prova> lstProva
        {
            get
            {
                if (Session["prova"] != null)
                    return (List<clsBanco.Prova>)Session["prova"];
                else
                    return null;
            }
            set
            {
                if (value != null)
                    Session.Add("prova", value);
                else
                    Session.Remove("prova");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Carregargrid();
        }
        protected void lkbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtdata.Text)
                    && !String.IsNullOrEmpty(txtnota1.Text)
                     && !String.IsNullOrEmpty(txtnota2.Text)
                      && !String.IsNullOrEmpty(txtmedia.Text))
                {
                    String descricao = txtdescricao.Text;
                    DateTime data = DateTime.Parse(txtdata.Text);
                    Decimal nota1 = Decimal.Parse(txtnota1.Text);
                    Decimal nota2 = Decimal.Parse(txtnota2.Text);
                    Decimal media = Decimal.Parse(txtmedia.Text);

                    clsBanco.Prova objProva;

                    if (!string.IsNullOrEmpty(txtId.Text) && lstProva != null)
                        objProva = (clsBanco.Prova)lstProva.Where(x => x.id == int.Parse(txtId.Text)).First();
                    else
                        objProva = new clsBanco.Prova();

                    objProva.descricao = descricao;
                    objProva.data = data;
                    objProva.nota1 = nota1;
                    objProva.nota2 = nota2;
                    objProva.media = media;

                    Boolean isSalvo = clsProva.Prova.Salvar(objProva);

                    if (isSalvo && objProva.id > 0)
                    {
                        txtId.Text = objProva.id.ToString();
                        Carregargrid();
                        LimparTela();
                    }

                    ucPopUpOk.AbrirModal("Aviso", "Registro Salvo Com Sucesso!");
                }
                else
                {
                    //popup
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void lbkCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        protected void lkbExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((GridViewRow)((LinkButton)sender).Parent.Parent).Cells[(Byte)enmGvCadColuna.id].Text);
            if (clsProva.Prova.Apagar(id))
            {
                Carregargrid();
            }
        }

        protected void lkbEditar_Click(object sender, EventArgs e)
        {
            GridViewRow row = ((GridViewRow)((LinkButton)sender).Parent.Parent);
            int id = int.Parse(row.Cells[(Byte)enmGvCadColuna.id].Text);
            clsBanco.Prova objProva;

            if (lstProva != null)
                objProva = (clsBanco.Prova)lstProva.Where(x => x.id == id).First();
            else
                objProva = clsProva.Prova.SelectById(int.Parse(row.Cells[(Byte)enmGvCadColuna.id].Text));
            
            CarregarTela(objProva);
        }

        protected void txtnota1_TextChanged(object sender, EventArgs e)
        {
            CalcularMedia();
        }

        protected void txtnota2_TextChanged(object sender, EventArgs e)
        {
            CalcularMedia();
        }

        private void CalcularMedia()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtnota1.Text) && !String.IsNullOrEmpty(txtnota2.Text))
                {
                    decimal nota1 = decimal.Parse(txtnota1.Text);
                    decimal nota2 = decimal.Parse(txtnota2.Text);
                    txtmedia.Text = ((nota1 + nota2) / 2).ToString("00.00");
                }
            }
            catch
            {
                throw new Exception("Por favor, preencha corretamente os campo referentes as notas!!");
            }
        }
        private void Carregargrid()
        {
            lstProva = clsProva.Prova.SelectAll();
            gvCad.DataSource = lstProva;
            gvCad.DataBind();
        }

        private void CarregarTela(clsBanco.Prova objProva)
        {
            txtId.Text = objProva.id.ToString();
            txtdescricao.Text = objProva.descricao;
            txtdata.Text = objProva.data.ToString();
            txtnota1.Text = objProva.nota1.ToString();
            txtnota2.Text = objProva.nota2.ToString();
            txtmedia.Text = objProva.media.ToString();
        }

        private void LimparTela()
        {
            txtId.Text = String.Empty;
            txtdescricao.Text = String.Empty;
            txtdata.Text = String.Empty;
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtmedia.Text = String.Empty;
        }
    }
}