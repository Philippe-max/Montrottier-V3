using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montrottier_V2
{
    public partial class Charges : Form
    {
        public Charges()
        {
            InitializeComponent();
        }


        private void Charges_Load(object sender, EventArgs e)
        {

            RefreshDataGrid();

        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            command.CommandText = "select * from ChargesLoc ";


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add( reader[1], reader[2], reader[3]);

            }
            c.Close();
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            //enregistrement du paiement

            string strSQL = "";
            
            strSQL = "INSERT INTO ChargesLoc ( DateFacture, Element, Montant ) VALUES (@DateFacture,'" + txtCharge.Text + "','" + numMontant.Value + "')";
            MessageBox.Show(strSQL);
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
            command.CommandText = strSQL;
            SqlParameter prm = new SqlParameter("@DateFacture", dtpDateFacture.Value.Date);
            command.Parameters.Add(prm);
            command.ExecuteNonQuery();
            c.Close();
            RefreshDataGrid();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            ImprimeListChargeLoc MImprimeListChargeLoc = new ImprimeListChargeLoc();
            //Mlocataires.MdiParent = this;
            MImprimeListChargeLoc.Show();
        }
    }
}
