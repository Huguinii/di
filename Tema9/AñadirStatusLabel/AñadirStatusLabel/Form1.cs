using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñadirStatusLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ToolStripStatusLabel> listaLabels = new List<ToolStripStatusLabel>();

        private void btnAñadirStatusLabel_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabel lblStatus = new ToolStripStatusLabel();
            statusStrip1.Show();
            statusStrip1.Items.Add(lblStatus);
            lblStatus.Text = "Este es el nuevo";
            lblStatus.Spring = true;
        }
    }
}
