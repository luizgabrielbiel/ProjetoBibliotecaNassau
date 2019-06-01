using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Biblioteca_Nassau
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Chamando outra tela
        private void AlterarLeitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlteraDados1 frmAlterarDados1 = new AlteraDados1();
            frmAlterarDados1.Show();
        }

        //Instanciando a tela Cadastrar Alunos
        private void CadastrarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAlunos frmCadastrarAlunos = new CadastrarAlunos();
            frmCadastrarAlunos.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Instanciando a tela Consulta Aluno
        private void ConsultarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            consultaCadastroAluno frmConsultaAluno = new consultaCadastroAluno();
            frmConsultaAluno.Show();
        }
        //Instanciando a tela Excluir Aluno

        private void ExcluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirAluno frmExcluirAluno = new ExcluirAluno();
            frmExcluirAluno.Show();
        }
        //Instanciando a tela Cadastrar Livro

        private void CadastrarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLivro frmCadastroLivro = new CadastroLivro();
            frmCadastroLivro.Show();
        }

        //Instanciando a tela Consultar Acervo
        private void ConsultarAcervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLivro frmconsultalivro = new ConsultarLivro();
            frmconsultalivro.Show();
        }

        //Instanciando a tela Excluir Livro
        private void ExcluirLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirLivro frmExcluir = new ExcluirLivro();
            frmExcluir.Show();

        }

        //Instanciando a tela Alterar Livro
        private void AlterarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarLivros1 frmAlterarLivros = new AlterarLivros1();
            frmAlterarLivros.Show();

        }
        //Instanciando a tela Cadastrar Emprestimo
        private void CadastrarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraEmprestimo frmCadastraEmprestimo = new CadastraEmprestimo();
            frmCadastraEmprestimo.Show();
        }

        //Instanciando a tela Cadastra Devolução
        private void CadastraDevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraDevolução frmCadastraDevolucao = new CadastraDevolução();
            frmCadastraDevolucao.Show();

        }
        //Instanciando a tela Consulta Emprestimo
        private void ConsultarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEmprestimo frmConsultaEmprestimo = new ConsultarEmprestimo();
            frmConsultaEmprestimo.Show();

        }

        //Instanciando a tela Excluir Emprestimo
        private void ExcluirEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirEmprestimo frmExcluirEmprestimo = new ExcluirEmprestimo();
            frmExcluirEmprestimo.Show();
        }
    }
}
