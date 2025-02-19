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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprime = new System.Windows.Forms.Button();
            this.dataSet11 = new Montrottier_V2.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 0;
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
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(322, 15);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(103, 23);
            this.btnImprime.TabIndex = 4;
            this.btnImprime.Text = "Envoyer par Mail";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Montrottier_V2.RPTQuitance.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(348, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 5;
            // 
            // Quitances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 666);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Quitances";
            this.Text = "Quitances";
            this.Load += new System.EventHandler(this.Quitances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprime;
        private DataSet1 dataSet11;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}