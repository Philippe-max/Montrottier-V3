using Microsoft.Reporting.WinForms;
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
    public partial class ImprimeListChargeLoc : Form
    {
        public ImprimeListChargeLoc()
        {
            InitializeComponent();
        }

        private void ImprimeListChargeLoc_Load(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(Form1.connectionString);
            c.Open();
            SqlCommand command = new SqlCommand("select * from ChargesLoc",c);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Thierry\\source\\repos\\Montrottier V2\\RPTListCharges.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
