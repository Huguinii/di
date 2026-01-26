namespace EjercicioListaImagenes
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.btnImagenes = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "redonda.jpg");
            this.listaImagenes.Images.SetKeyName(1, "portales.jpg");
            this.listaImagenes.Images.SetKeyName(2, "puentepiedra.jpg");
            this.listaImagenes.Images.SetKeyName(3, "plazamercado.jpg");
            this.listaImagenes.Images.SetKeyName(4, "images.jpg");
            // 
            // btnImagenes
            // 
            this.btnImagenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImagenes.Location = new System.Drawing.Point(0, 455);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(824, 60);
            this.btnImagenes.TabIndex = 0;
            this.btnImagenes.Text = "Imágenes";
            this.btnImagenes.UseVisualStyleBackColor = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(824, 455);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // barraEstado
            // 
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBarraEstado});
            this.barraEstado.Location = new System.Drawing.Point(0, 431);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(824, 24);
            this.barraEstado.TabIndex = 2;
            this.barraEstado.Text = "statusStrip1";
            // 
            // lblBarraEstado
            // 
            this.lblBarraEstado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblBarraEstado.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.lblBarraEstado.Name = "lblBarraEstado";
            this.lblBarraEstado.Size = new System.Drawing.Size(77, 19);
            this.lblBarraEstado.Text = "MiPrograma";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 515);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnImagenes);
            this.Name = "formPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblBarraEstado;
    }
}

