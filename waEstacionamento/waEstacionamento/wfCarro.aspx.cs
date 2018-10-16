using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsCarro;

namespace waEstacionamento
{
    public partial class wfCarro : Page
    {
        enum enmGvCadColuna
        {
            acao = 0,
            id = 1
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int anoFabricacao = int.Parse(txtAnoFabricacao.Text);
                int anoModelo = int.Parse(txtAnoModelo.Text);
                String cor = txtCor.Text;
                String marca = txtMarca.Text;
                String modelo = txtModelo.Text;

                clsBanco.Carro objCarro = new clsBanco.Carro();
                objCarro.anoFabricacao = anoFabricacao;
                objCarro.anoModelo = anoModelo;
                objCarro.cor = cor;
                objCarro.marca = marca;
                objCarro.modelo = modelo;

                Boolean isSalvo = Carro.Salvar(objCarro);

                if (isSalvo && objCarro.id > 0)
                {
                    txtId.Text = objCarro.id.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //string valor = Request.QueryString["idItem"];

            //if (String.IsNullOrEmpty(valor))
            //{
            //    contextViagem.TB_VIAGEM.Add(v);
            //    lblmsg.Text = "Registro Inserido!";
            //    Clear();
            //}
            //else
            //{
            //    int id = Convert.ToInt32(valor);
            //    TB_VIAGEM viagem = contextViagem.TB_VIAGEM.First(c => c.id == id);
            //    viagem.descricao = v.descricao;
            //    viagem.data = v.data;
            //    lblmsg.Text = "Registro Alterado!";
            //}
            //contextViagem.SaveChanges();
        }

        protected void lbkCancelar_Click(object sender, EventArgs e)
        {
        }

        protected void lkbExcluir_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(((GridViewRow)((LinkButton)sender).Parent.Parent).Cells[(Byte)enmGvCadColuna.id].Text);
            //new DBMonitoramento().Delete(id);
            //CarregarGrid();
        }

        protected void lbkImprimir_Click(object sender, EventArgs e)
        {
            //GridViewRow row = ((GridViewRow)((LinkButton)sender).Parent.Parent);


            //Session.Add("impressao", objmon);
            //Response.Redirect("~/impressao.aspx?get=impressao");
        }
    }
}