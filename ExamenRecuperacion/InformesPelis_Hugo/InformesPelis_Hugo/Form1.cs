using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InformesPelis_Hugo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void películasYRepartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDePeliculasYReparto infPeliculasyReparto = new ListadoDePeliculasYReparto();
            crystalReportViewer1.ReportSource = infPeliculasyReparto;
        }

        private void actoresPorPaísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdadesActores infActores = new EdadesActores();
            crystalReportViewer1.ReportSource = infActores;
        }

        private void actoresConPelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoActores infEdades = new ListadoActores();
            crystalReportViewer1.ReportSource = infEdades;
        }
    }
}
