using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2Tema2
{
    public partial class Ejercicio3Tema2 : Form
    {
        public Ejercicio3Tema2()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.lstNombres.Items.Clear();

            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            txtNombre.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtSeleccionado.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            //el boton añadir se ancla arriba y derecha
            btnAnadir.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            //el listbox se ancla en los cuatro vértices
            lstNombres.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;

            //el boton cerrar se ancla a la derecha y abajo
            btnCerrar.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                lstNombres.Items.Add(txtNombre.Text);
                txtNombre.Clear();
            }
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex != -1)
                txtSeleccionado.Text = lstNombres.SelectedItem.ToString();
        }

        private void lstNombres_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Delete)
            {
                lstNombres.Items.Remove(lstNombres.SelectedItem);
            }*/
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                int i;
                for (i = lstNombres.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstNombres.Items.Remove(lstNombres.SelectedItems[i]);
                }

            }

        }



        private void btnBorrarTodos_Click(object sender, EventArgs e)
        {
            lstNombres.Items.Clear();
            txtSeleccionado.Clear();
        }

        private void btnBorrarSeleccionado_Click(object sender, EventArgs e)
        {

            
                int i;
                for (i = lstNombres.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstNombres.Items.Remove(lstNombres.SelectedItems[i]);
                }

            txtSeleccionado.Clear();

        }
    }
}
