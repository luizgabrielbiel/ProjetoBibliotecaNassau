namespace Projeto_Biblioteca_Nassau
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLeitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAcervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.eToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunosToolStripMenuItem,
            this.alterarLeitorToolStripMenuItem,
            this.consultarCadastroToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem});
            this.alunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosToolStripMenuItem.Image")));
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.AlunosToolStripMenuItem_Click);
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            this.cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            this.cadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunosToolStripMenuItem.Click += new System.EventHandler(this.CadastrarAlunosToolStripMenuItem_Click);
            // 
            // alterarLeitorToolStripMenuItem
            // 
            this.alterarLeitorToolStripMenuItem.Name = "alterarLeitorToolStripMenuItem";
            this.alterarLeitorToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.alterarLeitorToolStripMenuItem.Text = "Alterar Dados ";
            this.alterarLeitorToolStripMenuItem.Click += new System.EventHandler(this.AlterarLeitorToolStripMenuItem_Click);
            // 
            // consultarCadastroToolStripMenuItem
            // 
            this.consultarCadastroToolStripMenuItem.Name = "consultarCadastroToolStripMenuItem";
            this.consultarCadastroToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.consultarCadastroToolStripMenuItem.Text = "Consultar Cadastro";
            this.consultarCadastroToolStripMenuItem.Click += new System.EventHandler(this.ConsultarCadastroToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.ExcluirAlunoToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
            this.excluirLivroToolStripMenuItem,
            this.consultarAcervoToolStripMenuItem,
            this.alterarLivroToolStripMenuItem});
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // cadastrarLivroToolStripMenuItem
            // 
            this.cadastrarLivroToolStripMenuItem.Name = "cadastrarLivroToolStripMenuItem";
            this.cadastrarLivroToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cadastrarLivroToolStripMenuItem.Text = "Cadastrar Livro";
            this.cadastrarLivroToolStripMenuItem.Click += new System.EventHandler(this.CadastrarLivroToolStripMenuItem_Click);
            // 
            // excluirLivroToolStripMenuItem
            // 
            this.excluirLivroToolStripMenuItem.Name = "excluirLivroToolStripMenuItem";
            this.excluirLivroToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.excluirLivroToolStripMenuItem.Text = "Excluir Livro";
            this.excluirLivroToolStripMenuItem.Click += new System.EventHandler(this.ExcluirLivroToolStripMenuItem_Click);
            // 
            // consultarAcervoToolStripMenuItem
            // 
            this.consultarAcervoToolStripMenuItem.Name = "consultarAcervoToolStripMenuItem";
            this.consultarAcervoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.consultarAcervoToolStripMenuItem.Text = "Consultar Acervo";
            this.consultarAcervoToolStripMenuItem.Click += new System.EventHandler(this.ConsultarAcervoToolStripMenuItem_Click);
            // 
            // alterarLivroToolStripMenuItem
            // 
            this.alterarLivroToolStripMenuItem.Name = "alterarLivroToolStripMenuItem";
            this.alterarLivroToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.alterarLivroToolStripMenuItem.Text = "Alterar Livro";
            this.alterarLivroToolStripMenuItem.Click += new System.EventHandler(this.AlterarLivroToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEmpréstimoToolStripMenuItem,
            this.excluirEmpréstimoToolStripMenuItem,
            this.cadastraDevoluçãoToolStripMenuItem,
            this.consultarEmpréstimoToolStripMenuItem});
            this.eToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eToolStripMenuItem.Image")));
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.eToolStripMenuItem.Text = "Empréstimos";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.EToolStripMenuItem_Click);
            // 
            // cadastrarEmpréstimoToolStripMenuItem
            // 
            this.cadastrarEmpréstimoToolStripMenuItem.Name = "cadastrarEmpréstimoToolStripMenuItem";
            this.cadastrarEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.cadastrarEmpréstimoToolStripMenuItem.Text = "Cadastrar Empréstimo";
            this.cadastrarEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarEmpréstimoToolStripMenuItem_Click);
            // 
            // excluirEmpréstimoToolStripMenuItem
            // 
            this.excluirEmpréstimoToolStripMenuItem.Name = "excluirEmpréstimoToolStripMenuItem";
            this.excluirEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.excluirEmpréstimoToolStripMenuItem.Text = "Excluir Empréstimo";
            this.excluirEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.ExcluirEmpréstimoToolStripMenuItem_Click);
            // 
            // cadastraDevoluçãoToolStripMenuItem
            // 
            this.cadastraDevoluçãoToolStripMenuItem.Name = "cadastraDevoluçãoToolStripMenuItem";
            this.cadastraDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.cadastraDevoluçãoToolStripMenuItem.Text = "Cadastra Devolução";
            this.cadastraDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.CadastraDevoluçãoToolStripMenuItem_Click);
            // 
            // consultarEmpréstimoToolStripMenuItem
            // 
            this.consultarEmpréstimoToolStripMenuItem.Name = "consultarEmpréstimoToolStripMenuItem";
            this.consultarEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarEmpréstimoToolStripMenuItem.Text = "Consultar Empréstimo";
            this.consultarEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEmpréstimoToolStripMenuItem_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicial";
            this.Text = "Biblioteca Nassau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLeitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAcervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpréstimoToolStripMenuItem;
    }
}

