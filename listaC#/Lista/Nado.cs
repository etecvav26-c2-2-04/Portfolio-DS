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
    public partial class Nado : Form
    {

        int idade;

        public Nado()
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
            idade = int.Parse(txtIdade.Text);

            if (idade >= 5 && idade <= 7)
            {
                lblResultado.Text = "A idade: " + idade + " é Infantil A";
            }
            else if (idade >= 8 && idade <=10 )
            {
                lblResultado.Text = "A idade: " + idade + " é Infantil B";
            }
            else if (idade >= 11 && idade <= 13)
            {
                lblResultado.Text = "A idade: " + idade + " é Juvenil A";
            }
            else if(idade >= 14 && idade <= 17)
            {
                lblResultado.Text = "A idade: " + idade + " é Juvenil B";
            }
            else if(idade >= 18 && idade <= 25)
            {
                lblResultado.Text = "A idade: " + idade + " é Senior";
            }
            else
            {
                lblResultado.Text = "Idade fora da faixa etaria";
            }
        }
    }
}
