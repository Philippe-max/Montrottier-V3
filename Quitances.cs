using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Montrottier_V2
{
    public partial class Quitances : Form
    {
        public Quitances()
        {
            InitializeComponent();
        }

        private void Quitances_Load(object sender, EventArgs e)
        {
            //recherche des locataires en cours
            string strSQL;
            strSQL = "select nom1 prenom1 nom2 prenom2 from Locataires";
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            QuitanceAImprimer MPrint = new QuitanceAImprimer();
            MPrint.Show();
            
            //MQuitances.Dock = DockStyle.Fill;
        }
    }
}
