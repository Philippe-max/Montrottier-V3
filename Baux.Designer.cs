namespace Montrottier_V2
{
    partial class Baux
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MntHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MntCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLocataires = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLots = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMntCHinit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvCharges = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbArchives = new System.Windows.Forms.CheckBox();
            this.dTPRevision = new System.Windows.Forms.DateTimePicker();
            this.dTPdebut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.Column1,
            this.Column2,
            this.MntHC,
            this.MntCharges,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(47, 36);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(933, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Locataire";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lot";
            this.Column2.Name = "Column2";
            // 
            // MntHC
            // 
            this.MntHC.HeaderText = "MntHC";
            this.MntHC.Name = "MntHC";
            // 
            // MntCharges
            // 
            this.MntCharges.HeaderText = "MntCharges";
            this.MntCharges.Name = "MntCharges";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date Derniere Reval";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "B. au lettre";
            this.Column4.Name = "Column4";
            // 
            // lstLocataires
            // 
            this.lstLocataires.FormattingEnabled = true;
            this.lstLocataires.Location = new System.Drawing.Point(47, 313);
            this.lstLocataires.Name = "lstLocataires";
            this.lstLocataires.Size = new System.Drawing.Size(196, 30);
            this.lstLocataires.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Locataire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lot";
            // 
            // lstLots
            // 
            this.lstLots.FormattingEnabled = true;
            this.lstLots.Location = new System.Drawing.Point(284, 313);
            this.lstLots.Name = "lstLots";
            this.lstLots.Size = new System.Drawing.Size(196, 30);
            this.lstLots.TabIndex = 3;
            this.lstLots.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Signature  du bail";
            // 
            // btnEnr
            // 
            this.btnEnr.Location = new System.Drawing.Point(284, 441);
            this.btnEnr.Name = "btnEnr";
            this.btnEnr.Size = new System.Drawing.Size(75, 23);
            this.btnEnr.TabIndex = 7;
            this.btnEnr.Text = "Enregistrer";
            this.btnEnr.UseVisualStyleBackColor = true;
            this.btnEnr.Click += new System.EventHandler(this.btnEnr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date revision ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Montant HC Actuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Montant HC init";
            // 
            // txtMntCHinit
            // 
            this.txtMntCHinit.Location = new System.Drawing.Point(47, 379);
            this.txtMntCHinit.Name = "txtMntCHinit";
            this.txtMntCHinit.Size = new System.Drawing.Size(77, 20);
            this.txtMntCHinit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Provi. Charges";
            // 
            // txtProvCharges
            // 
            this.txtProvCharges.Location = new System.Drawing.Point(243, 379);
            this.txtProvCharges.Name = "txtProvCharges";
            this.txtProvCharges.Size = new System.Drawing.Size(75, 20);
            this.txtProvCharges.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dépot Gar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(334, 379);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Baux";
            // 
            // chbArchives
            // 
            this.chbArchives.AutoSize = true;
            this.chbArchives.Location = new System.Drawing.Point(668, 12);
            this.chbArchives.Name = "chbArchives";
            this.chbArchives.Size = new System.Drawing.Size(67, 17);
            this.chbArchives.TabIndex = 19;
            this.chbArchives.Text = "Archives";
            this.chbArchives.UseVisualStyleBackColor = true;
            this.chbArchives.CheckedChanged += new System.EventHandler(this.chbArchives_CheckedChanged);
            // 
            // dTPRevision
            // 
            this.dTPRevision.Location = new System.Drawing.Point(757, 376);
            this.dTPRevision.Name = "dTPRevision";
            this.dTPRevision.Size = new System.Drawing.Size(200, 20);
            this.dTPRevision.TabIndex = 20;
            // 
            // dTPdebut
            // 
            this.dTPdebut.CustomFormat = "dd/MM/yyyy";
            this.dTPdebut.Location = new System.Drawing.Point(757, 323);
            this.dTPdebut.Name = "dTPdebut";
            this.dTPdebut.Size = new System.Drawing.Size(200, 20);
            this.dTPdebut.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Numero Boite au lettre";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(616, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 22;
            // 
            // Baux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 504);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dTPdebut);
            this.Controls.Add(this.dTPRevision);
            this.Controls.Add(this.chbArchives);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProvCharges);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMntCHinit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLocataires);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Baux";
            this.Text = "Baux";
            this.Load += new System.EventHandler(this.Baux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstLocataires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLots;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMntCHinit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvCharges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbArchives;
        private System.Windows.Forms.DateTimePicker dTPRevision;
        private System.Windows.Forms.DateTimePicker dTPdebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MntHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MntCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
    }
}