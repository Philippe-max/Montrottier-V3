namespace Montrottier_V2
{
    partial class Paiements
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLocataires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnVirement = new System.Windows.Forms.RadioButton();
            this.rbnCheque = new System.Windows.Forms.RadioButton();
            this.rbnEspeces = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.btnEnr = new System.Windows.Forms.Button();
            this.numTxtMnt = new System.Windows.Forms.NumericUpDown();
            this.numTxtMntCaf = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtMntCaf)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Paiements";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(52, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Locataire";
            // 
            // lstLocataires
            // 
            this.lstLocataires.FormattingEnabled = true;
            this.lstLocataires.Location = new System.Drawing.Point(52, 101);
            this.lstLocataires.Name = "lstLocataires";
            this.lstLocataires.Size = new System.Drawing.Size(196, 30);
            this.lstLocataires.TabIndex = 17;
            this.lstLocataires.SelectedIndexChanged += new System.EventHandler(this.lstLocataires_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Montant";
            // 
            // rbnVirement
            // 
            this.rbnVirement.AutoSize = true;
            this.rbnVirement.Checked = true;
            this.rbnVirement.Location = new System.Drawing.Point(653, 110);
            this.rbnVirement.Name = "rbnVirement";
            this.rbnVirement.Size = new System.Drawing.Size(66, 17);
            this.rbnVirement.TabIndex = 21;
            this.rbnVirement.TabStop = true;
            this.rbnVirement.Text = "Virement";
            this.rbnVirement.UseVisualStyleBackColor = true;
            // 
            // rbnCheque
            // 
            this.rbnCheque.AutoSize = true;
            this.rbnCheque.Location = new System.Drawing.Point(653, 148);
            this.rbnCheque.Name = "rbnCheque";
            this.rbnCheque.Size = new System.Drawing.Size(62, 17);
            this.rbnCheque.TabIndex = 22;
            this.rbnCheque.Text = "Cheque";
            this.rbnCheque.UseVisualStyleBackColor = true;
            // 
            // rbnEspeces
            // 
            this.rbnEspeces.AutoSize = true;
            this.rbnEspeces.Location = new System.Drawing.Point(653, 183);
            this.rbnEspeces.Name = "rbnEspeces";
            this.rbnEspeces.Size = new System.Drawing.Size(66, 17);
            this.rbnEspeces.TabIndex = 23;
            this.rbnEspeces.Text = "Espèces";
            this.rbnEspeces.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Montant CAF";
            // 
            // dtpDatePaiement
            // 
            this.dtpDatePaiement.Location = new System.Drawing.Point(427, 111);
            this.dtpDatePaiement.Name = "dtpDatePaiement";
            this.dtpDatePaiement.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePaiement.TabIndex = 26;
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(52, 247);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(75, 23);
            this.btnEnr.TabIndex = 27;
            this.btnEnr.Text = "Enregistrer";
            this.btnEnr.UseVisualStyleBackColor = true;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // numTxtMnt
            // 
            this.numTxtMnt.DecimalPlaces = 2;
            this.numTxtMnt.Location = new System.Drawing.Point(291, 110);
            this.numTxtMnt.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTxtMnt.Name = "numTxtMnt";
            this.numTxtMnt.Size = new System.Drawing.Size(120, 20);
            this.numTxtMnt.TabIndex = 28;
            // 
            // numTxtMntCaf
            // 
            this.numTxtMntCaf.DecimalPlaces = 2;
            this.numTxtMntCaf.Location = new System.Drawing.Point(291, 168);
            this.numTxtMntCaf.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTxtMntCaf.Name = "numTxtMntCaf";
            this.numTxtMntCaf.Size = new System.Drawing.Size(120, 20);
            this.numTxtMntCaf.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Montant";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MontantCAF";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            // 
            // Paiements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTxtMntCaf);
            this.Controls.Add(this.numTxtMnt);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.dtpDatePaiement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbnEspeces);
            this.Controls.Add(this.rbnCheque);
            this.Controls.Add(this.rbnVirement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLocataires);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "Paiements";
            this.Text = "Paiements";
            this.Load += new System.EventHandler(this.Paiements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtMntCaf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLocataires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnVirement;
        private System.Windows.Forms.RadioButton rbnCheque;
        private System.Windows.Forms.RadioButton rbnEspeces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.NumericUpDown numTxtMnt;
        private System.Windows.Forms.NumericUpDown numTxtMntCaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}