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
    public partial class CadastraDevolução : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int intIDEmprestimo, intIDLeitor, intIDLivro;

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {

            strLeitor = txtLeitor.Text;

            string selecionar = @"SELECT Aluno, Livro, Retirada, Devolucao, Id_Emprestimo, Id_Leitor, Id_Livro FROM Emprestimo where Aluno like '%" + strLeitor + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        private void verificaLivros(object sender, DataGridViewCellEventArgs e)
        {

            strLeitor = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
            lblLeitor.Text = strLeitor;


            strLivro = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
            lblLivro.Text = strLivro;

            strRetirada = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            txtEmprestimo.Text = strRetirada;

            strDevolucao = Convert.ToString(data.Rows[e.RowIndex].Cells[3].Value);
            txtDevolucao.Text = strDevolucao;

            intIDEmprestimo = Convert.ToInt32(data.Rows[e.RowIndex].Cells[4].Value);

            intIDLeitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[5].Value);
            txtIDLeitor.Text = Convert.ToString(intIDLeitor);

            intIDLivro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[6].Value);
            txtIDLivro.Text = Convert.ToString(intIDLivro);

            DateTime atual = DateTime.Now;
            DateTime devolucao = Convert.ToDateTime(strDevolucao);
            int result = DateTime.Compare(devolucao, atual);

            if (result < 0)
            {
                TimeSpan resultado = atual - devolucao;
                Double multa = resultado.Days * 1.3;
                txtDias.Text = Convert.ToString(resultado.Days);
                txtMulta.Text = Convert.ToString(multa);
            }
            else
            {
                txtDias.Text = Convert.ToString("0");
                txtMulta.Text = Convert.ToString("");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            intIDLeitor = Convert.ToInt32(txtIDLeitor.Text);
            intIDLivro = Convert.ToInt32(txtIDLivro.Text);
            strLeitor = lblLeitor.Text;
            strLivro = lblLivro.Text;
            strRetirada = txtEmprestimo.Text;
            strDevolucao = txtDevolucao.Text;


            string inserir = @"insert into Devolucao (Id_Emprestimo, Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) values ('" + intIDEmprestimo + "','" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "', '" + strRetirada + "', '" + strDevolucao + "')";
            string excluir = @"DELETE FROM Emprestimo WHERE Id_Emprestimo='" + intIDEmprestimo + "';";

            SqlCommand _cmd = new SqlCommand(inserir, con);
            SqlCommand _cmd2 = new SqlCommand(excluir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();
            _cmd2.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
            //Exibe Mensagem!!

            MessageBox.Show("Devolução cadastrada com Sucesso!");
            txtLeitor.Clear();
            txtIDLivro.Clear();
            txtIDLeitor.Clear();
            txtDevolucao.Clear();
            txtDias.Clear();
            txtEmprestimo.Clear();
            txtMulta.Clear();

        }

        string strLeitor, strLivro, strRetirada, strDevolucao;
        public CadastraDevolução()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
        }
    }
}
