namespace Biblioteca_Hugo
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
            this.dGVGestion = new System.Windows.Forms.DataGridView();
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniopublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Biblioteca_Hugo.BibliotecaDataSet();
            this.librosTableAdapter = new Biblioteca_Hugo.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.btnAñadirLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtAnioPublicacion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblAnioPublicacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbControlGestion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAutores = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibroABuscar = new System.Windows.Forms.TextBox();
            this.dGVBusqueda = new System.Windows.Forms.DataGridView();
            this.idlibroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniopublicacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuarios = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCrearPrestamo = new System.Windows.Forms.Button();
            this.lblUsuarioAPrestar = new System.Windows.Forms.Label();
            this.lblLibroPrestado = new System.Windows.Forms.Label();
            this.cBoxUsuarioPrestado = new System.Windows.Forms.ComboBox();
            this.cBoxLibroPrestado = new System.Windows.Forms.ComboBox();
            this.librosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new Biblioteca_Hugo.BibliotecaDataSetTableAdapters.AutoresTableAdapter();
            this.bibliotecaDataSet1 = new Biblioteca_Hugo.BibliotecaDataSet1();
            this.bibliotecaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter1 = new Biblioteca_Hugo.BibliotecaDataSet1TableAdapters.AutoresTableAdapter();
            this.usuariosTableAdapter = new Biblioteca_Hugo.BibliotecaDataSetTableAdapters.UsuariosTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Biblioteca_Hugo.BibliotecaDataSetTableAdapters.PrestamosTableAdapter();
            this.idprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlibroDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbControlGestion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVGestion
            // 
            this.dGVGestion.AllowUserToAddRows = false;
            this.dGVGestion.AutoGenerateColumns = false;
            this.dGVGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.idautorDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.aniopublicacionDataGridViewTextBoxColumn});
            this.dGVGestion.DataSource = this.librosBindingSource;
            this.dGVGestion.Location = new System.Drawing.Point(13, 19);
            this.dGVGestion.Name = "dGVGestion";
            this.dGVGestion.Size = new System.Drawing.Size(576, 217);
            this.dGVGestion.TabIndex = 1;
            // 
            // idlibroDataGridViewTextBoxColumn
            // 
            this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.HeaderText = "id_libro";
            this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
            this.idlibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idautorDataGridViewTextBoxColumn
            // 
            this.idautorDataGridViewTextBoxColumn.DataPropertyName = "id_autor";
            this.idautorDataGridViewTextBoxColumn.HeaderText = "id_autor";
            this.idautorDataGridViewTextBoxColumn.Name = "idautorDataGridViewTextBoxColumn";
            this.idautorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniopublicacionDataGridViewTextBoxColumn
            // 
            this.aniopublicacionDataGridViewTextBoxColumn.DataPropertyName = "anio_publicacion";
            this.aniopublicacionDataGridViewTextBoxColumn.HeaderText = "anio_publicacion";
            this.aniopublicacionDataGridViewTextBoxColumn.Name = "aniopublicacionDataGridViewTextBoxColumn";
            this.aniopublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAñadirLibro
            // 
            this.btnAñadirLibro.Location = new System.Drawing.Point(28, 251);
            this.btnAñadirLibro.Name = "btnAñadirLibro";
            this.btnAñadirLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirLibro.TabIndex = 2;
            this.btnAñadirLibro.Text = "Añadir";
            this.btnAñadirLibro.UseVisualStyleBackColor = true;
            this.btnAñadirLibro.Click += new System.EventHandler(this.btnAñadirLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(192, 251);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibro.TabIndex = 3;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.Location = new System.Drawing.Point(357, 251);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnModificarLibro.TabIndex = 4;
            this.btnModificarLibro.Text = "Modificar";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(108, 288);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Location = new System.Drawing.Point(108, 314);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(100, 20);
            this.txtIdAutor.TabIndex = 6;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(108, 340);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 7;
            // 
            // txtAnioPublicacion
            // 
            this.txtAnioPublicacion.Location = new System.Drawing.Point(108, 366);
            this.txtAnioPublicacion.Name = "txtAnioPublicacion";
            this.txtAnioPublicacion.Size = new System.Drawing.Size(100, 20);
            this.txtAnioPublicacion.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(35, 291);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(35, 321);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(44, 13);
            this.lblIdAutor.TabIndex = 10;
            this.lblIdAutor.Text = "Id Autor";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(35, 347);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(27, 13);
            this.lblIsbn.TabIndex = 11;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblAnioPublicacion
            // 
            this.lblAnioPublicacion.AutoSize = true;
            this.lblAnioPublicacion.Location = new System.Drawing.Point(18, 369);
            this.lblAnioPublicacion.Name = "lblAnioPublicacion";
            this.lblAnioPublicacion.Size = new System.Drawing.Size(84, 13);
            this.lblAnioPublicacion.TabIndex = 12;
            this.lblAnioPublicacion.Text = "Año Publicacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVGestion);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.lblIdAutor);
            this.groupBox1.Controls.Add(this.lblIsbn);
            this.groupBox1.Controls.Add(this.lblAnioPublicacion);
            this.groupBox1.Controls.Add(this.btnModificarLibro);
            this.groupBox1.Controls.Add(this.btnEliminarLibro);
            this.groupBox1.Controls.Add(this.btnAñadirLibro);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtAnioPublicacion);
            this.groupBox1.Controls.Add(this.txtIdAutor);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 396);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbControlGestion
            // 
            this.tbControlGestion.Controls.Add(this.tabPage1);
            this.tbControlGestion.Controls.Add(this.tabPage2);
            this.tbControlGestion.Controls.Add(this.tabPage3);
            this.tbControlGestion.Controls.Add(this.tabPage4);
            this.tbControlGestion.Location = new System.Drawing.Point(50, 12);
            this.tbControlGestion.Name = "tbControlGestion";
            this.tbControlGestion.SelectedIndex = 0;
            this.tbControlGestion.Size = new System.Drawing.Size(679, 426);
            this.tbControlGestion.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestión de Libros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarAutor);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboxAutores);
            this.tabPage2.Controls.Add(this.btnBuscarLibro);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtLibroABuscar);
            this.tabPage2.Controls.Add(this.dGVBusqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Búsqueda de libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(559, 374);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarAutor.TabIndex = 6;
            this.btnBuscarAutor.Text = "BuscarPorAutor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor del Libro";
            // 
            // cboxAutores
            // 
            this.cboxAutores.DataSource = this.autoresBindingSource;
            this.cboxAutores.DisplayMember = "nombre";
            this.cboxAutores.FormattingEnabled = true;
            this.cboxAutores.Location = new System.Drawing.Point(463, 349);
            this.cboxAutores.Name = "cboxAutores";
            this.cboxAutores.Size = new System.Drawing.Size(121, 21);
            this.cboxAutores.TabIndex = 4;
            this.cboxAutores.ValueMember = "nombre";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(253, 347);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 3;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título del Libro";
            // 
            // txtLibroABuscar
            // 
            this.txtLibroABuscar.Location = new System.Drawing.Point(120, 351);
            this.txtLibroABuscar.Name = "txtLibroABuscar";
            this.txtLibroABuscar.Size = new System.Drawing.Size(100, 20);
            this.txtLibroABuscar.TabIndex = 1;
            // 
            // dGVBusqueda
            // 
            this.dGVBusqueda.AllowUserToAddRows = false;
            this.dGVBusqueda.AutoGenerateColumns = false;
            this.dGVBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibroDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.idautorDataGridViewTextBoxColumn1,
            this.isbnDataGridViewTextBoxColumn1,
            this.aniopublicacionDataGridViewTextBoxColumn1});
            this.dGVBusqueda.DataSource = this.librosBindingSource2;
            this.dGVBusqueda.Location = new System.Drawing.Point(58, 21);
            this.dGVBusqueda.Name = "dGVBusqueda";
            this.dGVBusqueda.Size = new System.Drawing.Size(567, 314);
            this.dGVBusqueda.TabIndex = 0;
            // 
            // idlibroDataGridViewTextBoxColumn1
            // 
            this.idlibroDataGridViewTextBoxColumn1.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn1.HeaderText = "id_libro";
            this.idlibroDataGridViewTextBoxColumn1.Name = "idlibroDataGridViewTextBoxColumn1";
            this.idlibroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            // 
            // idautorDataGridViewTextBoxColumn1
            // 
            this.idautorDataGridViewTextBoxColumn1.DataPropertyName = "id_autor";
            this.idautorDataGridViewTextBoxColumn1.HeaderText = "id_autor";
            this.idautorDataGridViewTextBoxColumn1.Name = "idautorDataGridViewTextBoxColumn1";
            // 
            // isbnDataGridViewTextBoxColumn1
            // 
            this.isbnDataGridViewTextBoxColumn1.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn1.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn1.Name = "isbnDataGridViewTextBoxColumn1";
            // 
            // aniopublicacionDataGridViewTextBoxColumn1
            // 
            this.aniopublicacionDataGridViewTextBoxColumn1.DataPropertyName = "anio_publicacion";
            this.aniopublicacionDataGridViewTextBoxColumn1.HeaderText = "anio_publicacion";
            this.aniopublicacionDataGridViewTextBoxColumn1.Name = "aniopublicacionDataGridViewTextBoxColumn1";
            // 
            // librosBindingSource2
            // 
            this.librosBindingSource2.DataMember = "Libros";
            this.librosBindingSource2.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminarUsuario);
            this.tabPage3.Controls.Add(this.btnActualizarUsuarios);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(319, 338);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(175, 338);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuarios.TabIndex = 1;
            this.btnActualizarUsuarios.Text = "Actualizar";
            this.btnActualizarUsuarios.UseVisualStyleBackColor = true;
            this.btnActualizarUsuarios.Click += new System.EventHandler(this.btnActualizarUsuarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.fecharegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.btnCrearPrestamo);
            this.tabPage4.Controls.Add(this.lblUsuarioAPrestar);
            this.tabPage4.Controls.Add(this.lblLibroPrestado);
            this.tabPage4.Controls.Add(this.cBoxUsuarioPrestado);
            this.tabPage4.Controls.Add(this.cBoxLibroPrestado);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(671, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Préstamos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCrearPrestamo
            // 
            this.btnCrearPrestamo.Location = new System.Drawing.Point(277, 319);
            this.btnCrearPrestamo.Name = "btnCrearPrestamo";
            this.btnCrearPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPrestamo.TabIndex = 9;
            this.btnCrearPrestamo.Text = "Prestar";
            this.btnCrearPrestamo.UseVisualStyleBackColor = true;
            this.btnCrearPrestamo.Click += new System.EventHandler(this.btnCrearPrestamo_Click);
            // 
            // lblUsuarioAPrestar
            // 
            this.lblUsuarioAPrestar.AutoSize = true;
            this.lblUsuarioAPrestar.Location = new System.Drawing.Point(382, 264);
            this.lblUsuarioAPrestar.Name = "lblUsuarioAPrestar";
            this.lblUsuarioAPrestar.Size = new System.Drawing.Size(88, 13);
            this.lblUsuarioAPrestar.TabIndex = 8;
            this.lblUsuarioAPrestar.Text = "Usuario a Prestar";
            // 
            // lblLibroPrestado
            // 
            this.lblLibroPrestado.AutoSize = true;
            this.lblLibroPrestado.Location = new System.Drawing.Point(169, 264);
            this.lblLibroPrestado.Name = "lblLibroPrestado";
            this.lblLibroPrestado.Size = new System.Drawing.Size(75, 13);
            this.lblLibroPrestado.TabIndex = 7;
            this.lblLibroPrestado.Text = "Libro a Prestar";
            // 
            // cBoxUsuarioPrestado
            // 
            this.cBoxUsuarioPrestado.DataSource = this.usuariosBindingSource;
            this.cBoxUsuarioPrestado.DisplayMember = "nombre";
            this.cBoxUsuarioPrestado.FormattingEnabled = true;
            this.cBoxUsuarioPrestado.Location = new System.Drawing.Point(368, 283);
            this.cBoxUsuarioPrestado.Name = "cBoxUsuarioPrestado";
            this.cBoxUsuarioPrestado.Size = new System.Drawing.Size(121, 21);
            this.cBoxUsuarioPrestado.TabIndex = 6;
            this.cBoxUsuarioPrestado.ValueMember = "nombre";
            // 
            // cBoxLibroPrestado
            // 
            this.cBoxLibroPrestado.DataSource = this.librosBindingSource;
            this.cBoxLibroPrestado.DisplayMember = "titulo";
            this.cBoxLibroPrestado.FormattingEnabled = true;
            this.cBoxLibroPrestado.Location = new System.Drawing.Point(147, 283);
            this.cBoxLibroPrestado.Name = "cBoxLibroPrestado";
            this.cBoxLibroPrestado.Size = new System.Drawing.Size(121, 21);
            this.cBoxLibroPrestado.TabIndex = 5;
            this.cBoxLibroPrestado.ValueMember = "titulo";
            // 
            // librosBindingSource1
            // 
            this.librosBindingSource1.DataMember = "Libros";
            this.librosBindingSource1.DataSource = this.bibliotecaDataSet;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet1";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSet1BindingSource
            // 
            this.bibliotecaDataSet1BindingSource.DataSource = this.bibliotecaDataSet1;
            this.bibliotecaDataSet1BindingSource.Position = 0;
            // 
            // autoresBindingSource1
            // 
            this.autoresBindingSource1.DataMember = "Autores";
            this.autoresBindingSource1.DataSource = this.bibliotecaDataSet1BindingSource;
            // 
            // autoresTableAdapter1
            // 
            this.autoresTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprestamoDataGridViewTextBoxColumn,
            this.idlibroDataGridViewTextBoxColumn2,
            this.idusuarioDataGridViewTextBoxColumn1,
            this.fechaprestamoDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.prestamosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(46, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 209);
            this.dataGridView2.TabIndex = 10;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // idprestamoDataGridViewTextBoxColumn
            // 
            this.idprestamoDataGridViewTextBoxColumn.DataPropertyName = "id_prestamo";
            this.idprestamoDataGridViewTextBoxColumn.HeaderText = "id_prestamo";
            this.idprestamoDataGridViewTextBoxColumn.Name = "idprestamoDataGridViewTextBoxColumn";
            this.idprestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idlibroDataGridViewTextBoxColumn2
            // 
            this.idlibroDataGridViewTextBoxColumn2.DataPropertyName = "id_libro";
            this.idlibroDataGridViewTextBoxColumn2.HeaderText = "id_libro";
            this.idlibroDataGridViewTextBoxColumn2.Name = "idlibroDataGridViewTextBoxColumn2";
            // 
            // idusuarioDataGridViewTextBoxColumn1
            // 
            this.idusuarioDataGridViewTextBoxColumn1.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn1.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn1.Name = "idusuarioDataGridViewTextBoxColumn1";
            // 
            // fechaprestamoDataGridViewTextBoxColumn
            // 
            this.fechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.HeaderText = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.Name = "fechaprestamoDataGridViewTextBoxColumn";
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControlGestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbControlGestion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVGestion;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniopublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAñadirLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtAnioPublicacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdAutor;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblAnioPublicacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbControlGestion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtLibroABuscar;
        private System.Windows.Forms.DataGridView dGVBusqueda;
        private System.Windows.Forms.BindingSource librosBindingSource1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.ComboBox cboxAutores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BibliotecaDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.BindingSource bibliotecaDataSet1BindingSource;
        private BibliotecaDataSet1 bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource autoresBindingSource1;
        private BibliotecaDataSet1TableAdapters.AutoresTableAdapter autoresTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniopublicacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource librosBindingSource2;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotecaDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblUsuarioAPrestar;
        private System.Windows.Forms.Label lblLibroPrestado;
        private System.Windows.Forms.ComboBox cBoxUsuarioPrestado;
        private System.Windows.Forms.ComboBox cBoxLibroPrestado;
        private System.Windows.Forms.Button btnCrearPrestamo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private BibliotecaDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibroDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
    }
}

