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
            string strSQL = "select from baux where archive = 0";

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
            command.CommandText = "select id, nom1, Prenom1, nom2, Prenom2 from Locataires where archive =  0";
            SqlDataReader DataReaderLocataires = command.ExecuteReader();
            while (DataReaderLocataires.Read())
            {
                strLocataire = DataReaderLocataires["id"].ToString() + ' ' + DataReaderLocataires["nom1"].ToString() + ' ' + DataReaderLocataires["Prenom1"].ToString() + " / " + DataReaderLocataires["nom2"].ToString() + " " + DataReaderLocataires["Prenom2"].ToString();
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
            idLocataire = RecupereId(lstLots.Text);

            
            string strSQL;
            strSQL = "INSERT INTO Baux IdLot, IdLocataire, DateDebutBail, MntLoyerHCInit,MntProvCharges VALUES ('" + idLot + "," + idLocataire + "," + dTPdebut.Value;
            MessageBox.Show(strSQL);


        }

        private int RecupereId (string sSelection)
        {
            int iData; 
            string[] SData;
            SData = sSelection.Split(' ');
            iData = Int32.Parse(SData[0]); 
            return iData;
        }
    }
}
