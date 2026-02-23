namespace Ejemplo1
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.btnmostrar2formulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmostrar2formulario
            // 
            this.btnmostrar2formulario.BackgroundImage = global::Ejemplo1.Properties.Resources.images;
            this.btnmostrar2formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmostrar2formulario.Font = new System.Drawing.Font("Mistral", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar2formulario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnmostrar2formulario.Location = new System.Drawing.Point(0, -3);
            this.btnmostrar2formulario.Name = "btnmostrar2formulario";
            this.btnmostrar2formulario.Size = new System.Drawing.Size(179, 269);
            this.btnmostrar2formulario.TabIndex = 0;
            this.btnmostrar2formulario.Text = "Mostrar 2ºFormulario";
            this.btnmostrar2formulario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmostrar2formulario.UseVisualStyleBackColor = true;
            this.btnmostrar2formulario.Click += new System.EventHandler(this.btnmostrar2formulario_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejemplo1.Properties.Resources.e41c8296fb6b2969ed8a11aa8cc9a367;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(889, 500);
            this.Controls.Add(this.btnmostrar2formulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmostrar2formulario;
    }
}

