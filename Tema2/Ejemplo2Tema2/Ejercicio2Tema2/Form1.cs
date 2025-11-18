using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Tema2
{
    public partial class Ejercicio2Tema2 : Form
    {
        public Ejercicio2Tema2()
        {
            InitializeComponent();
        }

        private void Ejercicio2Tema2_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.lstNombres.Items.Clear();

            groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            txtNombre.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            txtApellidos.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            //el boton añadir se ancla arriba y derecha
            btnAceptar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

            //el listbox se ancla en los cuatro vértices
            lstNombres.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top);

            //el boton cerrar se ancla a la derecha y abajo
            btnCancelar.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
        }
    }
}
