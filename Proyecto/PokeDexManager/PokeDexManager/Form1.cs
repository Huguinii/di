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

        private void ActualizarStatus(int cantidad)
        {
            tsslPokemonCargados.Text = $"Pokémon cargados: {cantidad}";
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
            var uc = new UcPokedex();
            uc.PokemonCargados += ActualizarStatus;
            CargarVista(uc);
        }

        private void registrarCombateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ucCombates = new UcCombates();
            CargarVista(ucCombates);
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInformacion info = new VerInformacion();
            info.Show();
        }
    }
}
