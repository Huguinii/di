namespace Ejercicio9
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblCoste = new System.Windows.Forms.Label();
            this.lblNPaginas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAñoEdicion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNPaginas = new System.Windows.Forms.TextBox();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.txtAñoEdicion = new System.Windows.Forms.TextBox();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lsvLibros = new System.Windows.Forms.ListView();
            this.lstEstadistica = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(45, 43);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(46, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TÍTULO";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(45, 80);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(64, 13);
            this.lblEditorial.TabIndex = 1;
            this.lblEditorial.Text = "EDITORIAL";
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(45, 123);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(52, 13);
            this.lblCoste.TabIndex = 2;
            this.lblCoste.Text = "COSTE €";
            // 
            // lblNPaginas
            // 
            this.lblNPaginas.AutoSize = true;
            this.lblNPaginas.Location = new System.Drawing.Point(396, 43);
            this.lblNPaginas.Name = "lblNPaginas";
            this.lblNPaginas.Size = new System.Drawing.Size(69, 13);
            this.lblNPaginas.TabIndex = 3;
            this.lblNPaginas.Text = "Nº PÁGINAS";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(330, 80);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // lblAñoEdicion
            // 
            this.lblAñoEdicion.AutoSize = true;
            this.lblAñoEdicion.Location = new System.Drawing.Point(274, 123);
            this.lblAñoEdicion.Name = "lblAñoEdicion";
            this.lblAñoEdicion.Size = new System.Drawing.Size(77, 13);
            this.lblAñoEdicion.TabIndex = 5;
            this.lblAñoEdicion.Text = "AÑO EDICIÓN";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(97, 40);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(270, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtNPaginas
            // 
            this.txtNPaginas.Location = new System.Drawing.Point(471, 40);
            this.txtNPaginas.Name = "txtNPaginas";
            this.txtNPaginas.Size = new System.Drawing.Size(68, 20);
            this.txtNPaginas.TabIndex = 7;
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(103, 120);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(165, 20);
            this.txtCoste.TabIndex = 8;
            // 
            // txtAñoEdicion
            // 
            this.txtAñoEdicion.Location = new System.Drawing.Point(357, 120);
            this.txtAñoEdicion.Name = "txtAñoEdicion";
            this.txtAñoEdicion.Size = new System.Drawing.Size(81, 20);
            this.txtAñoEdicion.TabIndex = 11;
            // 
            // cbEditorial
            // 
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(116, 77);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(208, 21);
            this.cbEditorial.TabIndex = 12;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(405, 77);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(208, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(471, 123);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(568, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lsvLibros
            // 
            this.lsvLibros.GridLines = true;
            this.lsvLibros.HideSelection = false;
            this.lsvLibros.Location = new System.Drawing.Point(48, 177);
            this.lsvLibros.Name = "lsvLibros";
            this.lsvLibros.Size = new System.Drawing.Size(595, 119);
            this.lsvLibros.TabIndex = 17;
            this.lsvLibros.UseCompatibleStateImageBehavior = false;
            this.lsvLibros.View = System.Windows.Forms.View.Details;
            // 
            // lstEstadistica
            // 
            this.lstEstadistica.FormattingEnabled = true;
            this.lstEstadistica.Location = new System.Drawing.Point(48, 302);
            this.lstEstadistica.Name = "lstEstadistica";
            this.lstEstadistica.Size = new System.Drawing.Size(595, 121);
            this.lstEstadistica.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(685, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstEstadistica);
            this.Controls.Add(this.lsvLibros);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEditorial);
            this.Controls.Add(this.txtAñoEdicion);
            this.Controls.Add(this.txtCoste);
            this.Controls.Add(this.txtNPaginas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblAñoEdicion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNPaginas);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "CONTROL DE REGISTRO DE NUEVOS LIBROS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label lblNPaginas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAñoEdicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNPaginas;
        private System.Windows.Forms.TextBox txtCoste;
        private System.Windows.Forms.TextBox txtAñoEdicion;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lsvLibros;
        private System.Windows.Forms.ListBox lstEstadistica;
        private System.Windows.Forms.Button btnSalir;
    }
}

