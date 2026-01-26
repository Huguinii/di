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

namespace PruebaConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            static string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                if (conexion.State == ConnectionState.Open)
                    MessageBox.Show("Conexion establecida.");

            }
            catch (SqlException ex)
            {
                if (conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Ha habido un problema con la conexion " + ex.Message);
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }
        }
    }
}
