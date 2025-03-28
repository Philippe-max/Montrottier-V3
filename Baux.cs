using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montrottier_V2
{
    public partial class Baux : Form
    {
        public Baux()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            if (chbArchives.Checked == true)
            {
                command.CommandText = "select Locataires.Nom1, Locataires.Prenom1, Locataires.Nom2, Locataires.Prenom2,  Type, Surface, Situation, MntLoyerHCInit, MntProvCharges, BoiteLettre from Baux inner join Locataires on Baux.IdLocataire = Locataires.IdLocataire inner join Tlots on Tlots.IdLot = Baux.IdLot";


            }
            else
            {
                command.CommandText = "select Locataires.Nom1, Locataires.Prenom1, Locataires.Nom2, Locataires.Prenom2, Type, Surface, Situation, MntLoyerHCInit, MntProvCharges, BoiteLettre from Baux inner join Locataires on Baux.IdLocataire = Locataires.IdLocataire inner join Tlots on Tlots.IdLot = Baux.IdLot where Baux.Archive = 0";


            }

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string slocataire = reader["Nom1"].ToString() + ' ' + reader["Prenom1"].ToString() + '/' + reader["Nom2"].ToString() + ' ' + reader["Prenom2"].ToString();
                string sLot = reader["Type"].ToString() + ' ' + reader["Surface"].ToString() + "m² " + reader["Situation"].ToString();
                dataGridView1.Rows.Add(slocataire, sLot, reader["MntLoyerHCInit"], reader["MntProvCharges"], reader[4], reader["BoiteLettre"]);


            }
            c.Close();
        }


        private void Baux_Load(object sender, EventArgs e)
        {

            RefreshDataGrid();



            SqlConnection c = new SqlConnection(FrmMain.connectionString);
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

            // liste deroulante des lots libres
            RefreshListLots();

        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            // recupere id du lot 
            int idLot;
            idLot = RecupereId(lstLots.Text);
            // recupere id du locataire
            int idLocataire;
            idLocataire = RecupereId(lstLocataires.Text);

            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            string strSQL;
            strSQL = "INSERT INTO Baux ( IdLot, IdLocataire, DateDebutBail, MntLoyerHCInit,MntProvCharges, BoiteLettre ) VALUES (@idLot , @idLocataire, @DateDebutBail,@MntHCinit,@ProvCharges,'" + txtBoiteLettre.Text + "' )";
            MessageBox.Show(strSQL);
            command.CommandText = strSQL;


            SqlParameter prm1 = new SqlParameter("@idLot", idLot);
            SqlParameter prm2 = new SqlParameter("@idLocataire", idLocataire);
            SqlParameter prm3 = new SqlParameter("@DateDebutBail", dTPdebut.Value.Date);
            SqlParameter prm4 = new SqlParameter("@MntHCinit", txtMntCHinit.Text);
            SqlParameter prm5 = new SqlParameter("@ProvCharges", txtProvCharges.Text);

            command.Parameters.Add(prm1);
            command.Parameters.Add(prm2);
            command.Parameters.Add(prm3);
            command.Parameters.Add(prm4);
            command.Parameters.Add(prm5);

            command.ExecuteNonQuery();

            RefreshDataGrid();
            RefreshListLots();
        }

        private int RecupereId (string sSelection)
        {
            int iData; 
            string[] SData;
            SData = sSelection.Split(' ');
            iData = Int32.Parse(SData[0]); 
            return iData;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void chbArchives_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnFinBail_Click(object sender, EventArgs e)
        {
            // archivage du bail
            MessageBox.Show("Le bail n'est pas supprimé, il est archivé "+ "\n\nLe lot redevient disponible");
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            string s = "update Baux set archive = 1, DateArchivage = @DateArchivage where IdBail = " + dataGridView1.SelectedRows[0].Cells["IdBail"].Value;
            
            command.CommandText = s;
            SqlParameter prm = new SqlParameter("@DateArchivage", dtpDateArchivage.Value.Date);
            command.Parameters.Add(prm);
            command.ExecuteNonQuery();
            c.Close();
            RefreshDataGrid();
            //rendre le lot disponible
            RefreshListLots();
        }
        private void RefreshListLots()
        {
            lstLots.Items.Clear();
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            string strLot;
            SqlCommand command = c.CreateCommand();
            command.CommandText = " select idLot, Type, Surface, Niveau, Situation from TLots where idLot not in ( select idLot from Baux where archive = 0 )";
            SqlDataReader monlecteur = command.ExecuteReader();
            while (monlecteur.Read())
            {
                strLot = monlecteur["idLot"].ToString() + ' ' + monlecteur["Type"].ToString() + ' ' + monlecteur["Surface"].ToString() + " " + monlecteur["Niveau"].ToString() + " " + monlecteur["Situation"].ToString();
                lstLots.Items.Add(strLot);
            }

        }

    }
}
