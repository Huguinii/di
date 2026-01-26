using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recogida_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cadena;
            string cadenaEstado = "";
            string cadenaViajar;
            string cadenaVehiculo;

            cadena = "El nombre escrito es: " + txtNombre.Text + " " +
                txtApellidos.Text + ". ";

            foreach (RadioButton control in groupBox1.Controls.OfType<RadioButton>())
            {
                RadioButton radio = control;
                if (radio.Checked)
                {
                    cadenaEstado = control.Text;
                }
            }

            cadena = cadena + "Tu estado civil es: " + cadenaEstado + ".";

            if (checkBoxDisponibilidad.Checked)
            {
                cadenaViajar = "Si ";
            }
            else
            {
                cadenaViajar = "No ";
            }

            cadena = cadena + cadenaViajar + "tienes disponibilidad para viajar ";

            if (checkBoxVehiculoPropio.Checked)
            {
                cadenaVehiculo = "Si ";
            }
            else
            {
                cadenaVehiculo = "No ";

            }
            cadena = cadena + " y " + cadenaVehiculo + " tienes vehiculo propio";

            MessageBox.Show(cadena);
        
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Está seguro de querer salir?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
