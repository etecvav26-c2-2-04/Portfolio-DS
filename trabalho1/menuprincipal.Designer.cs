namespace trabalho1
{
    partial class menuprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nataçãoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.triânguloToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem1,
            this.nataçãoToolStripMenuItem2,
            this.triânguloToolStripMenuItem3,
            this.alunoToolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem1
            // 
            this.menuPrincipalToolStripMenuItem1.Name = "menuPrincipalToolStripMenuItem1";
            this.menuPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem1.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem1_Click);
            // 
            // nataçãoToolStripMenuItem2
            // 
            this.nataçãoToolStripMenuItem2.Name = "nataçãoToolStripMenuItem2";
            this.nataçãoToolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.nataçãoToolStripMenuItem2.Text = "Natação";
            this.nataçãoToolStripMenuItem2.Click += new System.EventHandler(this.nataçãoToolStripMenuItem2_Click);
            // 
            // triânguloToolStripMenuItem3
            // 
            this.triânguloToolStripMenuItem3.Name = "triânguloToolStripMenuItem3";
            this.triânguloToolStripMenuItem3.Size = new System.Drawing.Size(68, 20);
            this.triânguloToolStripMenuItem3.Text = "Triângulo";
            this.triânguloToolStripMenuItem3.Click += new System.EventHandler(this.triânguloToolStripMenuItem3_Click);
            // 
            // alunoToolStripMenuItem4
            // 
            this.alunoToolStripMenuItem4.Name = "alunoToolStripMenuItem4";
            this.alunoToolStripMenuItem4.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem4.Text = "Aluno";
            this.alunoToolStripMenuItem4.Click += new System.EventHandler(this.alunoToolStripMenuItem4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA 2 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usando menu strip";
            // 
            // menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuprincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nataçãoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem triânguloToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

