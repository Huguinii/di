using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriasConCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

        SqlConnection conexion = new SqlConnection();

        SqlCommand comando = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(cadenaConexion);

            comando.CommandText = "SELECT * FROM Categories";

            comando.Connection = conexion;

            conexion.Open();

            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                listBox1.Items.Add(resultado["CategoryName"].ToString() + "--" + resultado["Description"].ToString());

            }
            conexion.Close();
        }
    }
}
