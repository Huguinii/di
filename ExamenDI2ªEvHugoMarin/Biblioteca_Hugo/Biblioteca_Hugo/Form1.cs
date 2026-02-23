using Biblioteca_Hugo.BibliotecaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Hugo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.prestamosTableAdapter.Fill(this.bibliotecaDataSet.Prestamos);
            this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);
            this.autoresTableAdapter1.Fill(this.bibliotecaDataSet1.Autores);
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);
            
        }

        private void btnAñadirLibro_Click(object sender, EventArgs e)
        {
            DataRow fila = bibliotecaDataSet.Tables["Libros"].NewRow();
            fila["titulo"] = txtTitulo.Text;
            fila["id_autor"] = txtIdAutor.Text;
            fila["isbn"] = txtIsbn.Text;
            fila["anio_publicacion"] = txtAnioPublicacion.Text;
            bibliotecaDataSet.Tables["Libros"].Rows.Add(fila);

            librosTableAdapter.Update(bibliotecaDataSet);

            librosTableAdapter.Fill(bibliotecaDataSet.Libros);
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            librosBindingSource.RemoveCurrent();
            librosTableAdapter.Update(bibliotecaDataSet);
            librosTableAdapter.Fill(bibliotecaDataSet.Libros);
        }

        //Deberia modificar pero no sé porque al hacer click en la row no deja escribir
        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            librosBindingSource.EndEdit();
            librosTableAdapter.Update(bibliotecaDataSet);
            librosTableAdapter.Fill(bibliotecaDataSet.Libros);
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
        
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "select * from Libros where titulo like '%' + @Titulo + '%'";
            consulta.Connection = librosTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Titulo", txtLibroABuscar.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "LibroBuscado");
            dGVBusqueda.DataSource = ds;
            dGVBusqueda.DataMember = "LibroBuscado";

        }
        
        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            SqlCommand busquedaAutor = new SqlCommand();
            busquedaAutor.CommandText = "SELECT * " +
                "FROM Autores INNER JOIN Libros ON Autores.id_autor = Libros.id_autor " +
                "where Autores.nombre like '%' + @Autor + '%'";
            busquedaAutor.Connection = librosTableAdapter.Connection;
            busquedaAutor.Connection = autoresTableAdapter.Connection;
            busquedaAutor.Parameters.AddWithValue("@Autor", cboxAutores.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter(busquedaAutor);
            DataSet ds = new DataSet();
            da.Fill(ds, "LibrosPorAutor");
            dGVBusqueda.DataSource = ds;
            dGVBusqueda.DataMember = "LibrosPorAutor";
        }

        private void btnActualizarUsuarios_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.EndEdit();
            usuariosTableAdapter.Update(bibliotecaDataSet);
            usuariosTableAdapter.Fill(bibliotecaDataSet.Usuarios);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.RemoveCurrent();
            usuariosTableAdapter.Update(bibliotecaDataSet);
            usuariosTableAdapter.Fill(bibliotecaDataSet.Usuarios);
        }

        private void btnCrearPrestamo_Click(object sender, EventArgs e)
        {
            string libroPrestado = cBoxLibroPrestado.SelectedValue.ToString();
            string usuarioPrestado = cBoxUsuarioPrestado.SelectedValue.ToString();
            SqlCommand crearPrestamo = new SqlCommand();
            
            crearPrestamo.CommandText = "INSERT INTO Prestamos (id_usuario, id_libro, fecha_prestamo)" +
                "SELECT Usuarios.id_usuario, Libros.id_libro, '28/01/2027' FROM Usuarios CROSS JOIN Libros" +
                " where id_usuario like '%' + @usuario + '%', id_libro like '%' + @libro + '%'";
            crearPrestamo.Connection = librosTableAdapter.Connection;
            crearPrestamo.Connection = usuariosTableAdapter.Connection;
            crearPrestamo.Connection = prestamosTableAdapter.Connection;
            crearPrestamo.Parameters.AddWithValue("@libro", libroPrestado);
            crearPrestamo.Parameters.AddWithValue("@usuario", usuarioPrestado);
            SqlDataAdapter da = new SqlDataAdapter(crearPrestamo);
            MessageBox.Show("Insertado correctamente");
            

        }
    }
}
