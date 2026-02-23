using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int primerNumero;
        int segundoNumero;
        public Form1()
        {
            InitializeComponent();
        }

        private void cboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOperacion.Items.Add("+");
            cboOperacion.Items.Add("-");
            cboOperacion.Items.Add("*");
            cboOperacion.Items.Add("/");
        }

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                primerNumero = Convert.ToInt32(txtPrimerOperando.Text);
            }
            catch
            {
                MessageBox.Show("El dato 1 introducido no es un entero");
            }
            try
            {
                segundoNumero = Convert.ToInt32(txtSegundoOperando.Text);
            }
            catch
            {
                MessageBox.Show("El dato 1 introducido no es un entero");
            }
            calcular();
        }

        private void calcular()
        {
            double resultado = 0;
            try
            {
                switch (cboOperacion.SelectedItem.ToString())
                {
                    case "+":
                        resultado = primerNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primerNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primerNumero * segundoNumero;
                        break;
                    case "/":
                        resultado = primerNumero / segundoNumero;
                        break;

                }
            }catch (Exception ex)
            {
                resultado = 0;
            }
            txtResultado.Text = resultado.ToString();
            
        }
    }
}
