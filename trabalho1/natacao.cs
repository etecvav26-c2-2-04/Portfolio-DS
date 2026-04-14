using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho1
{
    public partial class natacao : Form
    {
        int idade;
        string categoria;

        public natacao()
        {
            InitializeComponent();
        }

        private void nataçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            natacao telaClientes = new natacao();
            telaClientes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idade = int.Parse(textBox1.Text);
            /*
            • Infantil A = 5 - 7 anos
            • Infantil B = 8 - 10 anos
            • Juvenil A = 11 - 13 anos
            • Juvenil B = 14 - 17 anos
            • Sênior = 18 - 25 anos
            */

            if (idade >= 5 && idade <= 8)
            {
                categoria = "Infantil A";
            }
            else if (idade >= 8 && idade <= 10)
            {
                categoria = "Infaltil B";
            }
            else if (idade >= 11 && idade <= 13)
            {
                categoria = "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                categoria = "Juvenil B";
            }
            else if (idade >= 18 && idade <= 25)
            {
                categoria = "Sênior";
            }
            else
            {
                categoria = "Invalida";
            }
            label4.Text = "Sua categoria é " + categoria;
        
        }
    }
}
