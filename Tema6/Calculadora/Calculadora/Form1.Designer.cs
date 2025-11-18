namespace Calculadora
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
            this.txtPrimerOperando = new System.Windows.Forms.TextBox();
            this.txtSegundoOperando = new System.Windows.Forms.TextBox();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrimerOperando
            // 
            this.txtPrimerOperando.Location = new System.Drawing.Point(84, 65);
            this.txtPrimerOperando.Name = "txtPrimerOperando";
            this.txtPrimerOperando.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerOperando.TabIndex = 0;
            // 
            // txtSegundoOperando
            // 
            this.txtSegundoOperando.Location = new System.Drawing.Point(306, 66);
            this.txtSegundoOperando.Name = "txtSegundoOperando";
            this.txtSegundoOperando.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoOperando.TabIndex = 2;
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Location = new System.Drawing.Point(190, 65);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(110, 21);
            this.cboOperacion.TabIndex = 3;
            this.cboOperacion.SelectedIndexChanged += new System.EventHandler(this.cboOperacion_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(84, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(322, 51);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(412, 68);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(431, 68);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.txtSegundoOperando);
            this.Controls.Add(this.txtPrimerOperando);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimerOperando;
        private System.Windows.Forms.TextBox txtSegundoOperando;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

