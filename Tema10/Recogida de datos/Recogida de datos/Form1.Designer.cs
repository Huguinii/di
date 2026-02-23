namespace Recogida_de_datos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSoltero = new System.Windows.Forms.RadioButton();
            this.radioButtonCasado = new System.Windows.Forms.RadioButton();
            this.radioButtonOtros = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDisponibilidad = new System.Windows.Forms.CheckBox();
            this.checkBoxVehiculoPropio = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(46, 85);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(123, 85);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(195, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOtros);
            this.groupBox1.Controls.Add(this.radioButtonCasado);
            this.groupBox1.Controls.Add(this.radioButtonSoltero);
            this.groupBox1.Location = new System.Drawing.Point(33, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado civil";
            // 
            // radioButtonSoltero
            // 
            this.radioButtonSoltero.AutoSize = true;
            this.radioButtonSoltero.Location = new System.Drawing.Point(16, 19);
            this.radioButtonSoltero.Name = "radioButtonSoltero";
            this.radioButtonSoltero.Size = new System.Drawing.Size(58, 17);
            this.radioButtonSoltero.TabIndex = 0;
            this.radioButtonSoltero.TabStop = true;
            this.radioButtonSoltero.Text = "Soltero";
            this.radioButtonSoltero.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            this.radioButtonCasado.AutoSize = true;
            this.radioButtonCasado.Location = new System.Drawing.Point(16, 42);
            this.radioButtonCasado.Name = "radioButtonCasado";
            this.radioButtonCasado.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCasado.TabIndex = 1;
            this.radioButtonCasado.TabStop = true;
            this.radioButtonCasado.Text = "Casado";
            this.radioButtonCasado.UseVisualStyleBackColor = true;
            // 
            // radioButtonOtros
            // 
            this.radioButtonOtros.AutoSize = true;
            this.radioButtonOtros.Location = new System.Drawing.Point(16, 65);
            this.radioButtonOtros.Name = "radioButtonOtros";
            this.radioButtonOtros.Size = new System.Drawing.Size(50, 17);
            this.radioButtonOtros.TabIndex = 2;
            this.radioButtonOtros.TabStop = true;
            this.radioButtonOtros.Text = "Otros";
            this.radioButtonOtros.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxVehiculoPropio);
            this.groupBox2.Controls.Add(this.checkBoxDisponibilidad);
            this.groupBox2.Location = new System.Drawing.Point(247, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxDisponibilidad
            // 
            this.checkBoxDisponibilidad.AutoSize = true;
            this.checkBoxDisponibilidad.Location = new System.Drawing.Point(31, 19);
            this.checkBoxDisponibilidad.Name = "checkBoxDisponibilidad";
            this.checkBoxDisponibilidad.Size = new System.Drawing.Size(143, 17);
            this.checkBoxDisponibilidad.TabIndex = 0;
            this.checkBoxDisponibilidad.Text = "Disponibilidad para viajar";
            this.checkBoxDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // checkBoxVehiculoPropio
            // 
            this.checkBoxVehiculoPropio.AutoSize = true;
            this.checkBoxVehiculoPropio.Location = new System.Drawing.Point(31, 66);
            this.checkBoxVehiculoPropio.Name = "checkBoxVehiculoPropio";
            this.checkBoxVehiculoPropio.Size = new System.Drawing.Size(100, 17);
            this.checkBoxVehiculoPropio.TabIndex = 1;
            this.checkBoxVehiculoPropio.Text = "Vehiculo Propio";
            this.checkBoxVehiculoPropio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(378, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 321);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Recogida de datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOtros;
        private System.Windows.Forms.RadioButton radioButtonCasado;
        private System.Windows.Forms.RadioButton radioButtonSoltero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxVehiculoPropio;
        private System.Windows.Forms.CheckBox checkBoxDisponibilidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}

