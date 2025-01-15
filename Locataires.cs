using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montrottier_V2
{
    public partial class Locataires : Form
    {
        public Locataires()
        {
            InitializeComponent();
        }

        private void Locataires_Load(object sender, EventArgs e)
        {
            RefresDataGrid();

        }

        private void RefresDataGrid()
        {

            dataGridView1.Rows.Clear();
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;
 
            
            if (chbArchives.Checked == true)
            {
                command.CommandText = "select Nom1, Prenom1, Nom2, Prenom2, Tel ,Mail from locataires";
            }
            else
            {
                command.CommandText = "select Nom1, Prenom1, Nom2, Prenom2, Tel ,Mail from locataires where archive = 0"; 
            }

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);

            }
            c.Close();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            //verifie les renseignements obligatoires
            if ((txtNom1.Text == "") || (txtPrenom1.Text == "") || (PI1.Image == null))
            {
                MessageBox.Show("infos obligatoires : Nom, Prenom, PI ");
                return;
            }

            //insertion du locataire
            string SQL;
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            SQL = "Insert into Locataires (Nom1, Prenom1, Nom2, Prenom2, Tel, Mail) VALUES ('" +
                    txtNom1.Text + "','" + txtPrenom1.Text + "','" + txtNom2.Text + "','" + txtPrenom2.Text + "','" +
                    txtTel.Text + "','" + txtMail.Text +  "')";

            MessageBox.Show(SQL);
            command.CommandText = SQL;
            command.ExecuteNonQuery();


            //mise a jour de son image piece d'identité
            FileStream fs = new FileStream(lblNomFichierIdent.Text, FileMode.Open, FileAccess.Read);
            Byte[] tabImage = new Byte[fs.Length];
            fs.Read(tabImage, 0, tabImage.Length);
            fs.Close();
            SQL = "UPDATE Locataires SET PIdent1 = @Photo where Nom1 = '" + txtNom1.Text + "'";   
            command.CommandText = SQL;
            
            SqlParameter prm = new SqlParameter("@Photo", SqlDbType.VarBinary, tabImage.Length, ParameterDirection.Input, false,0, 0, null, DataRowVersion.Current, tabImage);
            command.Parameters.Add(prm);
            
            command.ExecuteNonQuery();


            c.Close();

            RefresDataGrid();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {

            MessageBox.Show("le locataire n'est pas supprimé, il est archivé");
            
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            string sNom1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sNom2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string s = "update Locataires set archive = 1 where Nom1 = '" + sNom1 + "' and Nom2 = '" + sNom2 + "'";
            MessageBox.Show(s);
            command.CommandText = s;
            command.ExecuteNonQuery();
            c.Close();
            RefresDataGrid();

        }

        private void btnPI1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FileName = "P Ident loc 1";
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // recherche du fichier image de la piece d'identite 1
            string strFichierPI;
            strFichierPI = openFileDialog1.FileName;
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(strFichierPI);
            System.IO.FileStream fileStream = fileInfo.OpenRead();
            PI1.Image = System.Drawing.Image.FromStream(fileStream);
            Application.DoEvents();
            fileStream.Close();
            lblNomFichierIdent.Text = strFichierPI;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printDocument1.PrintPage += PrintPage;
            printDocument1.Print();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            // recherche de la photo de PI dans BD
            string strSQL = "select PIdent1 from Locataires where archive =  0 and Nom1 = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            command.CommandText = strSQL;
            
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "PIdent1");
            Byte[] byteData = new Byte[0];

            byteData = (Byte[])(ds.Tables["PIdent1"].Rows[0][0]);
            MemoryStream stmData = new MemoryStream(byteData);

            e.Graphics.DrawImage(Image.FromStream(stmData),1,1,1000,1000);



        }

        private void PI1_Click(object sender, EventArgs e)
        {

        }

        private void chbArchives_CheckedChanged(object sender, EventArgs e)
        {
            RefresDataGrid();
        }
    }
}
