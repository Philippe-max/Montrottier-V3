namespace Montrottier_V2
{
    partial class Quitances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lstLocataires = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToMail = new System.Windows.Forms.Button();
            this.dataSet11 = new Montrottier_V2.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.montrottierDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montrottierDataSet1 = new Montrottier_V2.MontrottierDataSet1();
            this.QuitanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montrottierDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montrottierDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLocataires
            // 
            this.lstLocataires.FormattingEnabled = true;
            this.lstLocataires.Location = new System.Drawing.Point(27, 21);
            this.lstLocataires.Name = "lstLocataires";
            this.lstLocataires.Size = new System.Drawing.Size(457, 30);
            this.lstLocataires.TabIndex = 0;
            this.lstLocataires.SelectedIndexChanged += new System.EventHandler(this.lstLocataires_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locataire";
            // 
            // btnToMail
            // 
            this.btnToMail.Location = new System.Drawing.Point(510, 21);
            this.btnToMail.Name = "btnToMail";
            this.btnToMail.Size = new System.Drawing.Size(103, 23);
            this.btnToMail.TabIndex = 4;
            this.btnToMail.Text = "Envoyer par Mail";
            this.btnToMail.UseVisualStyleBackColor = true;
            this.btnToMail.Click += new System.EventHandler(this.btnToMail_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.montrottierDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Montrottier_V2.RptQuitance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1052, 423);
            this.reportViewer1.TabIndex = 5;
            // 
            // montrottierDataSet1BindingSource
            // 
            this.montrottierDataSet1BindingSource.DataSource = this.montrottierDataSet1;
            this.montrottierDataSet1BindingSource.Position = 0;
            // 
            // montrottierDataSet1
            // 
            this.montrottierDataSet1.DataSetName = "MontrottierDataSet1";
            this.montrottierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuitanceBindingSource
            // 
            this.QuitanceBindingSource.DataMember = "Quitance";
            this.QuitanceBindingSource.DataSource = this.montrottierDataSet1;
            // 
            // Quitances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 666);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnToMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLocataires);
            this.Name = "Quitances";
            this.Text = "Quitances";
            this.Load += new System.EventHandler(this.Quitances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montrottierDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montrottierDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLocataires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToMail;
        private DataSet1 dataSet11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource montrottierDataSet1BindingSource;
        private MontrottierDataSet1 montrottierDataSet1;
        private System.Windows.Forms.BindingSource QuitanceBindingSource;
    }
}