using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Control_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            seleccionElemento();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lstElementos.Items.Add(txtElemento.Text);
            txtElemento.Clear();
        }
        

        private void seleccionElemento()
        {
            if(lstElementos.SelectedItems.Count > 0)
            {
                txtSeleccionado.Text = lstElementos.SelectedItem.ToString();
            }
        }
    }
}
