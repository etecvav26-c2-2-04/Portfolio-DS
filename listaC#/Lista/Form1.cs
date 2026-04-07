using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class pgInicial : Form
    {
        public pgInicial()
        {
            InitializeComponent();
        }

        private void nadadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frNado = new Nado();
            frNado.Show();
        }

        private void mediaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frMedia = new Media();
            frMedia.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frTriangulo = new Triangulo();
            frTriangulo.Show();
        }
    }
}
