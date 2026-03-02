using PokeDexManager.ProyectoPokemonDataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PokeDexManager
{
    public partial class UcCombates : UserControl
    {
        /// Tabla que contiene los datos necesarios para los combates
        private ProyectoPokemonDataSet.PokemonCombateDataTable tablaPokemon;

        /// TableAdapter para obtener el detalle completo de un Pokémon
        private PokemonDetalleTableAdapter detalleTA = new PokemonDetalleTableAdapter();

        /// Constructor del UserControl
        public UcCombates()
        {
            InitializeComponent();

            /// Cargar los Pokémon disponibles para combatir
            CargarPokemons();

            /// Cargar el historial de combates realizados
            CargarHistorial();

            /// Evento para resaltar visualmente al ganador
            dgvCombates.CellFormatting += dgvCombates_CellFormatting;
        }

        /// <summary>
        /// Carga los Pokémon en los ComboBox de selección
        /// </summary>
        private void CargarPokemons()
        {
            var combateTA = new ProyectoPokemonDataSetTableAdapters.PokemonCombateTableAdapter();
            tablaPokemon = combateTA.GetData();

            /// ComboBox del Pokémon 1
            cmbPokemon1.DataSource = tablaPokemon.Copy();
            cmbPokemon1.DisplayMember = "Nombre";
            cmbPokemon1.ValueMember = "IdPokemon";
            cmbPokemon1.SelectedIndex = -1;

            /// ComboBox del Pokémon 2
            cmbPokemon2.DataSource = tablaPokemon;
            cmbPokemon2.DisplayMember = "Nombre";
            cmbPokemon2.ValueMember = "IdPokemon";
            cmbPokemon2.SelectedIndex = -1;
        }

        /// Carga el historial de combates en el DataGridView
        private void CargarHistorial()
        {
            var historialTA = new ProyectoPokemonDataSetTableAdapters.CombateHistorialTableAdapter();
            var tabla = historialTA.GetData();

            dgvCombates.DataSource = tabla;
            dgvCombates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombates.ReadOnly = true;

            /// Ocultar los IDs internos
            dgvCombates.Columns["IdPokemon1"].Visible = false;
            dgvCombates.Columns["IdPokemon2"].Visible = false;
            dgvCombates.Columns["IdGanador"].Visible = false;
        }

        /// Evento del botón que inicia el combate
        private void btnPelea_Click(object sender, EventArgs e)
        {
            /// Validar que ambos Pokémon estén seleccionados
            if (cmbPokemon1.SelectedIndex == -1 || cmbPokemon2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona dos Pokémon.");
                return;
            }

            DataRowView p1 = (DataRowView)cmbPokemon1.SelectedItem;
            DataRowView p2 = (DataRowView)cmbPokemon2.SelectedItem;

            int id1 = Convert.ToInt32(p1["IdPokemon"]);
            int id2 = Convert.ToInt32(p2["IdPokemon"]);

            /// Evitar combate contra sí mismo
            if (id1 == id2)
            {
                MessageBox.Show("No se puede seleccionar el mismo pokemon");
                return;
            }

            /// Stats del Pokémon 1
            int salud1 = Convert.ToInt32(p1["Salud"]);
            int ataque1 = Convert.ToInt32(p1["Ataque"]);
            int defensa1 = Convert.ToInt32(p1["Defensa"]);

            /// Stats del Pokémon 2
            int salud2 = Convert.ToInt32(p2["Salud"]);
            int ataque2 = Convert.ToInt32(p2["Ataque"]);
            int defensa2 = Convert.ToInt32(p2["Defensa"]);

            /// Cálculo de daños sin permitir valores negativos
            int daño1 = Math.Max(0, ataque1 - defensa2);
            int daño2 = Math.Max(0, ataque2 - defensa1);

            /// Aplicar daño a la salud
            int saludFinal1 = Math.Max(0, salud1 - daño2);
            int saludFinal2 = Math.Max(0, salud2 - daño1);

            int ganadorId;
            string mensaje;

            /// Determinar ganador
            if (saludFinal1 > saludFinal2)
            {
                ganadorId = id1;
                mensaje = $"{p1["Nombre"]} gana el combate!";
            }
            else if (saludFinal2 > saludFinal1)
            {
                ganadorId = id2;
                mensaje = $"{p2["Nombre"]} gana el combate!";
            }
            else
            {
                MessageBox.Show("¡Empate! No se registra combate.");
                return;
            }
            
            /// Generar experiencia aleatoria entre 10 y 50
            Random rnd = new Random();
            int experiencia = rnd.Next(10, 51);

            /// Guardar combate en base de datos
            var combateTA = new ProyectoPokemonDataSetTableAdapters.CombateTableAdapter();
            combateTA.Insert(
                id1,
                id2,
                daño1,
                daño2,
                ganadorId,
                experiencia,
                DateTime.Now
            );

            MessageBox.Show($"{mensaje}\nExperiencia ganada: {experiencia}");

            /// Recargar historial
            CargarHistorial();

            /// Resetear selección
            cmbPokemon1.SelectedIndex = -1;
            cmbPokemon2.SelectedIndex = -1;
        }

        /// Resalta al ganador en verde
        private void dgvCombates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCombates.Columns[e.ColumnIndex].Name == "Ganador")
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.Font = new Font(dgvCombates.Font, FontStyle.Bold);
            }
        }

        /// <summary>
        /// Permite abrir el detalle del Pokémon al hacer click en el historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCombates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName = dgvCombates.Columns[e.ColumnIndex].Name;

            int idPokemon = 0;

            if (columnName == "Pokemon1")
                idPokemon = Convert.ToInt32(dgvCombates.Rows[e.RowIndex].Cells["IdPokemon1"].Value);
            else if (columnName == "Pokemon2")
                idPokemon = Convert.ToInt32(dgvCombates.Rows[e.RowIndex].Cells["IdPokemon2"].Value);
            else if (columnName == "Ganador")
                idPokemon = Convert.ToInt32(dgvCombates.Rows[e.RowIndex].Cells["IdGanador"].Value);
            else
                return;

            var table = detalleTA.GetDataById(idPokemon);

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
    }
}