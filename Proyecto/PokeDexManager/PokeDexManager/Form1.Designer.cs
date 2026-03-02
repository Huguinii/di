namespace PokeDexManager
{
    partial class PokeDexManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeDexManager));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPokedexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCombateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsslListo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPokemonCargados = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenido = new System.Windows.Forms.Panel();
            this.guiaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pokemonToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.Name = "menuBar";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pokemonToolStripMenuItem
            // 
            this.pokemonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPokedexToolStripMenuItem,
            this.registrarCombateToolStripMenuItem});
            this.pokemonToolStripMenuItem.Name = "pokemonToolStripMenuItem";
            resources.ApplyResources(this.pokemonToolStripMenuItem, "pokemonToolStripMenuItem");
            // 
            // verPokedexToolStripMenuItem
            // 
            this.verPokedexToolStripMenuItem.Name = "verPokedexToolStripMenuItem";
            resources.ApplyResources(this.verPokedexToolStripMenuItem, "verPokedexToolStripMenuItem");
            this.verPokedexToolStripMenuItem.Click += new System.EventHandler(this.verPokedexToolStripMenuItem_Click);
            // 
            // registrarCombateToolStripMenuItem
            // 
            this.registrarCombateToolStripMenuItem.Name = "registrarCombateToolStripMenuItem";
            resources.ApplyResources(this.registrarCombateToolStripMenuItem, "registrarCombateToolStripMenuItem");
            this.registrarCombateToolStripMenuItem.Click += new System.EventHandler(this.registrarCombateToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.guiaDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            resources.ApplyResources(this.informesToolStripMenuItem, "informesToolStripMenuItem");
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslListo,
            this.tsslPokemonCargados});
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // tsslListo
            // 
            this.tsslListo.Name = "tsslListo";
            resources.ApplyResources(this.tsslListo, "tsslListo");
            // 
            // tsslPokemonCargados
            // 
            this.tsslPokemonCargados.Name = "tsslPokemonCargados";
            resources.ApplyResources(this.tsslPokemonCargados, "tsslPokemonCargados");
            // 
            // ttip
            // 
            this.ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttip.ToolTipTitle = "Ayuda";
            // 
            // panelContenido
            // 
            this.panelContenido.BackgroundImage = global::PokeDexManager.Properties.Resources.BackgroundMenu;
            resources.ApplyResources(this.panelContenido, "panelContenido");
            this.panelContenido.Name = "panelContenido";
            // 
            // guiaDeUsuarioToolStripMenuItem
            // 
            this.guiaDeUsuarioToolStripMenuItem.Name = "guiaDeUsuarioToolStripMenuItem";
            resources.ApplyResources(this.guiaDeUsuarioToolStripMenuItem, "guiaDeUsuarioToolStripMenuItem");
            // 
            // PokeDexManager
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokeDexManager.Properties.Resources.BackgroundMenu;
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuBar;
            this.Name = "PokeDexManager";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPokedexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCombateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslListo;
        private System.Windows.Forms.ToolStripStatusLabel tsslPokemonCargados;
        private System.Windows.Forms.ToolTip ttip;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guiaDeUsuarioToolStripMenuItem;
    }
}

