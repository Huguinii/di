namespace Ejemplo2Tema2
{
    partial class Ejercicio3Tema2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBorrarTodos = new System.Windows.Forms.Button();
            this.btnBorrarSeleccionado = new System.Windows.Forms.Button();
            this.txtSeleccionado = new System.Windows.Forms.TextBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(37, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Añadir";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(199, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.Location = new System.Drawing.Point(204, 61);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // lstNombres
            // 
            this.lstNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(49, 19);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstNombres.Size = new System.Drawing.Size(147, 212);
            this.lstNombres.TabIndex = 3;
            this.lstNombres.SelectedIndexChanged += new System.EventHandler(this.lstNombres_SelectedIndexChanged);
            this.lstNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNombres_KeyDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(288, 302);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBorrarTodos
            // 
            this.btnBorrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarTodos.Location = new System.Drawing.Point(204, 195);
            this.btnBorrarTodos.Name = "btnBorrarTodos";
            this.btnBorrarTodos.Size = new System.Drawing.Size(116, 23);
            this.btnBorrarTodos.TabIndex = 5;
            this.btnBorrarTodos.Text = "Borrar todos";
            this.btnBorrarTodos.UseVisualStyleBackColor = true;
            this.btnBorrarTodos.Click += new System.EventHandler(this.btnBorrarTodos_Click);
            // 
            // btnBorrarSeleccionado
            // 
            this.btnBorrarSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarSeleccionado.Location = new System.Drawing.Point(204, 166);
            this.btnBorrarSeleccionado.Name = "btnBorrarSeleccionado";
            this.btnBorrarSeleccionado.Size = new System.Drawing.Size(116, 23);
            this.btnBorrarSeleccionado.TabIndex = 6;
            this.btnBorrarSeleccionado.Text = "Borrar seleccionados";
            this.btnBorrarSeleccionado.UseVisualStyleBackColor = true;
            this.btnBorrarSeleccionado.Click += new System.EventHandler(this.btnBorrarSeleccionado_Click);
            // 
            // txtSeleccionado
            // 
            this.txtSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeleccionado.Location = new System.Drawing.Point(199, 118);
            this.txtSeleccionado.Name = "txtSeleccionado";
            this.txtSeleccionado.ReadOnly = true;
            this.txtSeleccionado.Size = new System.Drawing.Size(105, 20);
            this.txtSeleccionado.TabIndex = 7;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(199, 102);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(72, 13);
            this.lblSeleccionado.TabIndex = 8;
            this.lblSeleccionado.Text = "Seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNombres);
            this.groupBox1.Controls.Add(this.lblSeleccionado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtSeleccionado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnBorrarSeleccionado);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.btnBorrarTodos);
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 255);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Ejercicio3Tema2
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Ejercicio3Tema2";
            this.Text = "Ejercicio 3 - Tema 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBorrarTodos;
        private System.Windows.Forms.Button btnBorrarUno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrarSeleccionado;
        private System.Windows.Forms.TextBox txtSeleccionado;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

