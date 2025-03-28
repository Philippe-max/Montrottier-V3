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
    public partial class Lots : Form
    {
        public Lots()
        {
            InitializeComponent();
        }

        private void Lots_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            string strType = "";
            if (rbtParking.Checked)
            {
                strType = "Parking";
            }
            else
            {
                strType = "Appart T" + txtNbrePieces.Text ;
            }
            dataGridView1.Rows.Add(new object[] { strType, txtSurface.Text, txtNiveau.Text.ToUpper(), txtSituation.Text });
            initForm();
        }
        private void initForm()
        {
            //par defaut lot parking
            txtSituation.Text = "";
            txtSurface.Text = "";
            txtSituation.Text = "";
            txtNbrePieces.Visible = false;
            lblNrePieces.Visible = false;
            txtSurface.Visible = false;
            lblSurface.Visible = false;
            rbtParking.Checked = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // selection appart
            if (radioButton2.Checked)
            {

                txtSurface.Visible = true;
                lblSurface.Visible = true;
                txtNiveau.Text = string.Empty;
                txtNbrePieces.Visible = true;
                lblNrePieces.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // enregistrement de tous les lots presents dans le dataGridView1
            string strSQL;
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Decimal Surface = Convert.ToDecimal(row.Cells["Surface"].Value);
                strSQL = "INSERT INTO TLots (Type,Surface,Situation, Niveau ) VALUES ('" + row.Cells["Type"].Value + "',@Surface,'" + row.Cells["Situation"].Value + "','" + row.Cells["Niveau"].Value + "')";
                SqlParameter prm1 = new SqlParameter("@Surface", Surface);

                MessageBox.Show(strSQL);
                command.CommandText = strSQL;
                command.Parameters.Add(prm1);

                command.ExecuteNonQuery();

            }
            c.Close();
        }
    }
}
