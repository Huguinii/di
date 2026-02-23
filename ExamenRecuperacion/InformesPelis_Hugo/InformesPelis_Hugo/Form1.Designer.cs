namespace InformesPelis_Hugo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.películasYRepartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresPorPaísesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresConPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(799, 542);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.películasYRepartoToolStripMenuItem,
            this.actoresPorPaísesToolStripMenuItem,
            this.actoresConPelículasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // películasYRepartoToolStripMenuItem
            // 
            this.películasYRepartoToolStripMenuItem.Name = "películasYRepartoToolStripMenuItem";
            this.películasYRepartoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.películasYRepartoToolStripMenuItem.Text = "Películas y reparto";
            this.películasYRepartoToolStripMenuItem.Click += new System.EventHandler(this.películasYRepartoToolStripMenuItem_Click);
            // 
            // actoresPorPaísesToolStripMenuItem
            // 
            this.actoresPorPaísesToolStripMenuItem.Name = "actoresPorPaísesToolStripMenuItem";
            this.actoresPorPaísesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.actoresPorPaísesToolStripMenuItem.Text = "Actores por países";
            this.actoresPorPaísesToolStripMenuItem.Click += new System.EventHandler(this.actoresPorPaísesToolStripMenuItem_Click);
            // 
            // actoresConPelículasToolStripMenuItem
            // 
            this.actoresConPelículasToolStripMenuItem.Name = "actoresConPelículasToolStripMenuItem";
            this.actoresConPelículasToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.actoresConPelículasToolStripMenuItem.Text = "Actores con películas";
            this.actoresConPelículasToolStripMenuItem.Click += new System.EventHandler(this.actoresConPelículasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 566);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem películasYRepartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoresPorPaísesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoresConPelículasToolStripMenuItem;
    }
}

