using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Biblioteca_Nassau
{
    public partial class ConsultarEmprestimo : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();

        public ConsultarEmprestimo()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT Aluno, Livro, Retirada, Devolucao, Id_Emprestimo FROM Emprestimo where Aluno like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }
    }
}
