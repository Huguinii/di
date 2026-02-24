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
    public partial class VerInformacion : Form
    {
        public VerInformacion()
        {
            InitializeComponent();
        }

        private void informeGraficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfGrafico grafico = new InfGrafico();
            crystalReportViewer1.ReportSource = grafico;
        }

        private void informeMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfMultTabla multTabla = new InfMultTabla();
            crystalReportViewer1.ReportSource = multTabla;
        }

        private void informePorParametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfParam param = new InfParam();
            crystalReportViewer1.ReportSource = param;
        }
    }
}
