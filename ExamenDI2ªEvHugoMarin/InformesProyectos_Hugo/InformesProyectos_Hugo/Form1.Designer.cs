namespace InformesProyectos_Hugo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listadoDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costeDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listadoDeProyectosToolStripMenuItem,
            this.costeDeProyectosToolStripMenuItem,
            this.equiposDeProyectosToolStripMenuItem,
            this.clientesDeProyectosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listadoDeProyectosToolStripMenuItem
            // 
            this.listadoDeProyectosToolStripMenuItem.Name = "listadoDeProyectosToolStripMenuItem";
            this.listadoDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.listadoDeProyectosToolStripMenuItem.Text = "Listado de proyectos";
            this.listadoDeProyectosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProyectosToolStripMenuItem_Click);
            // 
            // costeDeProyectosToolStripMenuItem
            // 
            this.costeDeProyectosToolStripMenuItem.Name = "costeDeProyectosToolStripMenuItem";
            this.costeDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.costeDeProyectosToolStripMenuItem.Text = "Coste de proyectos";
            // 
            // equiposDeProyectosToolStripMenuItem
            // 
            this.equiposDeProyectosToolStripMenuItem.Name = "equiposDeProyectosToolStripMenuItem";
            this.equiposDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.equiposDeProyectosToolStripMenuItem.Text = "Equipos de proyectos";
            // 
            // clientesDeProyectosToolStripMenuItem
            // 
            this.clientesDeProyectosToolStripMenuItem.Name = "clientesDeProyectosToolStripMenuItem";
            this.clientesDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.clientesDeProyectosToolStripMenuItem.Text = "Clientes de proyectos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proyectos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costeDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeProyectosToolStripMenuItem;
    }
}

