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
    public partial class ExcluirAluno : Form
    {

        SqlConnection con;
        bancodedados banco = new bancodedados();
        int codigo_leitor;

        public ExcluirAluno()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
            btnExcluir.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExcluirAluno_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            String strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Id_Aluno, Endereco, Numero, CPF, Telefone FROM Aluno where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Deleta registro

                String nome = txtNome.Text;
                string deletar = @"DELETE FROM Aluno WHERE Id_Aluno='" + codigo_leitor + "';";

                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtNome.Text = "";

                //Atualiza Data

                string selecionar = @"SELECT Nome, Id_Aluno, Endereco, Numero, CPF, Telefone FROM Aluno";
                SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
                DataTable t = new DataTable();
                a.Fill(t);
                data.DataSource = t;
                btnExcluir.Enabled = false;
            }

        }

        private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
        {
            codigo_leitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }
    }
}
