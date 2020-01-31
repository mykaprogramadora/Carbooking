using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Dinamicavei
{
    public partial class ConfirmaR : System.Web.UI.Page
    {
        public static string id_veiculo { get; set; }
        SqlConnection conn = null;
        private string Conn = "Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ";
        private string Cmd = string.Empty;
        private string Cmd1 = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            var id_veiculo1 = Request.QueryString["id_veiculo"];
            id_veiculo = id_veiculo1;
            string datai = Reserva.datai;
            string dataf = Reserva.dataf;
            txtDatai.Text = datai;
            txtDataf.Text = dataf;

            Cmd1 = "Select * from reservas where id_veiculo =" + id_veiculo1  +  "and dtinicio ='" + datai + "' and dtfinal ='" + dataf + "'and estado='Confirmada' or estado='Provisória'";
            conn = new SqlConnection(Conn);
            SqlCommand comando = new SqlCommand(Cmd1, conn);
         
            conn.Open();
            SqlDataReader rdr = comando.ExecuteReader();

            if (rdr.HasRows == true)
            {
                
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ");
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                String instrucao_sql;
                instrucao_sql = "Insert into reservas (dtinicio, dtfinal, estado, id_veiculo) values ('" + datai + "','" + dataf + "','" + "Provisória" + "'," + id_veiculo1 + ");";
                cmd = new SqlCommand(instrucao_sql, con);
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = con.CreateCommand();
                String instrucao_sql1;
                instrucao_sql1 = "Update veiculos SET  estado = '" + "Indisponível" + "'  where id_veiculo= " + id_veiculo1;

                cmd1 = new SqlCommand(instrucao_sql1, con);
                cmd1.ExecuteNonQuery();
                
                }
            Cmd = "Select * from veiculos where id_veiculo = " + id_veiculo1;
            conn = new SqlConnection(Conn);
            SqlCommand comando1 = new SqlCommand(Cmd, conn);
           

            conn.Open();
            SqlDataReader rdr1 = comando1.ExecuteReader();

            if (rdr1.HasRows == true)
            {
                rdr1.Read();
                txtModelo.Text = Convert.ToString(rdr1["modelo"]);
                txtPlaca.Text = Convert.ToString(rdr1["placa"]);
            }
            conn.Close();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var id_veiculo1 = Request.QueryString["id_veiculo"];
            id_veiculo = id_veiculo1;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ");
            SqlCommand cmd1 = con.CreateCommand();
            String instrucao_sql1;
            instrucao_sql1 = "Update reservas SET  estado = '" + "Confirmada" + "'  where id_veiculo= " + id_veiculo1;
            con.Open();
            cmd1 = new SqlCommand(instrucao_sql1, con);
            cmd1.ExecuteNonQuery();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            var id_veiculo1 = Request.QueryString["id_veiculo"];
            id_veiculo = id_veiculo1;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ");
            SqlCommand cmd1 = con.CreateCommand();
            String instrucao_sql1;
            instrucao_sql1 = "Update reservas SET  estado = '" + "Cancelada" + "'  where id_veiculo= " + id_veiculo1;
            con.Open();
            cmd1 = new SqlCommand(instrucao_sql1, con);
            cmd1.ExecuteNonQuery();


            SqlCommand cmd2 = con.CreateCommand();
            String instrucao_sql2;
            instrucao_sql2 = "Update veiculos SET  estado = '" + "Disponível" + "'  where id_veiculo= " + id_veiculo1;

            cmd2 = new SqlCommand(instrucao_sql2, con);
            cmd2.ExecuteNonQuery();
        }
    }
}