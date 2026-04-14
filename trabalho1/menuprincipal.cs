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
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

      


        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuprincipal telamenu = new menuprincipal();
            telamenu.ShowDialog();

        }

        private void nataçãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            natacao telanatacao = new natacao();
            telanatacao.ShowDialog();
        }
        private void triânguloToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            triangulo telatriangulo = new triangulo();
            telatriangulo.ShowDialog();

        }

        private void alunoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            aluno telaaluno = new aluno();
            telaaluno.ShowDialog();
        }
    }
}
