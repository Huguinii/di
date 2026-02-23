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

            btnCrear.Enabled = false;
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
            especiePokemon = txtEspecie.Text.Trim();
            descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(especiePokemon))
            {
                MessageBox.Show("La especie es obligatoria.");
                return;
            }

            if (descripcion.Length > 100)
            {
                MessageBox.Show("La descripción no puede superar los 100 caracteres.");
                return;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo.");
                return;
            }

            // 🔥 Ahora tomamos directamente los valores
            nivel = (int)nudNivel.Value;
            salud = (int)nudSalud.Value;
            ataque = (int)nudAtaque.Value;
            defensa = (int)nudDefensa.Value;

            var pokemonTA = new ProyectoPokemonDataSetTableAdapters.PokemonTableAdapter();
            var especieTA = new ProyectoPokemonDataSetTableAdapters.EspecieTableAdapter();

            // Insertar especie
            especieTA.InsertarEspecie(especiePokemon, tipoId, descripcion);

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

            ValidarFormulario();

        }

        private void ValidarFormulario()
        {
            bool especieValida = !string.IsNullOrWhiteSpace(txtEspecie.Text);
            bool tipoValido = cmbTipo.SelectedIndex != -1;

            btnCrear.Enabled = especieValida && tipoValido;
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearPokemon();
            Close();
        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {
            ValidarFormulario();
        }
    }
}
