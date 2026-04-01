using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_2
{
    public partial class Form1 : Form
    {
        double idade;
        string nome;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            idade = double.Parse(textBox2.Text);
            nome = textBox1.Text;

            label4.Text = "Olá "+ nome + "!";
            idadeemmeses.Text = "Você têm " + idade * 12 + " Meses";
            idadeemsemanas.Text = "Você têm " + idade * 48 + " Semanas";
            idadeemdias.Text = "Você têm " + idade * 365 + " Dias";
            idadeemhoras.Text = "Você têm " + idade * 8766 + " Horas";

        }
    }
}
