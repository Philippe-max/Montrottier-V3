using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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





            //ReportDataSource reportDataSource = new ReportDataSource() { Name = "DataSet1", Value = dt };
            //reportViewer.LocalReport.ReportPath = "C:\\Users\\hp\\source\\repos\\SMSKICSO\\SMSKICSO\\myReports\\TermlyReport.rdlc";
            //reportViewer.LocalReport.DataSources.Add(reportDataSource);
            //reportViewer.RefreshReport();

            DataTable dt = new DataTable("DataSet1");
            string strSQL;
            strSQL = "select Periode, Element, Montant, Regle from Quitance";
            SqlDataAdapter dataset = new SqlDataAdapter(strSQL, Form1.connectionString);
            
            dataset.Fill(dt);
            
            MessageBox.Show(dt.Rows.Count.ToString());
            ReportDataSource Reportds = new ReportDataSource() { Name = "DataSet1", Value = dt }; 
            Reportds.Name = "DataSet1";
            Reportds.Value = dt;
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Thierry\\source\\repos\\Montrottier V2\\RPTQuitance.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportds);

            //reportViewer1.RefreshReport();
            // param pour adresse postale
            //ReportParameter[] Params = new ReportParameter[2];
            //Params[0] = new ReportParameter("paramLocataire", "Ducon", false);
            //Params[1] = new ReportParameter("paramBL", "BL12", false);
            //reportViewer1.ServerReport.SetParameters(Params);




            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        private void btnImprime_Click(object sender, EventArgs e)
        {
            //QuitanceAImprimer MPrint = new QuitanceAImprimer();
            //MPrint.Show();
//
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
