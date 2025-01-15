namespace Montrottier_V2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJPeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotToolStripMenuItem,
            this.locatairesToolStripMenuItem,
            this.bauxToolStripMenuItem,
            this.paiementToolStripMenuItem,
            this.quittancesToolStripMenuItem,
            this.chaToolStripMenuItem,
            this.mAJPeroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lotToolStripMenuItem
            // 
            this.lotToolStripMenuItem.Name = "lotToolStripMenuItem";
            this.lotToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lotToolStripMenuItem.Text = "Lots";
            this.lotToolStripMenuItem.Click += new System.EventHandler(this.lotToolStripMenuItem_Click);
            // 
            // locatairesToolStripMenuItem
            // 
            this.locatairesToolStripMenuItem.Name = "locatairesToolStripMenuItem";
            this.locatairesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.locatairesToolStripMenuItem.Text = "Locataires";
            this.locatairesToolStripMenuItem.Click += new System.EventHandler(this.locatairesToolStripMenuItem_Click);
            // 
            // bauxToolStripMenuItem
            // 
            this.bauxToolStripMenuItem.Name = "bauxToolStripMenuItem";
            this.bauxToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bauxToolStripMenuItem.Text = "Baux";
            this.bauxToolStripMenuItem.Click += new System.EventHandler(this.bauxToolStripMenuItem_Click);
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            this.paiementToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.paiementToolStripMenuItem.Text = "Paiements";
            this.paiementToolStripMenuItem.Click += new System.EventHandler(this.paiementToolStripMenuItem_Click);
            // 
            // quittancesToolStripMenuItem
            // 
            this.quittancesToolStripMenuItem.Name = "quittancesToolStripMenuItem";
            this.quittancesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.quittancesToolStripMenuItem.Text = "Quittances";
            this.quittancesToolStripMenuItem.Click += new System.EventHandler(this.quittancesToolStripMenuItem_Click);
            // 
            // chaToolStripMenuItem
            // 
            this.chaToolStripMenuItem.Name = "chaToolStripMenuItem";
            this.chaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.chaToolStripMenuItem.Text = "charges";
            this.chaToolStripMenuItem.Click += new System.EventHandler(this.chaToolStripMenuItem_Click);
            // 
            // mAJPeroToolStripMenuItem
            // 
            this.mAJPeroToolStripMenuItem.Name = "mAJPeroToolStripMenuItem";
            this.mAJPeroToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mAJPeroToolStripMenuItem.Text = "MAJ historique";
            this.mAJPeroToolStripMenuItem.Click += new System.EventHandler(this.mAJPeroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJPeroToolStripMenuItem;
    }
}

