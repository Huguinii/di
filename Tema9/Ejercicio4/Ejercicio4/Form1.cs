using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorStatusLabel.Text = "Color: Azul";
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void toolStripSplitButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //colorStatusLabel.Text = "Color: " + sender.ToString();
        }
    }
}
