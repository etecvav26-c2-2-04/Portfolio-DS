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
    public partial class Media : Form
    {

        float n1, n2, n3, resultado = 0;
        string nome;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);

            resultado = (n1+n2+n3) / 3;

            if (resultado >= 7)
            { 
                lblResultado.Text = "Nome: "+nome+"\nMedia: "+resultado+"\nAprovado";
            }
            else if (resultado <= 5)
            {
                lblResultado.Text = "Nome: "+nome+"\nMedia: "+resultado+"\nReprovado";
            }
            else
            {
                lblResultado.Text = "Nome: "+nome+"\nMedia: "+resultado+"\nRecuperação";
            }

        }


        public Media()
        {
            InitializeComponent();
        }

        private void paginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frPgInicial = new Media();
            frPgInicial.Show();
        }

    }
}
