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
   

    public partial class FrmMain : Form
    {

        public static string connectionString = "Persist Security Info = False; Integrated Security = true;Initial Catalog = Montrottier; Server = (localdb)\\MSSQLLocalDB";
        

        public FrmMain()
        {
            InitializeComponent();
        }

        private void locatairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Locataires Mlocataires= new Locataires();
            Mlocataires.MdiParent = this;
            Mlocataires.Show();
            Mlocataires.Dock = DockStyle.Fill;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lots Mlots = new Lots();
            Mlots.MdiParent = this;
            Mlots.Show();
            Mlots.Dock = DockStyle.Fill;
        }

        private void bauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baux MBaux = new Baux();
            MBaux.MdiParent = this;
            MBaux.Show();
            MBaux.Dock = DockStyle.Fill;
        }

        private void quittancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quitances MQuitances = new Quitances();
            MQuitances.MdiParent = this;
            MQuitances.Show();
            MQuitances.Dock = DockStyle.Fill;

        }

        private void mAJPeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chargement des periodes dans la base de données
            //MAJPeriode();

        }
        private void MAJPeriode()
        {
            // chargement des periodes dans la base de données
            string strSQL;
            string strPeriode;
            string[] strTPeriode;

            DateTime dateCourante = new System.DateTime(1999, 1, 1);

            SqlConnection c = new SqlConnection(connectionString);
            c.Open();
            


            for (int i = 0; i <= 5; i++)
                //for (dateCourante = dateDebut; dateCourante <= dateFin; dateCourante = dateCourante.AddMonths(1))
            {
                strPeriode = dateCourante.ToLongDateString();

                strTPeriode = strPeriode.Split(' ');
                strSQL = "insert into TPeriodes (Periode) VALUES ('" + strTPeriode[2] + ' ' + strTPeriode[3] + "')";
                MessageBox.Show(strSQL);
                SqlCommand command = c.CreateCommand();
                command.Connection = c;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();

                dateCourante = dateCourante.AddMonths(1);
            }
            c.Close();

        }

        private void paiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paiements MPaiements = new Paiements();
            MPaiements.MdiParent = this;
            MPaiements.Show();
            MPaiements.Dock = DockStyle.Fill;

        }

        private void chaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charges MCharges = new Charges();
            MCharges.MdiParent = this;
            MCharges.Show();
            MCharges.Dock = DockStyle.Fill;
        }
    }
}
