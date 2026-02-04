namespace VerDocumentacion
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
            this.components = new System.ComponentModel.Container();
            this.btnAbrirCHM = new System.Windows.Forms.Button();
            this.btnAbrirHTML = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAbrirCHM
            // 
            this.btnAbrirCHM.Location = new System.Drawing.Point(80, 70);
            this.btnAbrirCHM.Name = "btnAbrirCHM";
            this.btnAbrirCHM.Size = new System.Drawing.Size(249, 70);
            this.btnAbrirCHM.TabIndex = 0;
            this.btnAbrirCHM.Text = "Abrir Documentacion CHM";
            this.toolTip1.SetToolTip(this.btnAbrirCHM, "Muestra la doc del proyecto");
            this.btnAbrirCHM.UseVisualStyleBackColor = true;
            this.btnAbrirCHM.Click += new System.EventHandler(this.btnAbrirCHM_Click);
            // 
            // btnAbrirHTML
            // 
            this.btnAbrirHTML.Location = new System.Drawing.Point(80, 167);
            this.btnAbrirHTML.Name = "btnAbrirHTML";
            this.btnAbrirHTML.Size = new System.Drawing.Size(249, 70);
            this.btnAbrirHTML.TabIndex = 1;
            this.btnAbrirHTML.Text = "Abrir Documentacion HTML";
            this.toolTip1.SetToolTip(this.btnAbrirHTML, "Muestra la web del proyecto");
            this.btnAbrirHTML.UseVisualStyleBackColor = true;
            this.btnAbrirHTML.Click += new System.EventHandler(this.btnAbrirHTML_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 385);
            this.Controls.Add(this.btnAbrirHTML);
            this.Controls.Add(this.btnAbrirCHM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCHM;
        private System.Windows.Forms.Button btnAbrirHTML;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

