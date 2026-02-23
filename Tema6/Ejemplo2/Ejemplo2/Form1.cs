using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int edad;
            edad = Convert.ToInt16(txtEdad.Text);
            if( edad >= 18)
            {
                txtResultado.Text = "Eres mayor de edad";
            }
            else
            {
                txtResultado.Text = "Eres menor de edad";
            }
        }
    }
}
