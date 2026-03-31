using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double nota1, nota2, nota3, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            string nomedoaluno = textBox4.Text;

            nota1 = double.Parse(textnota1.Text);
            nota2 = double.Parse(textnota2.Text);
            nota3 = double.Parse(textnota3.Text);

            resultado = (nota1 + nota2 + nota3) / 3;

            label7.Text = "Olá " + nomedoaluno;
            label5.Text = "A sua média foi de: " + resultado.ToString("0.00");


        }
    }
}
