using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wfProva.Controles
{
    public partial class ucPopUpOk : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void AbrirModal(String titulo, String msg)
        {
            lblTitulo.Text = titulo;
            lblMSG.Text = msg;


            ClientScriptManager csManager = Page.ClientScript;
            csManager.RegisterStartupScript(typeof(Page)
                                            , Guid.NewGuid().ToString()
                                            , "AbrirPopUpOk();"
                                            , true);
            //ScriptManager.RegisterClientScriptBlock(Page
                                                    //, Page.GetType()
                                                    //, "popupOk"
                                                    //, "AbrirPopUpOk();"
                                                    //, true);

        }
    }
}