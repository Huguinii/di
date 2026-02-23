using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProveedoresBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable listaClases = new DataTable();
            listaClases = DbProviderFactories.GetFactoryClasses();
            foreach(DataRow clase in listaClases.Rows)
            {
                listBox1.Items.Add("Nombre: " + clase["Name"].ToString());
                listBox1.Items.Add("Descripcion: " + clase["Description"].ToString());
                listBox1.Items.Add("Spacename: " + clase["InvariantName"].ToString());
                listBox1.Items.Add(" ");




            }
        }
    }
}
