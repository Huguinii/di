namespace PokeDexManager
{
    partial class VerInformacion
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informeGraficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePorParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeMultipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 426);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeGraficoToolStripMenuItem,
            this.informePorParametrosToolStripMenuItem,
            this.informeMultipleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informeGraficoToolStripMenuItem
            // 
            this.informeGraficoToolStripMenuItem.Name = "informeGraficoToolStripMenuItem";
            this.informeGraficoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.informeGraficoToolStripMenuItem.Text = "Informe gráfico";
            this.informeGraficoToolStripMenuItem.Click += new System.EventHandler(this.informeGraficoToolStripMenuItem_Click);
            // 
            // informePorParametrosToolStripMenuItem
            // 
            this.informePorParametrosToolStripMenuItem.Name = "informePorParametrosToolStripMenuItem";
            this.informePorParametrosToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.informePorParametrosToolStripMenuItem.Text = "Informe por parámetros";
            this.informePorParametrosToolStripMenuItem.Click += new System.EventHandler(this.informePorParametrosToolStripMenuItem_Click);
            // 
            // informeMultipleToolStripMenuItem
            // 
            this.informeMultipleToolStripMenuItem.Name = "informeMultipleToolStripMenuItem";
            this.informeMultipleToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.informeMultipleToolStripMenuItem.Text = "Informe múltiples tablas";
            this.informeMultipleToolStripMenuItem.Click += new System.EventHandler(this.informeMultipleToolStripMenuItem_Click);
            // 
            // VerInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VerInformacion";
            this.Text = "VerInformacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informeGraficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePorParametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeMultipleToolStripMenuItem;
    }
}