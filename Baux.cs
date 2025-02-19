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
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            if (chbArchives.Checked == true)
            {
                command.CommandText = "select Locataires.Nom1, Locataires.Prenom1, Locataires.Nom2, Locataires.Prenom2,  Type, Situation, MntLoyerHCInit, BoiteLettre from Baux inner join Locataires on Baux.IdLocataire = Locataires.IdLocataire inner join Tlots on Tlots.IdLot = Baux.IdLot";

            }
            else
            {
                command.CommandText = "select Locataires.Nom1, Locataires.Prenom1, Locataires.Nom2, Locataires.Prenom2, Type, Situation, MntLoyerHCInit, BoiteLettre from Baux inner join Locataires on Baux.IdLocataire = Locataires.IdLocataire inner join Tlots on Tlots.IdLot = Baux.IdLot where Baux.Archive = 0";


            }

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string slocataire = reader["Nom1"].ToString() + ' ' + reader["Prenom1"].ToString() + '/' + reader["Nom2"].ToString() + ' ' + reader["Prenom2"].ToString();
                string sLot = reader["Type"].ToString() + ' ' + reader["Situation"].ToString();
                dataGridView1.Rows.Add(slocataire, sLot, reader["MntLoyerHCInit"], reader[3], reader[4], reader["BoiteLettre"]);

            }
            c.Close();
        }


        private void Baux_Load(object sender, EventArgs e)
        {

            RefreshDataGrid();



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

            // liste deroulante des lots libres
            string strLot;
            command.CommandText = " select idLot, Type, Surface, Niveau, Situation from TLots";

            SqlDataReader monlecteur = command.ExecuteReader();
            while (monlecteur.Read())
            {
                strLot = monlecteur["idLot"].ToString() + ' ' + monlecteur["Type"].ToString() + ' ' + monlecteur["Surface"].ToString() + " " + monlecteur["Niveau"].ToString() + " " + monlecteur["Situation"].ToString();
                lstLots.Items.Add(strLot);
            }


        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            // recupere id du lot 
            int idLot;
            idLot = RecupereId(lstLots.Text);
            // recupere id du locataire
            int idLocataire;
            idLocataire = RecupereId(lstLocataires.Text);

            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            string strSQL;
            strSQL = "INSERT INTO Baux ( IdLot, IdLocataire, DateDebutBail, MntLoyerHCInit,MntProvCharges ) VALUES (@idLot , @idLocataire, @DateDebutBail,@MntHCinit,@ProvCharges)";
            MessageBox.Show(strSQL);
            command.CommandText = strSQL;


            SqlParameter prm1 = new SqlParameter("@idLot", idLot);
            SqlParameter prm2 = new SqlParameter("@idLocataire", idLocataire);
            SqlParameter prm3 = new SqlParameter("@DateDebutBail", dTPdebut.Value.Date);
            SqlParameter prm4 = new SqlParameter("@MntHCinit", 200);
            SqlParameter prm5 = new SqlParameter("@ProvCharges", 200);

            command.Parameters.Add(prm1);
            command.Parameters.Add(prm2);
            command.Parameters.Add(prm3);
            command.Parameters.Add(prm4);
            command.Parameters.Add(prm5);

            command.ExecuteNonQuery();

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
    }
}
