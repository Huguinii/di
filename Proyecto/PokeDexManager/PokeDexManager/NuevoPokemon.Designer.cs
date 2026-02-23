namespace PokeDexManager
{
    partial class NuevoPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPokemon));
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.nudSalud = new System.Windows.Forms.NumericUpDown();
            this.nudAtaque = new System.Windows.Forms.NumericUpDown();
            this.nudDefensa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefensa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(121, 38);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(157, 20);
            this.lblEspecie.TabIndex = 0;
            this.lblEspecie.Text = "Especie Pokemon:";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalud.Location = new System.Drawing.Point(213, 127);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(65, 20);
            this.lblSalud.TabIndex = 1;
            this.lblSalud.Text = "Salud: ";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(226, 83);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(52, 20);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.Location = new System.Drawing.Point(206, 168);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(72, 20);
            this.lblAtaque.TabIndex = 3;
            this.lblAtaque.Text = "Ataque:";
            // 
            // lblDefensa
            // 
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensa.Location = new System.Drawing.Point(196, 209);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new System.Drawing.Size(82, 20);
            this.lblDefensa.TabIndex = 4;
            this.lblDefensa.Text = "Defensa:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(170, 293);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(293, 248);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipo.TabIndex = 6;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(226, 251);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 20);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(293, 36);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(201, 26);
            this.txtEspecie.TabIndex = 8;
            this.txtEspecie.TextChanged += new System.EventHandler(this.txtEspecie_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(293, 291);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 26);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(483, 348);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 32);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(293, 83);
            this.nudNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(120, 20);
            this.nudNivel.TabIndex = 15;
            this.nudNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSalud
            // 
            this.nudSalud.Location = new System.Drawing.Point(293, 127);
            this.nudSalud.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSalud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSalud.Name = "nudSalud";
            this.nudSalud.Size = new System.Drawing.Size(120, 20);
            this.nudSalud.TabIndex = 16;
            this.nudSalud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAtaque
            // 
            this.nudAtaque.Location = new System.Drawing.Point(294, 168);
            this.nudAtaque.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAtaque.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAtaque.Name = "nudAtaque";
            this.nudAtaque.Size = new System.Drawing.Size(120, 20);
            this.nudAtaque.TabIndex = 17;
            this.nudAtaque.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDefensa
            // 
            this.nudDefensa.Location = new System.Drawing.Point(294, 209);
            this.nudDefensa.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudDefensa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefensa.Name = "nudDefensa";
            this.nudDefensa.Size = new System.Drawing.Size(120, 20);
            this.nudDefensa.TabIndex = 18;
            this.nudDefensa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NuevoPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokeDexManager.Properties.Resources.capturaBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudDefensa);
            this.Controls.Add(this.nudAtaque);
            this.Controls.Add(this.nudSalud);
            this.Controls.Add(this.nudNivel);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDefensa);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.lblEspecie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoPokemon";
            this.Text = "NuevoPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown nudNivel;
        private System.Windows.Forms.NumericUpDown nudSalud;
        private System.Windows.Forms.NumericUpDown nudAtaque;
        private System.Windows.Forms.NumericUpDown nudDefensa;
    }
}