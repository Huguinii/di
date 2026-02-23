namespace PokeDexManager
{
    partial class UcPokedex
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.cxtMenuPokemon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVerDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoPokemon = new System.Windows.Forms.Button();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvPokedex = new System.Windows.Forms.DataGridView();
            this.cxtMenuPokemon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por tipo:";
            // 
            // cmbTipos
            // 
            this.cmbTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(131, 35);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(142, 28);
            this.cmbTipos.TabIndex = 1;
            this.cmbTipos.SelectedIndexChanged += new System.EventHandler(this.cmbTipos_SelectedIndexChanged);
            // 
            // cxtMenuPokemon
            // 
            this.cxtMenuPokemon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerDetalles,
            this.tsmiEditar,
            this.tsmiEliminar});
            this.cxtMenuPokemon.Name = "contextMenuStrip1";
            this.cxtMenuPokemon.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmiVerDetalles
            // 
            this.tsmiVerDetalles.Name = "tsmiVerDetalles";
            this.tsmiVerDetalles.Size = new System.Drawing.Size(180, 22);
            this.tsmiVerDetalles.Text = "Ver detalles";
            this.tsmiVerDetalles.Click += new System.EventHandler(this.tsmiVerDetalles_Click);
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.Name = "tsmiEditar";
            this.tsmiEditar.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditar.Text = "Editar";
            this.tsmiEditar.Click += new System.EventHandler(this.tsmiEditar_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.Click += new System.EventHandler(this.tsmiEliminar_Click);
            // 
            // btnNuevoPokemon
            // 
            this.btnNuevoPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoPokemon.BackColor = System.Drawing.Color.IndianRed;
            this.btnNuevoPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPokemon.Location = new System.Drawing.Point(667, 26);
            this.btnNuevoPokemon.Name = "btnNuevoPokemon";
            this.btnNuevoPokemon.Size = new System.Drawing.Size(195, 37);
            this.btnNuevoPokemon.TabIndex = 3;
            this.btnNuevoPokemon.Text = "Nuevo Pokemon";
            this.btnNuevoPokemon.UseVisualStyleBackColor = false;
            this.btnNuevoPokemon.Click += new System.EventHandler(this.btnNuevoPokemon_Click);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "Tipo";
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "Pokemon";
            // 
            // pokemonBindingSource1
            // 
            this.pokemonBindingSource1.DataMember = "Pokemon";
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataMember = "Especie";
            // 
            // tipoBindingSource1
            // 
            this.tipoBindingSource1.DataMember = "Tipo";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.Location = new System.Drawing.Point(343, 40);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(208, 20);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(371, 21);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(163, 16);
            this.lblBusqueda.TabIndex = 6;
            this.lblBusqueda.Text = "Búsqueda por nombre";
            // 
            // dgvPokedex
            // 
            this.dgvPokedex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPokedex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokedex.ContextMenuStrip = this.cxtMenuPokemon;
            this.dgvPokedex.Location = new System.Drawing.Point(3, 69);
            this.dgvPokedex.Name = "dgvPokedex";
            this.dgvPokedex.ReadOnly = true;
            this.dgvPokedex.Size = new System.Drawing.Size(932, 342);
            this.dgvPokedex.TabIndex = 4;
            this.dgvPokedex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPokedex_CellContentClick);
            this.dgvPokedex.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPokedex_RowPrePaint);
            // 
            // UcPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvPokedex);
            this.Controls.Add(this.btnNuevoPokemon);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.label1);
            this.Name = "UcPokedex";
            this.Size = new System.Drawing.Size(938, 432);
            this.Load += new System.EventHandler(this.UcPokedex_Load);
            this.cxtMenuPokemon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private System.Windows.Forms.BindingSource pokemonBindingSource1;
        private System.Windows.Forms.BindingSource especieBindingSource;
        private System.Windows.Forms.BindingSource tipoBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Button btnNuevoPokemon;
        private System.Windows.Forms.ContextMenuStrip cxtMenuPokemon;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerDetalles;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvPokedex;
    }
}
