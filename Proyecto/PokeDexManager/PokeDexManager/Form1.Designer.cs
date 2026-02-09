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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsslListo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPokemonCargados = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuarioConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.cxtMenuPokemon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVerDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerCombates = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtMenuFiltro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tscbFiltrarPorTipo = new System.Windows.Forms.ToolStripComboBox();
            this.tstbPokemonPorNombre = new System.Windows.Forms.ToolStripTextBox();
            this.tstbPokemonPorNivel = new System.Windows.Forms.ToolStripTextBox();
            this.tstbPokemonPorVictorias = new System.Windows.Forms.ToolStripTextBox();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.cxtMenuPokemon.SuspendLayout();
            this.cxtMenuFiltro.SuspendLayout();
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
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslListo,
            this.tsslPokemonCargados,
            this.tsslUsuarioConectado});
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
            // tsslUsuarioConectado
            // 
            this.tsslUsuarioConectado.Name = "tsslUsuarioConectado";
            resources.ApplyResources(this.tsslUsuarioConectado, "tsslUsuarioConectado");
            // 
            // cxtMenuPokemon
            // 
            this.cxtMenuPokemon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerDetalles,
            this.tsmiEditar,
            this.tsmiEliminar,
            this.tsmiVerCombates});
            this.cxtMenuPokemon.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cxtMenuPokemon, "cxtMenuPokemon");
            // 
            // tsmiVerDetalles
            // 
            this.tsmiVerDetalles.Name = "tsmiVerDetalles";
            resources.ApplyResources(this.tsmiVerDetalles, "tsmiVerDetalles");
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.Name = "tsmiEditar";
            resources.ApplyResources(this.tsmiEditar, "tsmiEditar");
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Name = "tsmiEliminar";
            resources.ApplyResources(this.tsmiEliminar, "tsmiEliminar");
            // 
            // tsmiVerCombates
            // 
            this.tsmiVerCombates.Name = "tsmiVerCombates";
            resources.ApplyResources(this.tsmiVerCombates, "tsmiVerCombates");
            // 
            // cxtMenuFiltro
            // 
            this.cxtMenuFiltro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbFiltrarPorTipo,
            this.tstbPokemonPorNombre,
            this.tstbPokemonPorNivel,
            this.tstbPokemonPorVictorias});
            this.cxtMenuFiltro.Name = "cxtMenuFiltro";
            resources.ApplyResources(this.cxtMenuFiltro, "cxtMenuFiltro");
            // 
            // tscbFiltrarPorTipo
            // 
            this.tscbFiltrarPorTipo.Name = "tscbFiltrarPorTipo";
            resources.ApplyResources(this.tscbFiltrarPorTipo, "tscbFiltrarPorTipo");
            // 
            // tstbPokemonPorNombre
            // 
            resources.ApplyResources(this.tstbPokemonPorNombre, "tstbPokemonPorNombre");
            this.tstbPokemonPorNombre.Name = "tstbPokemonPorNombre";
            // 
            // tstbPokemonPorNivel
            // 
            resources.ApplyResources(this.tstbPokemonPorNivel, "tstbPokemonPorNivel");
            this.tstbPokemonPorNivel.Name = "tstbPokemonPorNivel";
            // 
            // tstbPokemonPorVictorias
            // 
            resources.ApplyResources(this.tstbPokemonPorVictorias, "tstbPokemonPorVictorias");
            this.tstbPokemonPorVictorias.Name = "tstbPokemonPorVictorias";
            // 
            // ttip
            // 
            this.ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttip.ToolTipTitle = "Ayuda";
            // 
            // PokeDexManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokeDexManager.Properties.Resources.BackgroundMenu;
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuBar;
            this.Name = "PokeDexManager";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.cxtMenuPokemon.ResumeLayout(false);
            this.cxtMenuFiltro.ResumeLayout(false);
            this.cxtMenuFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ContextMenuStrip cxtMenuPokemon;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPokedexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCombateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslListo;
        private System.Windows.Forms.ToolStripStatusLabel tsslPokemonCargados;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuarioConectado;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerDetalles;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerCombates;
        private System.Windows.Forms.ContextMenuStrip cxtMenuFiltro;
        private System.Windows.Forms.ToolStripComboBox tscbFiltrarPorTipo;
        private System.Windows.Forms.ToolStripTextBox tstbPokemonPorNombre;
        private System.Windows.Forms.ToolStripTextBox tstbPokemonPorNivel;
        private System.Windows.Forms.ToolStripTextBox tstbPokemonPorVictorias;
        private System.Windows.Forms.ToolTip ttip;
    }
}

