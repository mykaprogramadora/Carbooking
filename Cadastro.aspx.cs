using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Dinamicavei
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtModelo.Focus();
            txtModelo.Text= "";
            txtPlaca.Text = "";
            cmbAno.Text = "2015";
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text=="" || txtPlaca.Text == "")
            {
                string alerta = "Por favor preencha os campos em branco";
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script type='text/javascript'>alert('" + alerta + "')</script>");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ");
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                String instrucao_sql;
                instrucao_sql = "Insert into veiculos values ('" + txtModelo.Text + "','" + txtPlaca.Text + "','" + cmbAno.Text +  "','" + "Disponível" + "')";
                cmd = new SqlCommand(instrucao_sql, con);
                cmd.ExecuteNonQuery();
                string alerta = "Cadastrado com sucesso!!";
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script type='text/javascript'>alert('" + alerta + "')</script>");
                txtModelo.Focus();
                txtModelo.Text = "";
                txtPlaca.Text = "";
                cmbAno.Text = "2015";

            }
        }
    }
}