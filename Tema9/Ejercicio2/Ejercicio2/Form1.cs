using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            lbltexto.Text = "IES COMERCIO";
            
        }

        

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuGrande_Click(object sender, EventArgs e)
        {
            lbltexto.Font = new Font(lbltexto.Font.Name, 50);

        }

        private void menuMediano_Click(object sender, EventArgs e)
        {
            lbltexto.Font = new Font(lbltexto.Font.Name, 30);

        }

        private void menuPequeño_Click(object sender, EventArgs e)
        {
            lbltexto.Font = new Font(lbltexto.Font.Name, 15);

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltexto.ForeColor = Color.Blue;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltexto.ForeColor = Color.Red;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbltexto.ForeColor = Color.Green;
        }
    }
}
