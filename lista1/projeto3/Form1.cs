using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class Form1 : Form
    {
        double n1, n2, resultado;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            resultado = n2/n1;

            label3.Text = "O veículo consumiu " + resultado.ToString() + " KM/L";
        }
    }
}
