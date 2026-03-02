using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDexManager
{
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Constructor del formulario SplashScreen
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent(); /// Inicializa los componentes del formulario (progressbar, timer, etc.)
        }

        /// <summary>
        /// Evento que se ejecuta cuando se carga el SplashScreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0; /// Inicializa la barra de progreso en 0
            timer1.Start();         /// Inicia el temporizador para simular la carga
        }

        /// <summary>
        /// Evento que se ejecuta en cada "tick" del timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            /// Si la barra aún no ha llegado al máximo
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1; /// Incrementa el progreso poco a poco
            }
            else
            {
                /// Cuando la barra se llena completamente
                timer1.Stop(); // Detiene el temporizador

                /// Crea y muestra el formulario principal de la aplicación
                PokeDexManager mainForm = new PokeDexManager();
                mainForm.Show();

                /// Oculta el SplashScreen
                this.Hide();
            }
        }
    }

}
