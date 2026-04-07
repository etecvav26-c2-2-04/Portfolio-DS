using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Triangulo : Form
    {
            float a1,a2,a3;
        public Triangulo()
        {
            InitializeComponent();
        }

        private void paginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frPgInicial = new Media();
            frPgInicial.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            a1 = float.Parse(txtLado1.Text);
            a2 = float.Parse(txtLado2.Text);
            a3 = float.Parse(txtLado3.Text);

            if (a1 == 90 || a2 == 90 || a3 == 90)
            {
                lblResultado.Text = "O triangulo é Retangulo";
            }
            else if (a1 > 90 || a2 > 90 || a3 > 90)
            {
                lblResultado.Text = "O triangulo é Obtusangulo";
            }
            else if (a1 < 90 && a2 < 90 && a3 < 90)
            {
                lblResultado.Text = "O triangulo é Acutangulo";
            }

        }
    }
}
