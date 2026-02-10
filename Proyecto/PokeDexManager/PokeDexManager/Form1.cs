using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDexManager
{
    public partial class PokeDexManager : Form
    {
        public PokeDexManager()
        {
            InitializeComponent();
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void CargarVista(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }


        private void verPokedexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarVista(new UcPokedex());
        }

    }
}
