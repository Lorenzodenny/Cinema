using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Cinema
{
    public partial class AddClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcquista_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BDCinemaConnetion"].ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string nome = txtName.Text;
                string cognome = txtCognome.Text;
                string sala = rdbSala.Text;
                string tipoBiglietto = rdbTipoBiglietto.Text;

                int countNord = GetCount(conn, "nord");
                int countEst = GetCount(conn, "est");
                int countSud = GetCount(conn, "sud");
                int countSalaSelected = GetCount(conn,sala);
                

                using (SqlCommand insertClient = new SqlCommand("Insert Into Utenti (Nome,Cognome,Sala,TipoBiglietto) values (@nome, @cognome, @sala, @tipoBiglietto)", conn))

                {
                    insertClient.Parameters.AddWithValue("@nome", nome);
                    insertClient.Parameters.AddWithValue("@cognome", cognome);
                    insertClient.Parameters.AddWithValue("@sala", sala);
                    insertClient.Parameters.AddWithValue("@tipoBiglietto", tipoBiglietto);

                    int affectedRow = insertClient.ExecuteNonQuery();
                    if (affectedRow != 0)
                    {
                        Response.Write("Biglietto acquistato");
                    }
                    else
                    {
                        Response.Write("Acquisto non riuscito");
                    }
                }
            }
        }

        private int GetCount(SqlConnection conn, string sala)
        {
            using (SqlCommand countSala = new SqlCommand("select count(*) from Utenti where Sala=@sala", conn))
            {
                countSala.Parameters.AddWithValue("@sala", sala);
                return (int)countSala.ExecuteScalar();
            }
        }
    }
}