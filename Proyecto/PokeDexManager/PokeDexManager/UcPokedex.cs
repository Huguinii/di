using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDexManager
{
    public partial class UcPokedex : UserControl
    {
        private DataTable tablaPokemon;

        public UcPokedex()
        {
            InitializeComponent();
        }

        private void UcPokedex_Load(object sender, EventArgs e)
        {
            RellenarTipos();
            CargarTipos();
            CargarPokedex();
        }

        private void RellenarTipos()
        {
            
            var adapter = new ProyectoPokemonDataSetTableAdapters.TipoTableAdapter();

            if(adapter.ExistenTipos() <= 0)
            {
                string[] tiposPokemon =
                {
                    "Normal",
                    "Lucha",
                    "Volador",
                    "Veneno",
                    "Tierra",
                    "Roca",
                    "Bicho",
                    "Fantasma",
                    "Acero",
                    "Fuego",
                    "Agua",
                    "Planta",
                    "Electrico",
                    "Psiquico",
                    "Hielo",
                    "Dragon",
                    "Siniestro",
                    "Hada"
                };

                foreach (string tipo in tiposPokemon)
                {
                    adapter.InsertTipo(tipo);
                }
            }

            
        }


        private void CargarTipos()
        {
            var tipoTA = new ProyectoPokemonDataSetTableAdapters.TipoTableAdapter();
            var tablaTipos = tipoTA.GetData();

            cmbTipos.DataSource = tablaTipos;
            cmbTipos.DisplayMember = "Nombre";   
            cmbTipos.ValueMember = "IdTipo";     
            cmbTipos.SelectedIndex = -1;
        }




        private void CargarPokedex()
        {
            var adapter = new ProyectoPokemonDataSetTableAdapters.PokemonTableAdapter();
            dgvPokedex.DataSource = adapter.GetDataPokedex();
        }


        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipos.SelectedIndex == -1)
            {
                dgvPokedex.DataSource = tablaPokemon;
                return;
            }

            DataView vista = new DataView(tablaPokemon);
            vista.RowFilter = $"IdTipo = {cmbTipos.SelectedValue}";
            dgvPokedex.DataSource = vista;
        }

        private void btnNuevoPokemon_Click(object sender, EventArgs e)
        {
            NuevoPokemon pokemonNuevo = new NuevoPokemon();
            pokemonNuevo.ShowDialog();
        }
    }
}
