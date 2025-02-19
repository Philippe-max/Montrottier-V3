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
    public partial class Paiements : Form
    {
        public Paiements()
        {
            InitializeComponent();
        }

        private void Paiements_Load(object sender, EventArgs e)
        {

            numTxtMnt.Controls[0].Visible = false;
            numTxtMntCaf.Controls[0].Visible = false; ;

            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            // liste deroulante des locataires disponibles
            string strLocataire;
            command.CommandText = "select IdLocataire, nom1, Prenom1, nom2, Prenom2 from Locataires where archive =  0";
            SqlDataReader DataReaderLocataires = command.ExecuteReader();
            while (DataReaderLocataires.Read())
            {
                strLocataire = DataReaderLocataires["IdLocataire"].ToString() + ' ' + DataReaderLocataires["nom1"].ToString() + ' ' + DataReaderLocataires["Prenom1"].ToString() + " / " + DataReaderLocataires["nom2"].ToString() + " " + DataReaderLocataires["Prenom2"].ToString();
                lstLocataires.Items.Add(strLocataire);
            }
            DataReaderLocataires.Close();
        }

        private void lstLocataires_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL;
            int idLocataire;
            idLocataire = RecupereId(lstLocataires.Text);

            // affichage historique
            string sDate;
            strSQL = "Select Datepaiement, Montant, MontantCAF, Type from Paiements where IdLocataire = " + idLocataire + " order by Datepaiement desc";
            dataGridView1.Rows.Clear();
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
            command.CommandText = strSQL;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sDate = reader["Datepaiement"].ToString();
                sDate = sDate.Substring(0,8);
                dataGridView1.Rows.Add(sDate, reader["Montant"].ToString(), reader["MontantCAF"].ToString(), reader["Type"].ToString() );
                
            }


            
            c.Close();
        }
        private int RecupereId(string sSelection)
        {
            int iData;
            string[] SData;
            SData = sSelection.Split(' ');
            iData = Int32.Parse(SData[0]);
            return iData;
        }

        private string RecupereType()
        {
            string sType = "";
            if (rbnVirement.Checked == true)
                sType = "Vir.";
            else if (rbnCheque.Checked == true)
                sType = "Cheq.";
            else if (rbnEspeces.Checked == true)
                sType= "Esp.";
            return sType;
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            //enregistrement du paiement

            string strSQL ="";
            int idLocataire;
            idLocataire = RecupereId(lstLocataires.Text);
            string strType;
            strType = RecupereType();

            strSQL = "INSERT INTO Paiements (idLocataire, Datepaiement, Montant,MontantCAF, Type ) VALUES ('" + idLocataire + "',@Datepaiement,'" + numTxtMnt.Value + "','" + numTxtMntCaf.Value + "','" + strType + "')";
            MessageBox.Show(strSQL);
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
            command.CommandText = strSQL;
            SqlParameter prm = new SqlParameter("@Datepaiement", dtpDatePaiement.Value.Date);
            command.Parameters.Add(prm);
            command.ExecuteNonQuery();
        }

    }
}
