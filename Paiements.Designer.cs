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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnVirement = new System.Windows.Forms.RadioButton();
            this.rbnCheque = new System.Windows.Forms.RadioButton();
            this.rbnEspeces = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.btnEnr = new System.Windows.Forms.Button();
            this.numTxtMnt = new System.Windows.Forms.NumericUpDown();
            this.numTxtMntCaf = new System.Windows.Forms.NumericUpDown();
            this.lstVLocataires = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MntDu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Annee,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(52, 288);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(678, 325);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Locataire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 51);
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
            this.label3.Location = new System.Drawing.Point(446, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Montant CAF";
            // 
            // dtpDatePaiement
            // 
            this.dtpDatePaiement.Location = new System.Drawing.Point(430, 180);
            this.dtpDatePaiement.Name = "dtpDatePaiement";
            this.dtpDatePaiement.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePaiement.TabIndex = 26;
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(52, 259);
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
            this.numTxtMnt.Location = new System.Drawing.Point(440, 76);
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
            this.numTxtMntCaf.Location = new System.Drawing.Point(440, 134);
            this.numTxtMntCaf.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTxtMntCaf.Name = "numTxtMntCaf";
            this.numTxtMntCaf.Size = new System.Drawing.Size(120, 20);
            this.numTxtMntCaf.TabIndex = 29;
            // 
            // lstVLocataires
            // 
            this.lstVLocataires.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.IdLoc,
            this.MntDu});
            this.lstVLocataires.FullRowSelect = true;
            this.lstVLocataires.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVLocataires.HideSelection = false;
            this.lstVLocataires.Location = new System.Drawing.Point(52, 68);
            this.lstVLocataires.MultiSelect = false;
            this.lstVLocataires.Name = "lstVLocataires";
            this.lstVLocataires.Size = new System.Drawing.Size(269, 97);
            this.lstVLocataires.TabIndex = 30;
            this.lstVLocataires.UseCompatibleStateImageBehavior = false;
            this.lstVLocataires.View = System.Windows.Forms.View.Details;
            this.lstVLocataires.SelectedIndexChanged += new System.EventHandler(this.lstVLocataires_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // IdLoc
            // 
            this.IdLoc.Text = "IdLoc";
            // 
            // MntDu
            // 
            this.MntDu.Text = "MntDu";
            // 
            // Group
            // 
            this.Group.FillWeight = 50F;
            this.Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Group.HeaderText = "+/-";
            this.Group.Name = "Group";
            this.Group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Group.Width = 50;
            // 
            // Annee
            // 
            this.Annee.HeaderText = "Annee";
            this.Annee.Name = "Annee";
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
            this.ClientSize = new System.Drawing.Size(1147, 625);
            this.Controls.Add(this.lstVLocataires);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnVirement;
        private System.Windows.Forms.RadioButton rbnCheque;
        private System.Windows.Forms.RadioButton rbnEspeces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.NumericUpDown numTxtMnt;
        private System.Windows.Forms.NumericUpDown numTxtMntCaf;
        private System.Windows.Forms.ListView lstVLocataires;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader IdLoc;
        private System.Windows.Forms.ColumnHeader MntDu;
        private System.Windows.Forms.DataGridViewButtonColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}