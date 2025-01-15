namespace Montrottier_V2
{
    partial class Lots
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.lblSurface = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.rbtParking = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Suivant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Surface,
            this.Niveau,
            this.Situation});
            this.dataGridView1.Location = new System.Drawing.Point(46, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Surface
            // 
            this.Surface.Frozen = true;
            this.Surface.HeaderText = "Surface";
            this.Surface.Name = "Surface";
            this.Surface.ReadOnly = true;
            // 
            // Niveau
            // 
            this.Niveau.Frozen = true;
            this.Niveau.HeaderText = "Niveau";
            this.Niveau.Name = "Niveau";
            this.Niveau.ReadOnly = true;
            // 
            // Situation
            // 
            this.Situation.Frozen = true;
            this.Situation.HeaderText = "Situation";
            this.Situation.Name = "Situation";
            this.Situation.ReadOnly = true;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(240, 59);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(100, 20);
            this.txtSurface.TabIndex = 1;
            // 
            // lblSurface
            // 
            this.lblSurface.AutoSize = true;
            this.lblSurface.Location = new System.Drawing.Point(237, 43);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(77, 13);
            this.lblSurface.TabIndex = 2;
            this.lblSurface.Text = "Surface Carrez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niveau A B C  E";
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(378, 59);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(100, 20);
            this.txtNiveau.TabIndex = 3;
            this.txtNiveau.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Situation";
            // 
            // txtSituation
            // 
            this.txtSituation.Location = new System.Drawing.Point(507, 59);
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.Size = new System.Drawing.Size(100, 20);
            this.txtSituation.TabIndex = 5;
            // 
            // rbtParking
            // 
            this.rbtParking.AutoSize = true;
            this.rbtParking.Location = new System.Drawing.Point(80, 39);
            this.rbtParking.Name = "rbtParking";
            this.rbtParking.Size = new System.Drawing.Size(61, 17);
            this.rbtParking.TabIndex = 7;
            this.rbtParking.TabStop = true;
            this.rbtParking.Text = "Parking";
            this.rbtParking.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(80, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Appartement";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(678, 55);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 9;
            this.Suivant.Text = ">";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lots";
            // 
            // Lots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtParking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSituation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.lblSurface);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lots";
            this.Text = "Lots";
            this.Load += new System.EventHandler(this.Lots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label lblSurface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.RadioButton rbtParking;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surface;
        private System.Windows.Forms.DataGridViewTextBoxColumn Niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situation;
        private System.Windows.Forms.Label label5;
    }
}