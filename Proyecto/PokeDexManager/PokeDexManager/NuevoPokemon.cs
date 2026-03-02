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
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public NuevoPokemon()
        {
            InitializeComponent();

            /// Cargamos los tipos disponibles en el ComboBox
            CargarTipos();

            /// El botón Crear empieza deshabilitado hasta que el formulario sea válido
            btnCrear.Enabled = false;
        }

        /// <summary>
        /// Variables donde guardaremos los datos del nuevo Pokémon
        /// </summary>
        string especiePokemon;
        int nivel;
        int salud;
        int ataque;
        int defensa;
        string descripcion;
        int tipoId;

        /// <summary>
        /// Método principal que inserta el Pokémon en la base de datos
        /// </summary>
        private void CrearPokemon()
        {
            /// Obtenemos datos de los TextBox
            especiePokemon = txtEspecie.Text.Trim();
            descripcion = txtDescripcion.Text.Trim();

            /// Validación: especie obligatoria
            if (string.IsNullOrWhiteSpace(especiePokemon))
            {
                MessageBox.Show("La especie es obligatoria.");
                return;
            }

            /// Validación: descripción máximo 100 caracteres
            if (descripcion.Length > 100)
            {
                MessageBox.Show("La descripción no puede superar los 100 caracteres.");
                return;
            }

            /// Validación: tipo obligatorio
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo.");
                return;
            }

            /// Obtenemos valores de los NumericUpDown (ya limitados desde el diseñador)
            nivel = (int)nudNivel.Value;
            salud = (int)nudSalud.Value;
            ataque = (int)nudAtaque.Value;
            defensa = (int)nudDefensa.Value;

            /// TableAdapters para insertar datos
            var pokemonTA = new ProyectoPokemonDataSetTableAdapters.PokemonTableAdapter();
            var especieTA = new ProyectoPokemonDataSetTableAdapters.EspecieTableAdapter();

            /// Insertamos la especie
            especieTA.InsertarEspecie(especiePokemon, tipoId, descripcion);

            /// Recuperamos el Id de la especie recién creada
            int idEspecie = (int)especieTA.GetIdEspeciePorNombre(especiePokemon);

            /// Insertamos el Pokémon con sus stats
            pokemonTA.InsertarPokemon(
                idEspecie,
                nivel,
                salud,
                ataque,
                defensa,
                DateTime.Now
            );
        }

        /// <summary>
        /// Carga los tipos en el ComboBox desde la base de datos
        /// </summary>
        private void CargarTipos()
        {
            var tipoTA = new ProyectoPokemonDataSetTableAdapters.TipoTableAdapter();
            var tablaTipos = tipoTA.GetData();

            cmbTipo.DataSource = tablaTipos;
            cmbTipo.DisplayMember = "Nombre";   // Lo que se muestra
            cmbTipo.ValueMember = "IdTipo";     // El valor real
            cmbTipo.SelectedIndex = -1;         // Sin selección inicial
        }

        /// <summary>
        /// Cuando se cambia el tipo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue == null)
                return;

            /// Guardamos el Id del tipo seleccionado
            if (cmbTipo.SelectedValue is int id)
            {
                tipoId = id;
            }

            /// Revalidamos el formulario
            ValidarFormulario();
        }

        /// <summary>
        /// Activa el botón Crear solo si los datos mínimos son válidos
        /// </summary>
        private void ValidarFormulario()
        {
            bool especieValida = !string.IsNullOrWhiteSpace(txtEspecie.Text);
            bool tipoValido = cmbTipo.SelectedIndex != -1;

            btnCrear.Enabled = especieValida && tipoValido;
        }

        /// <summary>
        /// Botón Crear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearPokemon();
            Close();
        }

        /// Cada vez que se escribe en especie, revalidamos
        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {
            ValidarFormulario();
        }
    }
}