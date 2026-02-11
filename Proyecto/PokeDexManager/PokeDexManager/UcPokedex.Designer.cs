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
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPokemon = new System.Windows.Forms.Button();
            this.dgvPokedex = new System.Windows.Forms.DataGridView();
            this.NumeroPokedex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePokemonSimple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(263, 39);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(121, 21);
            this.cmbTipos.TabIndex = 1;
            this.cmbTipos.SelectedIndexChanged += new System.EventHandler(this.cmbTipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por tipo:";
            // 
            // btnNuevoPokemon
            // 
            this.btnNuevoPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoPokemon.BackColor = System.Drawing.Color.IndianRed;
            this.btnNuevoPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPokemon.Location = new System.Drawing.Point(501, 21);
            this.btnNuevoPokemon.Name = "btnNuevoPokemon";
            this.btnNuevoPokemon.Size = new System.Drawing.Size(174, 37);
            this.btnNuevoPokemon.TabIndex = 3;
            this.btnNuevoPokemon.Text = "Nuevo Pokemon";
            this.btnNuevoPokemon.UseVisualStyleBackColor = false;
            this.btnNuevoPokemon.Click += new System.EventHandler(this.btnNuevoPokemon_Click);
            // 
            // dgvPokedex
            // 
            this.dgvPokedex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokedex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPokedex,
            this.NombrePokemonSimple,
            this.FechaRegistro,
            this.Tipo});
            this.dgvPokedex.Location = new System.Drawing.Point(0, 64);
            this.dgvPokedex.Name = "dgvPokedex";
            this.dgvPokedex.Size = new System.Drawing.Size(800, 340);
            this.dgvPokedex.TabIndex = 0;
            // 
            // NumeroPokedex
            // 
            this.NumeroPokedex.HeaderText = "Numero Pokedex";
            this.NumeroPokedex.Name = "NumeroPokedex";
            // 
            // NombrePokemonSimple
            // 
            this.NombrePokemonSimple.HeaderText = "Nombre";
            this.NombrePokemonSimple.Name = "NombrePokemonSimple";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // UcPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnNuevoPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.dgvPokedex);
            this.Name = "UcPokedex";
            this.Size = new System.Drawing.Size(803, 407);
            this.Load += new System.EventHandler(this.UcPokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoPokemon;
        private System.Windows.Forms.DataGridView dgvPokedex;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPokedex;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePokemonSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
