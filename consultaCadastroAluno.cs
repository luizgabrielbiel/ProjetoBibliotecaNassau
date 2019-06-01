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
    public partial class consultaCadastroAluno : Form
    {
        public consultaCadastroAluno()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            bancodedados banco = new bancodedados();

            SqlConnection con;
            con = banco.Abrir_conexao();

            String strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Endereco, Numero, CPF, Telefone FROM Aluno where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }
    }
}
