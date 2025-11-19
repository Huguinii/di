using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio9
{
    

    public partial class Form1 : Form
    {

        public struct Libro
        {
            public string Titulo { get; set; }
            public string Editorial { get; set; }
            public string Categoria { get; set; }
            public int Edicion { get; set; }
            public int Paginas { get; set; }
            public double Coste { get; set; }

            public Libro(string titulo, string editorial, string categoria, int edicion, int paginas, double coste)
            {
                Titulo = titulo;
                Editorial = editorial;
                Categoria = categoria;
                Edicion = edicion;
                Paginas = paginas;
                Coste = coste;
            }
        }

        private List<Libro> libros = new List<Libro>();
        private Dictionary<string, int> dcCategorias;
        private Dictionary<string, double> dcCosteAcumulado;
        private readonly string[] categorias = { "Superacion personal", "Literatura", "Ciencias", "Informatica"};
        private readonly string[] editoriales = { "Anagrama", "Asteroide", "Garceta", "Malpaso",
            "Marcomo", "Planeta", "RA-MA", "Seix Barral" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libros = new List<Libro>();
            inicializarDiccionarios();
            inicializarComponentes();
        }

        public void inicializarDiccionarios()
        {
            dcCategorias = new Dictionary<string, int>();
            dcCosteAcumulado = new Dictionary<string, double>();

            for (int i = 0; i < categorias.Length; i++)
            {
                dcCategorias.Add(categorias[i], 0);
            }

            for (int i = 0; i < editoriales.Length; i++)
            {
                dcCosteAcumulado.Add(editoriales[i], 0);
            }
        }

        private void inicializarComponentes()
        {
            MaximizeBox = false;
            txtTitulo.Focus();

            lsvLibros.Columns.Add("TÍTULO", -2, HorizontalAlignment.Center);
            lsvLibros.Columns.Add("EDITORIAL", -2, HorizontalAlignment.Center);
            lsvLibros.Columns.Add("CATEGORIA", -2, HorizontalAlignment.Center);
            lsvLibros.Columns.Add("EDICION", -2, HorizontalAlignment.Center);
            lsvLibros.Columns.Add("PAGINAS", -2, HorizontalAlignment.Center);
            lsvLibros.Columns.Add("COSTE", -2, HorizontalAlignment.Center);

            cbCategoria.Items.AddRange(categorias);
            cbEditorial.Items.AddRange(editoriales);

            cbCategoria.SelectedItem = cbCategoria.Items[0];
            cbEditorial.SelectedItem = cbEditorial.Items[0];

        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtNPaginas.Clear();
            txtCoste.Clear();
            txtAñoEdicion.Clear();

            txtTitulo.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            if (!titulo.Equals(""))
            {
                try
                {
                    Double coste = double.Parse(txtCoste.Text.Trim());
                    int numPag = int.Parse(txtNPaginas.Text.Trim());
                    int edicion = int.Parse(txtAñoEdicion.Text.Trim());
                    string editorial = (string)cbEditorial.SelectedItem;
                    string categoria = (string)cbCategoria.SelectedItem;

                    Libro libro = new Libro(titulo, editorial, categoria, edicion, numPag, coste);
                    insertarLibro(libro);
                    
                    actualizarDatos(libro);

                    limpiar();

                    rellenarListBox();

                }catch (Exception ex)
                {

                }
            }
        }
        private void insertarLibro(Libro libro)
        {
            ListViewItem item = new ListViewItem(libro.Titulo);
            item.SubItems.Add(libro.Editorial);
            item.SubItems.Add(libro.Categoria);
            item.SubItems.Add(libro.Edicion.ToString());
            item.SubItems.Add(libro.Paginas.ToString());
            item.SubItems.Add(libro.Coste.ToString("#.00"));

            lsvLibros.Items.Add(item);
        }

        private void actualizarDatos(Libro libro)
        {
            libros.Add(libro);
            dcCategorias[libro.Categoria] += 1;
            dcCosteAcumulado[libro.Editorial] += libro.Coste;

        }

        private void rellenarListBox()
        {
            lstEstadistica.Items.Clear();

            lstEstadistica.Items.Add("-- ESTADISTICA DE REGISTRO DE LOS LIBROS --");
            lstEstadistica.Items.Add("NUMERO DE LIBROS POR CATEGORIA:");

            foreach(string entrada in dcCategorias.Keys)
            {
                dcCategorias.TryGetValue(entrada, out int valor);
                lstEstadistica.Items.Add(entrada.ToUpper() + ": " + valor);
            }

            lstEstadistica.Items.Add("-----------------------------");

            lstEstadistica.Items.Add("LIBRO DE MAYOR COSTE: ");

            double mayorCoste = 0;
            int menorNumPag = libros[0].Paginas;
            string tituloMasCaro = "";
            string tituloMenosPag = "";

            foreach(Libro libro in libros)
            {
                if(libro.Coste >= mayorCoste)
                {
                    mayorCoste = libro.Coste;
                    tituloMasCaro = libro.Titulo;
                }
                if (libro.Paginas <= menorNumPag)
                {
                    menorNumPag = libro.Paginas;
                    tituloMenosPag = libro.Titulo;
                }
            }
            lstEstadistica.Items.Add(tituloMasCaro);

            lstEstadistica.Items.Add("-----------------------------");
            
            lstEstadistica.Items.Add("LIBRO CON MENOR NUMERO DE PAGINAS: ");
            lstEstadistica.Items.Add(tituloMenosPag);

            lstEstadistica.Items.Add("-----------------------------");

            foreach (string entrada in dcCosteAcumulado.Keys)
            {
                dcCosteAcumulado.TryGetValue(entrada, out double valor);
                lstEstadistica.Items.Add("COSTE ACUMULADO " + entrada.ToUpper() + ": "
                    + valor.ToString("0.00") + "€");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
