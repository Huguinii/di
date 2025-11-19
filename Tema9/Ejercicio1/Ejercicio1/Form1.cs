using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormHijo_Click(object sender, EventArgs e)
        {
            Form formNuevoHijo = new FormHijo();
            formNuevoHijo.MdiParent = this;
            formNuevoHijo.Show();
        }

        private void btnCerrarArchivo_Click(object sender, EventArgs e)
        {
            Form formNuevoHijo = new FormHijo();
            
            this.ActiveMdiChild.Close();
            
        }

        private void btnMostrarVerticalmente_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
