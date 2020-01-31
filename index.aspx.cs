using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dinamicavei
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }

        protected void btnReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reserva.aspx");
        }
    }
}