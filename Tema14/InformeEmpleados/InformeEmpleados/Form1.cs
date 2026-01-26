using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformeEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfPedidosAsist infPedidos = new InfPedidosAsist();
            crystalReportViewer1.ReportSource = infPedidos;
        }

        private void informePedidosManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
