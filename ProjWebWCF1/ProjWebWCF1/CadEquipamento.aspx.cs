using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjWebWCF1.MeuServicoWCF;

namespace ProjWebWCF1
{
    public partial class CadEquipamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MeuServicoWCF.EquipamentoVO equipamentoVO = new MeuServicoWCF.EquipamentoVO();
            equipamentoVO.nome = txtNome.Text;
            equipamentoVO.valor = Decimal.Parse(txtValor.Text);
            equipamentoVO.dataCadastro = DateTime.Parse(txtDataCadastro.Text);

            MeuServicoWCF.ServicoClient sc = new MeuServicoWCF.ServicoClient();
            sc.Open();
            sc.Inserir(equipamentoVO);
        }
    }
}