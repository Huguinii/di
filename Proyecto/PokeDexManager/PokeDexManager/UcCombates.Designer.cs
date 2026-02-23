namespace PokeDexManager
{
    partial class UcCombates
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
            this.cmbPokemon1 = new System.Windows.Forms.ComboBox();
            this.cmbPokemon2 = new System.Windows.Forms.ComboBox();
            this.btnPelea = new System.Windows.Forms.Button();
            this.dgvCombates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombates)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPokemon1
            // 
            this.cmbPokemon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPokemon1.FormattingEnabled = true;
            this.cmbPokemon1.Location = new System.Drawing.Point(118, 33);
            this.cmbPokemon1.Name = "cmbPokemon1";
            this.cmbPokemon1.Size = new System.Drawing.Size(176, 28);
            this.cmbPokemon1.TabIndex = 0;
            // 
            // cmbPokemon2
            // 
            this.cmbPokemon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPokemon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPokemon2.FormattingEnabled = true;
            this.cmbPokemon2.Location = new System.Drawing.Point(649, 33);
            this.cmbPokemon2.Name = "cmbPokemon2";
            this.cmbPokemon2.Size = new System.Drawing.Size(176, 28);
            this.cmbPokemon2.TabIndex = 1;
            // 
            // btnPelea
            // 
            this.btnPelea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPelea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelea.Location = new System.Drawing.Point(418, 33);
            this.btnPelea.Name = "btnPelea";
            this.btnPelea.Size = new System.Drawing.Size(108, 39);
            this.btnPelea.TabIndex = 2;
            this.btnPelea.Text = "Pelea";
            this.btnPelea.UseVisualStyleBackColor = true;
            this.btnPelea.Click += new System.EventHandler(this.btnPelea_Click);
            // 
            // dgvCombates
            // 
            this.dgvCombates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCombates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCombates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombates.Location = new System.Drawing.Point(3, 172);
            this.dgvCombates.Name = "dgvCombates";
            this.dgvCombates.Size = new System.Drawing.Size(932, 257);
            this.dgvCombates.TabIndex = 3;
            this.dgvCombates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCombates_CellClick);
            // 
            // UcCombates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokeDexManager.Properties.Resources.campoBatalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvCombates);
            this.Controls.Add(this.btnPelea);
            this.Controls.Add(this.cmbPokemon2);
            this.Controls.Add(this.cmbPokemon1);
            this.DoubleBuffered = true;
            this.Name = "UcCombates";
            this.Size = new System.Drawing.Size(938, 432);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPokemon1;
        private System.Windows.Forms.ComboBox cmbPokemon2;
        private System.Windows.Forms.Button btnPelea;
        private System.Windows.Forms.DataGridView dgvCombates;
    }
}
