using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerDocumentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirCHM_Click(object sender, EventArgs e)
        {
            string rutaEjecutable=System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(rutaEjecutable + "/CHM/Prueba.chm");
        }

        private void btnAbrirHTML_Click(object sender, EventArgs e)
        {
            string rutaEjecutable = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(rutaEjecutable + "/HTML/Prueba.html");
        }
    }
}
