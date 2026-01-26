using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListaImagenes
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void btnImagenes_Click(object sender, EventArgs e)
        {
            imagen();
            
        }

        private void imagen()
        {
            pictureBox.Image=listaImagenes.Images[cont];
            cont++;
            if (cont == listaImagenes.Images.Count)
            {
                cont = 0;
            }
        }

        
    }
}
