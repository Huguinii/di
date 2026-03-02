using System;
using System.Windows.Forms;
using PokeDexManager.ProyectoPokemonDataSetTableAdapters;

namespace PokeDexManager
{
    public partial class VerPokemon : Form
    {
        /// Indica si el formulario está en modo edición o solo visualización
        private bool modoEdicion = false;

        /// IDs del Pokémon y su especie (necesarios para updates)
        private int idPokemon;
        private int idEspecie;

        /// TableAdapters para acceder a la base de datos
        private PokemonTableAdapter pokemonTA = new PokemonTableAdapter();
        private EspecieTableAdapter especieTA = new EspecieTableAdapter();
        private TipoTableAdapter tipoTA = new TipoTableAdapter();
        private CombateTableAdapter combateTA = new CombateTableAdapter();

        /// Constructor del formulario
        public VerPokemon()
        {
            InitializeComponent();
            ConfigurarFormulario(); /// Pone todo en modo solo lectura
            CargarTipos();          /// Carga el combo de tipos
        }

        /// Configura el formulario en modo visualización (no editable)
        private void ConfigurarFormulario()
        {
            txtPokemon.ReadOnly = true;
            txtNivel.ReadOnly = true;
            txtSalud.ReadOnly = true;
            txtAtaque.ReadOnly = true;
            txtDefensa.ReadOnly = true;
            cmbTipo.Enabled = false;
            txtDescripcion.ReadOnly = true;

            btnGuardar.Visible = false; /// Oculta el botón guardar

            this.StartPosition = FormStartPosition.CenterParent; /// Centra el popup
        }

        /// Carga los tipos de Pokémon en el ComboBox
        private void CargarTipos()
        {
            var tablaTipos = tipoTA.GetData();
            cmbTipo.DataSource = tablaTipos;
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.ValueMember = "IdTipo";
        }

        /// Carga los datos del Pokémon seleccionado
        public void CargarDatos(
            int idPoke,
            int idEsp,
            string nombre,
            int nivel,
            int salud,
            int ataque,
            int defensa,
            int tipoId,
            string descripcion)
        {
            idPokemon = idPoke;
            idEspecie = idEsp;

            /// Mostrar stats
            txtPokemon.Text = nombre;
            txtNivel.Text = nivel.ToString();
            txtSalud.Text = salud.ToString();
            txtAtaque.Text = ataque.ToString();
            txtDefensa.Text = defensa.ToString();
            cmbTipo.SelectedValue = tipoId;
            txtDescripcion.Text = descripcion;

            /// Obtener combates ganados
            int totalCombates = 0;
            var result = combateTA.GetCombatesGanadosById(idPokemon);

            if (result != null)
                totalCombates = Convert.ToInt32(result);

            txtCombatesTotales.Text = totalCombates.ToString();

            /// Obtener experiencia total ganada
            int experienciaTotal = 0;
            var expResult = combateTA.GetExperienciaTotalGanadaByPokemonId(idPokemon);

            if (expResult != null)
                experienciaTotal = Convert.ToInt32(expResult);

            txtExperienciaGanada.Text = experienciaTotal.ToString();
        }

        /// Activa el modo edición (habilita campos)
        public void ActivarModoEdicion()
        {
            modoEdicion = true;

            txtNivel.ReadOnly = false;
            txtSalud.ReadOnly = false;
            txtAtaque.ReadOnly = false;
            txtDefensa.ReadOnly = false;
            cmbTipo.Enabled = true;
            txtDescripcion.ReadOnly = false;

            btnGuardar.Visible = true;
        }

        /// <summary>
        /// Botón volver → cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Guarda los cambios si está en modo edición
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
                return;

            try
            {
                /// Leer valores modificados
                int nivel = int.Parse(txtNivel.Text);
                int salud = int.Parse(txtSalud.Text);
                int ataque = int.Parse(txtAtaque.Text);
                int defensa = int.Parse(txtDefensa.Text);
                int nuevoTipoId = Convert.ToInt32(cmbTipo.SelectedValue);
                string nuevaDescripcion = txtDescripcion.Text;

                /// Actualiza stats del Pokémon
                pokemonTA.UpdatePokemonStats(
                    nivel,
                    salud,
                    ataque,
                    defensa,
                    idPokemon
                );

                /// Actualiza datos de la especie
                especieTA.UpdateEspecieDatos(
                    nuevoTipoId,
                    nuevaDescripcion,
                    idEspecie
                );

                MessageBox.Show("Pokémon actualizado correctamente");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Revisa los datos introducidos.");
            }
        }
    }
}