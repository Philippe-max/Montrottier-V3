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
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
//using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.IO;

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
            //remplissage de la liste des locataires
            SqlConnection c = new SqlConnection(FrmMain.connectionString);
            c.Open();
            SqlCommand command = c.CreateCommand();
            command.Connection = c;


            // liste deroulante des locataires disponibles
            string strLocataire;
            command.CommandText = "select Locataires.IdLocataire, nom1, Prenom1, nom2, Prenom2 , Mail, BoiteLettre from Locataires inner join Baux on Baux.IDLocataire = Locataires.IDLocataire where Locataires.archive =  0";
            SqlDataReader DataReaderLocataires = command.ExecuteReader();
            while (DataReaderLocataires.Read())
            {
                strLocataire = DataReaderLocataires["IdLocataire"].ToString() + '/' + DataReaderLocataires["nom1"].ToString() + ' ' + DataReaderLocataires["Prenom1"].ToString() + " / " + DataReaderLocataires["nom2"].ToString() + " " + DataReaderLocataires["Prenom2"].ToString() + " / " + DataReaderLocataires["Mail"].ToString() + " / " + DataReaderLocataires["BoiteLettre"].ToString();
                lstLocataires.Items.Add(strLocataire);
            }
            DataReaderLocataires.Close();





        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private string GetPWYahoo()
        {
            string line;
            StreamReader sr = new StreamReader("C:\\Users\\Thierry\\Desktop\\PW SMTP .txt");
            line = sr.ReadLine();
            sr.Close();
            return line;
        }

        private void btnToMail_Click(object sender, EventArgs e)
        {

            // recup du mot de passe serveur SMTP yahoo.fr 
            //
            // !!!! ne doit PAS apparaitre sur Github !!!!
            //
            string strPW = GetPWYahoo();

            // le rapport doit etre au format pdf pour vouvoir etre envoyer   



            // envois du rapport .pdf par mail
            MimeMessage MailToLocataire = new MimeMessage();
            MailToLocataire.From.Add(new MailboxAddress("Philippe SAUVAGE","psauvage73@yahoo.fr"));
            //MailToLocataire.To.Add(MailboxAddress.Parse("chloe.collingwood@outlook.fr"));
            MailToLocataire.To.Add(MailboxAddress.Parse("psauvage73@yahoo.fr"));
            MailToLocataire.Subject = "Quitance";
            MailToLocataire.Body = new TextPart("plain")
                {
                    Text = "En PJ votre quitance au format pdf" 
                };
            
            SmtpClient client = new SmtpClient();
            try
            {
                client.Connect("smtp.mail.yahoo.com", 465, true);

                
                client.Authenticate("psauvage73@yahoo.fr", strPW);
                
                client.Send(MailToLocataire);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }


        }


        private string GetAdresse()
        {
            string[] infos;
            infos = lstLocataires.Text.Split('/');

            return infos[1] + "\nLes Genets " + infos[4] + "\n69770  MONTROTTIER"; 
        }

        private void lstLocataires_SelectedIndexChanged(object sender, EventArgs e)
        {

            // génére la quitance = rapport rdlc basé sur la table Quitance
            DataTable dt = new DataTable("MontrottierDataSet1");
            string strSQL;
            strSQL = "select Periode, Element, FORMAT(Montant, 'C','fr-FR') as Montant, Regle from Quitance";

           

            SqlDataAdapter dataset = new SqlDataAdapter(strSQL, FrmMain.connectionString);

            dataset.Fill(dt);

            ReportDataSource Reportds = new ReportDataSource() { Name = "MontrottierDataSet1", Value = dt };
            Reportds.Name = "MontrottierDataSet1";
            Reportds.Value = dt;
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Thierry\\source\\repos\\Montrottier V2\\RPTQuitance.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(Reportds);

            
            // l adresse du locataire est passée au rapport en parametre
            string strAdresseLoc = GetAdresse();
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "ParamNomLocataire";
            parameter.Values.Add(strAdresseLoc);


            reportViewer1.LocalReport.SetParameters(parameter);

            this.reportViewer1.RefreshReport();


            // enregistre aussi le rapport au format pdf en vue de son eventuel envoie par mail 
            string mimetype = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            string deviceInfo = "<DeviceInfo> <OutputFormat>PDF</OutputFormat>  <PageWidth>8.5in</PageWidth>  <PageHeight>11.6in</PageHeight>  <MarginTop>0.05in</MarginTop>   <MarginLeft>0.25in</MarginLeft>   <MarginRight>0.25in</MarginRight>  <MarginBottom>0.25in</MarginBottom>  </DeviceInfo>";
            string[] streamIsd;
            Warning[] warning;
            var bytes = reportViewer1.LocalReport.Render("PDF", deviceInfo, out mimetype, out encoding, out extension, out streamIsd, out warning);
            string strNomFichierPDF = "C:\\Users\\Thierry\\source\\repos\\Montrottier V2\\RPTQuitance.pdf";
            File.WriteAllBytes(strNomFichierPDF, bytes);   

            
        }
    }
}
