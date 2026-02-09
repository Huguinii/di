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

        private void verPokedexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPokedex pokedex = new FormPokedex();
            pokedex.ShowDialog();
            //prompt con la imagen ideaSplash2
            //en vez de crear otro formulario diferente quiero que en el propio main sea algo como esto y que al clicar por ejemplo en pokedex aparezca el datagridview y al darle a filtrar por tipo salga un desplegable de los tipos que existen y se actualice el datagridview a los pokemons de solo ese tipo pero todo en el main
        }
    }
}
