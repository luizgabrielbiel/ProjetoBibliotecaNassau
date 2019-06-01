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
    public partial class ExcluirEmprestimo : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int codigo_emprestimo;


        public ExcluirEmprestimo()
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Deleta registro


                string deletar = @"DELETE FROM Emprestimo WHERE Id_Emprestimo='" + codigo_emprestimo + "';";

                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtNome.Text = "";

                //Atualiza Data
                string strNome = txtNome.Text;
                string selecionar = @"SELECT Aluno, Livro, Retirada, Devolucao, Id_Emprestimo FROM Emprestimo where Aluno like '%" + strNome + "%'";
                SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
                DataTable t = new DataTable();
                a.Fill(t);
                data.DataSource = t;
                btnExcluir.Enabled = false;

            }
        }

        private void selecionarEmprestimo(object sender, DataGridViewCellEventArgs e)
        {

            codigo_emprestimo = Convert.ToInt32(data.Rows[e.RowIndex].Cells[4].Value);
            btnExcluir.Enabled = true;
        }
    }
}
