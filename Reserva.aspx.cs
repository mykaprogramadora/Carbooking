using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace Dinamicavei
{
    public partial class Reserva : System.Web.UI.Page
    {
        public static int contadora;
        public static int id_veiculo { get; set; }
        public static int Cont { get; set; }
        public static string datai { get; set; }
        public static string dataf { get; set; }


        SqlConnection conn = null;
        private string Conn = "Data Source=(localdb)\\Servidor;Initial Catalog= carbooking;Integrated Security=True; ";

        private string Cmd = string.Empty;
        private string Cmd1 = string.Empty;
        private string Cmd2 = string.Empty;
        private string Cmd3 = string.Empty;
        private string Cmd4 = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBusca_Click(object sender, EventArgs e)
        {
            /* Convertendo a data para o cadastro no banco */
            string dti = Convert.ToDateTime(txtInicio.Text).ToString("yyyy/MM/dd");
            string dtf = Convert.ToDateTime(txtFim.Text).ToString("yyyy/MM/dd");
            datai = dti + " " + txtHorai.Text + ":00";
            dataf = dtf + " " + txtHoraf.Text + ":00";

            /* variaveis para soma e criação das divs */
            int quantidade;
            int quantidade2;

            conn = new SqlConnection(Conn);

            /* Select da tabela de veiculos para contagem e criação das divs */
            Cmd = "Select COUNT(id_veiculo) from veiculos where estado= 'Disponível'";
            SqlCommand myCount = new SqlCommand(Cmd, conn);

            conn.Open();
            quantidade = (int)myCount.ExecuteScalar();


            /* Select das informações dos veiculos */
            Cmd1 = "Select * from veiculos where estado = 'Disponível'";
            SqlCommand comando1 = new SqlCommand(Cmd1, conn);

            SqlDataReader rdr1 = comando1.ExecuteReader();


            for (int i = 0; i < quantidade; i++)
            {
                if (rdr1.HasRows == true)
                {
                    rdr1.Read();

                    Cont++;

                    HtmlGenericControl createDiv = new HtmlGenericControl("DIV");
                    HtmlGenericControl Modelo = new HtmlGenericControl("LABEL");
                    HtmlGenericControl Ano = new HtmlGenericControl("LABEL");
                    HyperLink myHtmlLink = new HyperLink();

                    myHtmlLink.Text = "Reservar";
                    myHtmlLink.Attributes.Add("class", "btnReservar");
                    myHtmlLink.NavigateUrl = "ConfirmaR.aspx?id_veiculo=" + Convert.ToString(rdr1["id_veiculo"]);

                    createDiv.ID = "createDiv" + Cont;
                    createDiv.Attributes.Add("class", "item");

                    Modelo.InnerText = Convert.ToString(rdr1["modelo"]);
                    Modelo.Attributes.Add("class", "modelo");

                    Ano.InnerText = Convert.ToString(rdr1["ano"]);
                    Ano.Attributes.Add("class", "ano");

                    createDiv.Controls.Add(Modelo);
                    createDiv.Controls.Add(Ano);
                    createDiv.Controls.Add(myHtmlLink);

                    veiculos.Controls.Add(createDiv);

                    
                }
            }
            rdr1.Close();


            /* Select por data e hora 
            Select da tabela de reservas para contagem e criação das divs 
            Cmd2 = "Select COUNT(id_veiculo) from reservas where '" + datai + "'> dtinicio and '" + datai + "'> dtfinal";
            SqlCommand myCount2 = new SqlCommand(Cmd2, conn);

            quantidade2 = (int)myCount2.ExecuteScalar();

             Select das informações da reserva 
            Cmd3 = "Select * from reservas where '" +  datai + "'> dtinicio and '" + datai + "'> dtfinal";
            SqlCommand comando2 = new SqlCommand(Cmd3, conn);

            SqlDataReader rdr2 = comando2.ExecuteReader();

            
                if (rdr2.HasRows == true)
                {

                    rdr2.Read();
                    int id_veiculo = Convert.ToInt16(rdr2["id_veiculo"]);
                }

            rdr2.Close();

                Cmd4 = "Select * from veiculos where id_veiculo =" + id_veiculo;
                SqlCommand comando3 = new SqlCommand(Cmd4, conn);

                SqlDataReader rdr3 = comando3.ExecuteReader();
            for (int i = 0; i < quantidade2; i++)
            {
                if (rdr3.HasRows == true)
                {
                    rdr3.Read();

                    Cont++;

                    HtmlGenericControl createDiv = new HtmlGenericControl("DIV");
                    HtmlGenericControl Modelo = new HtmlGenericControl("LABEL");
                    HtmlGenericControl Ano = new HtmlGenericControl("LABEL");
                    HyperLink myHtmlLink = new HyperLink();

                    myHtmlLink.Text = "Reservar";
                    myHtmlLink.Attributes.Add("class", "btnReservar");
                    myHtmlLink.NavigateUrl = "ConfirmaR.aspx?id_veiculo=" + Convert.ToString(rdr3["id_veiculo"]);

                    createDiv.ID = "createDiv" + Cont;
                    createDiv.Attributes.Add("class", "item");

                    Modelo.InnerText = Convert.ToString(rdr3["modelo"]);
                    Modelo.Attributes.Add("class", "modelo");

                    Ano.InnerText = Convert.ToString(rdr3["ano"]);
                    Ano.Attributes.Add("class", "ano");

                    createDiv.Controls.Add(Modelo);
                    createDiv.Controls.Add(Ano);
                    createDiv.Controls.Add(myHtmlLink);

                    veiculos.Controls.Add(createDiv);

                }

            } */
        }
    }
}