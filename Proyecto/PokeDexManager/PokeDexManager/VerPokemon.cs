using System;
using System.Windows.Forms;
using PokeDexManager.ProyectoPokemonDataSetTableAdapters;

namespace PokeDexManager
{
    public partial class VerPokemon : Form
    {
        private bool modoEdicion = false;

        private int idPokemon;
        private int idEspecie;

        private PokemonTableAdapter pokemonTA = new PokemonTableAdapter();
        private EspecieTableAdapter especieTA = new EspecieTableAdapter();
        private TipoTableAdapter tipoTA = new TipoTableAdapter();
        private CombateTableAdapter combateTA = new CombateTableAdapter();


        public VerPokemon()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarTipos();
        }

        private void ConfigurarFormulario()
        {
            txtPokemon.ReadOnly = true;
            txtNivel.ReadOnly = true;
            txtSalud.ReadOnly = true;
            txtAtaque.ReadOnly = true;
            txtDefensa.ReadOnly = true;
            cmbTipo.Enabled = false;
            txtDescripcion.ReadOnly = true;

            btnGuardar.Visible = false;

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CargarTipos()
        {
            var tablaTipos = tipoTA.GetData();
            cmbTipo.DataSource = tablaTipos;
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.ValueMember = "IdTipo";
        }

        // 🔥 Ahora recibe también IdEspecie y TipoId
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

            txtPokemon.Text = nombre;
            txtNivel.Text = nivel.ToString();
            txtSalud.Text = salud.ToString();
            txtAtaque.Text = ataque.ToString();
            txtDefensa.Text = defensa.ToString();
            cmbTipo.SelectedValue = tipoId;
            txtDescripcion.Text = descripcion;

            //Combates totales ganados
            int totalCombates = 0;

            var result = combateTA.GetCombatesGanadosById(idPokemon);

            if (result != null)
                totalCombates = Convert.ToInt32(result);

            txtCombatesTotales.Text = totalCombates.ToString();

            // Experiencia total ganada
            int experienciaTotal = 0;

            var expResult = combateTA.GetExperienciaTotalGanadaByPokemonId(idPokemon);

            if (expResult != null)
                experienciaTotal = Convert.ToInt32(expResult);

            txtExperienciaGanada.Text = experienciaTotal.ToString();


        }

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

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!modoEdicion)
                return;

            try
            {
                int nivel = int.Parse(txtNivel.Text);
                int salud = int.Parse(txtSalud.Text);
                int ataque = int.Parse(txtAtaque.Text);
                int defensa = int.Parse(txtDefensa.Text);
                int nuevoTipoId = Convert.ToInt32(cmbTipo.SelectedValue);
                string nuevaDescripcion = txtDescripcion.Text;

                // 🔹 Update Pokemon
                pokemonTA.UpdatePokemonStats(
                    nivel,
                    salud,
                    ataque,
                    defensa,
                    idPokemon
                );

                // 🔹 Update Especie
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
