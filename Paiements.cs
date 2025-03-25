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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Montrottier_V2
{
    public partial class Paiements : Form
    {

        public class LocatairePayeur
        {
            public int idLocatairePayeur { get; set; }
            public int Montant { get; set; }
        }
        
        public LocatairePayeur monLocatairePayeur = new LocatairePayeur();

        
        public Paiements()
        {
            InitializeComponent();
        }

        private void Paiements_Load(object sender, EventArgs e)
        {

            numTxtMnt.Controls[0].Visible = false;
            numTxtMntCaf.Controls[0].Visible = false; ;
            lstVLocataires.Columns[0].Width = 260;
            lstVLocataires.Columns[1].Width = 0;
            lstVLocataires.Columns[2].Width = 0;

            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
           
            // liste des locataires  
            
            string strLocataire;
            command.CommandText = "select Locataires.IdLocataire, nom1, Prenom1, nom2, Prenom2, MntLoyerHCActuel + MntProvCharges as MontantDu from Locataires inner join Baux on Baux.IdLocataire = Locataires.IdLocataire where Baux.archive =  0";
            SqlDataReader DataReaderLocataires = command.ExecuteReader();
            while (DataReaderLocataires.Read())
            {
                strLocataire = DataReaderLocataires["nom1"].ToString() + ' ' + DataReaderLocataires["Prenom1"].ToString() + " / " + DataReaderLocataires["nom2"].ToString() + " " + DataReaderLocataires["Prenom2"].ToString();
                
                string[] rows = { strLocataire, DataReaderLocataires["IdLocataire"].ToString(),  DataReaderLocataires["MontantDu"].ToString() } ;
                var listviewitem = new ListViewItem(rows);
                lstVLocataires.Items.Add(listviewitem);

            }
            DataReaderLocataires.Close();

        }


        

        private string RecupereTypePaiement()
        {
            string sType = "";
            if (rbnVirement.Checked == true)
                sType = "Vir.";
            else if (rbnCheque.Checked == true)
                sType = "Cheq.";
            else if (rbnEspeces.Checked == true)
                sType = "Esp.";
            return sType;
        }

        private void refeshDataGrid()
        {
            string strSQL;
            string sDate;
            strSQL = "Select Datepaiement, Montant, MontantCAF, Type from Paiements where IdLocataire = " + monLocatairePayeur.idLocatairePayeur + " order by Datepaiement desc";
            dataGridView1.Rows.Clear();
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
            command.CommandText = strSQL;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sDate = reader["Datepaiement"].ToString();
                sDate = sDate.Substring(0, 8);
                dataGridView1.Rows.Add(sDate, reader["Montant"].ToString(), reader["MontantCAF"].ToString(), reader["Type"].ToString());

            }
            c.Close();

        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            //enregistrement du paiement

            string strSQL ="";
            
            string strType;
            strType = RecupereTypePaiement();

            strSQL = "INSERT INTO Paiements (idLocataire, Datepaiement, Montant,MontantCAF, Type ) VALUES ('" + monLocatairePayeur.idLocatairePayeur + "',@Datepaiement,'" + numTxtMnt.Value + "','" + numTxtMntCaf.Value + "','" + strType + "')";
            MessageBox.Show(strSQL);
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
            command.CommandText = strSQL;
            SqlParameter prm = new SqlParameter("@Datepaiement", dtpDatePaiement.Value.Date);
            command.Parameters.Add(prm);
            command.ExecuteNonQuery();

            refeshDataGrid();

        }

        private void lstVLocataires_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection LocPayant = lstVLocataires.SelectedItems;

            if (lstVLocataires.SelectedItems.Count.ToString() == "1")
            {
                ListViewItem item = LocPayant[0];
                monLocatairePayeur.idLocatairePayeur = int.Parse(item.SubItems[1].Text);
                monLocatairePayeur.Montant = int.Parse(item.SubItems[2].Text);
                numTxtMnt.Value = monLocatairePayeur.Montant;
                refeshDataGrid();
            }

        }
    }
}
