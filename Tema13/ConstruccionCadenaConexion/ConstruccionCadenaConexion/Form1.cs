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

namespace ConstruccionCadenaConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SqlConnectionStringBuilder cadenaConexion = new SqlConnectionStringBuilder
            {
                DataSource = "localhost\\SQLEXPRESS",
                InitialCatalog = "Northwind",
                IntegratedSecurity = true
            };
            MessageBox.Show(cadenaConexion.ConnectionString);
            
            SqlConnection conexion = new SqlConnection(cadenaConexion.ToString());

            try
            {
                conexion.Open();
                if (conexion.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexion abierta correctamente");
                }

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            */
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; Encrypt = False";
            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            
            conexion.Open();
            
            string sql = "Insert into Employees (LastName, FirstName) values ('Cervantes', 'Miguel')";

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Registros afectados" + registros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; Encrypt = False";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            string sql = "Delete from Employees where FirstName = 'Federico'";

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Registros afectados" + registros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; Encrypt = False";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();

            string sql = "Update Employees set FirstName = 'Federico' where FirstName = 'Miguel'";

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Actualizacion realizada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
