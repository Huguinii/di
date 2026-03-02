using PokeDexManager.ProyectoPokemonDataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PokeDexManager
{
    public partial class UcPokedex : UserControl
    {
        /// Tabla base con los Pokémon
        private DataTable tablaPokemon;

        /// Vista filtrable de la tabla
        private DataView vistaPokemon;

        /// Evento para notificar cuántos Pokémon hay cargados
        public event Action<int> PokemonCargados;

        /// Adaptadores de acceso a datos
        private PokemonTableAdapter pokemonTA = new PokemonTableAdapter();
        private TipoTableAdapter tipoTA = new TipoTableAdapter();
        private PokemonDetalleTableAdapter detalleTA = new PokemonDetalleTableAdapter();
        private SimplePokedexTableAdapter simplePokedexTA = new SimplePokedexTableAdapter();

        public UcPokedex()
        {
            InitializeComponent();
        }

        /// Evento Load del UserControl
        private void UcPokedex_Load(object sender, EventArgs e)
        {
            RellenarTipos();
            CargarTipos();
            CargarPokedex();
        }

        /// Inserta los tipos básicos si la tabla está vacía
        private void RellenarTipos()
        {
            if (tipoTA.ExistenTipos() <= 0)
            {
                string[] tiposPokemon =
                {
                    "Normal","Lucha","Volador","Veneno","Tierra","Roca",
                    "Bicho","Fantasma","Acero","Fuego","Agua","Planta",
                    "Electrico","Psiquico","Hielo","Dragon","Siniestro","Hada"
                };

                foreach (string tipo in tiposPokemon)
                {
                    tipoTA.InsertTipo(tipo);
                }
            }
        }

        /// Carga los tipos en el ComboBox
        private void CargarTipos()
        {
            var tablaTipos = tipoTA.GetData();

            cmbTipos.DataSource = tablaTipos;
            cmbTipos.DisplayMember = "Nombre";
            cmbTipos.ValueMember = "IdTipo";
            cmbTipos.SelectedIndex = -1;
        }

        /// Carga la Pokédex en el DataGridView
        private void CargarPokedex()
        {
            tablaPokemon = simplePokedexTA.GetData();
            vistaPokemon = new DataView(tablaPokemon);
            dgvPokedex.DataSource = vistaPokemon;

            /// Ocultar ID interno
            if (dgvPokedex.Columns["IdPokemon"] != null)
                dgvPokedex.Columns["IdPokemon"].Visible = false;

            /// Notificar cantidad cargada
            PokemonCargados?.Invoke(tablaPokemon.Rows.Count);
        }

        /// Aplica filtros al cambiar el tipo
        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// Abrir formulario de creación de Pokémon
        private void btnNuevoPokemon_Click(object sender, EventArgs e)
        {
            NuevoPokemon pokemonNuevo = new NuevoPokemon();
            pokemonNuevo.ShowDialog();
            CargarPokedex();
        }

        /// Click en celda = ver detalles
        private void dgvPokedex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tsmiVerDetalles_Click(sender, e);
        }

        /// Ver detalles del Pokémon seleccionado
        private void tsmiVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvPokedex.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dgvPokedex.CurrentRow.Cells["IdPokemon"].Value);
            var table = detalleTA.GetDataById(id);

            if (table.Rows.Count == 0)
                return;

            var row = table[0];

            VerPokemon form = new VerPokemon();
            form.CargarDatos(
                row.IdPokemon,
                row.IdEspecie,
                row.Nombre,
                row.Nivel,
                row.Salud,
                row.Ataque,
                row.Defensa,
                row.TipoId,
                row.Descripcion
            );

            form.ShowDialog();
        }

        /// Eliminar Pokémon seleccionado
        private void tsmiEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPokedex.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dgvPokedex.CurrentRow.Cells["IdPokemon"].Value);

            var confirm = MessageBox.Show(
                "¿Seguro que quieres eliminar este Pokémon?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            pokemonTA.EliminarPokemon(id);
            CargarPokedex();
        }

        /// Editar Pokémon seleccionado
        private void tsmiEditar_Click(object sender, EventArgs e)
        {
            if (dgvPokedex.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dgvPokedex.CurrentRow.Cells["IdPokemon"].Value);
            var table = detalleTA.GetDataById(id);

            if (table.Rows.Count == 0)
                return;

            var row = table[0];

            VerPokemon form = new VerPokemon();
            form.CargarDatos(
                row.IdPokemon,
                row.IdEspecie,
                row.Nombre,
                row.Nivel,
                row.Salud,
                row.Ataque,
                row.Defensa,
                row.TipoId,
                row.Descripcion
            );

            form.ActivarModoEdicion();

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarPokedex();
            }
        }

        /// <summary>
        /// Colorear filas según el tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPokedex_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvPokedex.Rows[e.RowIndex];

            if (row.Cells["Tipo"].Value == null)
                return;

            string tipo = row.Cells["Tipo"].Value.ToString();
            Color color = Color.White;

            switch (tipo)
            {
                case "Fuego": color = Color.OrangeRed; break;
                case "Agua": color = Color.LightSkyBlue; break;
                case "Planta": color = Color.LightGreen; break;
                case "Electrico": color = Color.Gold; break;
                case "Fantasma": color = Color.MediumPurple; break;
                case "Dragon": color = Color.MediumSlateBlue; break;
                case "Normal": color = Color.Beige; break;
                case "Veneno": color = Color.MediumOrchid; break;
                case "Tierra": color = Color.SandyBrown; break;
                case "Roca": color = Color.Peru; break;
                case "Psiquico": color = Color.HotPink; break;
                case "Hielo": color = Color.LightCyan; break;
                case "Siniestro": color = Color.DimGray; break;
                case "Acero": color = Color.Silver; break;
                case "Hada": color = Color.Pink; break;
                case "Volador": color = Color.LightSteelBlue; break;
                case "Lucha": color = Color.IndianRed; break;
                case "Bicho": color = Color.YellowGreen; break;
            }

            row.DefaultCellStyle.BackColor = color;
            row.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// Filtro por búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        /// Aplicación conjunta de filtros
        private void AplicarFiltros()
        {
            if (vistaPokemon == null)
                return;

            string filtro = "";
            string texto = txtBusqueda.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrEmpty(texto))
            {
                filtro = $"Nombre LIKE '%{texto}%'";
            }

            if (cmbTipos.SelectedIndex != -1)
            {
                if (filtro != "")
                    filtro += " AND ";

                filtro += $"Tipo = '{cmbTipos.Text}'";
            }

            vistaPokemon.RowFilter = filtro;
        }
    }
}