namespace Ejercicio1
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
            this.btnFormHijo = new System.Windows.Forms.Button();
            this.btnCerrarArchivo = new System.Windows.Forms.Button();
            this.btnMostrarVerticalmente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormHijo
            // 
            this.btnFormHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormHijo.Location = new System.Drawing.Point(613, 300);
            this.btnFormHijo.Name = "btnFormHijo";
            this.btnFormHijo.Size = new System.Drawing.Size(84, 23);
            this.btnFormHijo.TabIndex = 0;
            this.btnFormHijo.Text = "Nuevo Hijo";
            this.btnFormHijo.UseVisualStyleBackColor = true;
            this.btnFormHijo.Click += new System.EventHandler(this.btnFormHijo_Click);
            // 
            // btnCerrarArchivo
            // 
            this.btnCerrarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarArchivo.Location = new System.Drawing.Point(613, 342);
            this.btnCerrarArchivo.Name = "btnCerrarArchivo";
            this.btnCerrarArchivo.Size = new System.Drawing.Size(96, 23);
            this.btnCerrarArchivo.TabIndex = 1;
            this.btnCerrarArchivo.Text = "Cerrar archivo";
            this.btnCerrarArchivo.UseVisualStyleBackColor = true;
            this.btnCerrarArchivo.Click += new System.EventHandler(this.btnCerrarArchivo_Click);
            // 
            // btnMostrarVerticalmente
            // 
            this.btnMostrarVerticalmente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarVerticalmente.Location = new System.Drawing.Point(613, 383);
            this.btnMostrarVerticalmente.Name = "btnMostrarVerticalmente";
            this.btnMostrarVerticalmente.Size = new System.Drawing.Size(140, 23);
            this.btnMostrarVerticalmente.TabIndex = 2;
            this.btnMostrarVerticalmente.Text = "MostrarVerticalmente";
            this.btnMostrarVerticalmente.UseVisualStyleBackColor = true;
            this.btnMostrarVerticalmente.Click += new System.EventHandler(this.btnMostrarVerticalmente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarVerticalmente);
            this.Controls.Add(this.btnCerrarArchivo);
            this.Controls.Add(this.btnFormHijo);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormHijo;
        private System.Windows.Forms.Button btnCerrarArchivo;
        private System.Windows.Forms.Button btnMostrarVerticalmente;
    }
}

