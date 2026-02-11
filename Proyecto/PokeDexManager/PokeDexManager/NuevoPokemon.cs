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
    public partial class NuevoPokemon : Form
    {

        public NuevoPokemon()
        {
            InitializeComponent();
            CargarTipos();
        }
        string especiePokemon;
        int nivel;
        int salud;
        int ataque;
        int defensa;
        string descripcion;
        int tipoId;


        private void CrearPokemon()
        {
            especiePokemon = txtEspecie.Text;
            descripcion = txtDescripcion.Text;

            if (!int.TryParse(txtNivel.Text, out nivel) ||
                !int.TryParse(txtSalud.Text, out salud) ||
                !int.TryParse(txtAtaque.Text, out ataque) ||
                !int.TryParse(txtDefensa.Text, out defensa))
            {
                MessageBox.Show("Nivel, salud, ataque y defensa deben ser números.");
                return;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo.");
                return;
            }

            var pokemonTA = new ProyectoPokemonDataSetTableAdapters.PokemonTableAdapter();
            var especieTA = new ProyectoPokemonDataSetTableAdapters.EspecieTableAdapter();

            // Insertar especie
            especieTA.InsertarEspecie(especiePokemon, tipoId, descripcion);

            // Obtener IdEspecie
            int idEspecie = (int)especieTA.GetIdEspeciePorNombre(especiePokemon);

            // Insertar Pokémon
            pokemonTA.InsertarPokemon(
                idEspecie,
                nivel,
                salud,
                ataque,
                defensa,
                DateTime.Now
            );
            
        }



        private void CargarTipos()
        {
            var tipoTA = new ProyectoPokemonDataSetTableAdapters.TipoTableAdapter();
            var tablaTipos = tipoTA.GetData();

            cmbTipo.DataSource = tablaTipos;
            cmbTipo.DisplayMember = "Nombre";   
            cmbTipo.ValueMember = "IdTipo";     
            cmbTipo.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue == null)
                return;

            if (cmbTipo.SelectedValue is int id)
            {
                tipoId = id;
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearPokemon();
            Close();
        }
    }
}
