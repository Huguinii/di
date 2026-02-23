namespace Ejercicio1_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSegundoForm = new System.Windows.Forms.Button();
            this.btnTercerForm = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTercerForm);
            this.groupBox1.Controls.Add(this.btnSegundoForm);
            this.groupBox1.Location = new System.Drawing.Point(113, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSegundoForm
            // 
            this.btnSegundoForm.Location = new System.Drawing.Point(118, 67);
            this.btnSegundoForm.Name = "btnSegundoForm";
            this.btnSegundoForm.Size = new System.Drawing.Size(182, 38);
            this.btnSegundoForm.TabIndex = 0;
            this.btnSegundoForm.Text = "Mostrar segundo formulario";
            this.btnSegundoForm.UseVisualStyleBackColor = true;
            this.btnSegundoForm.Click += new System.EventHandler(this.btnSegundoForm_Click);
            // 
            // btnTercerForm
            // 
            this.btnTercerForm.Location = new System.Drawing.Point(118, 177);
            this.btnTercerForm.Name = "btnTercerForm";
            this.btnTercerForm.Size = new System.Drawing.Size(182, 38);
            this.btnTercerForm.TabIndex = 1;
            this.btnTercerForm.Text = "Mostrar tercer formulario";
            this.btnTercerForm.UseVisualStyleBackColor = true;
            this.btnTercerForm.Click += new System.EventHandler(this.btnTercerForm_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(445, 387);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(182, 38);
            this.btnTerminar.TabIndex = 2;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTercerForm;
        private System.Windows.Forms.Button btnSegundoForm;
        private System.Windows.Forms.Button btnTerminar;
    }
}

