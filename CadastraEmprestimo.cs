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
    public partial class CadastraEmprestimo : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int selecao, intIDLeitor, intIDLivro;
        string strLeitor, strLivro, strRetirada, strDevolucao;

        private void cadastraCampos(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {

                intIDLeitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
                txtIDLeitor.Text = Convert.ToString(intIDLeitor);
                strLeitor = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
                lblLeitor.Text = strLeitor;

            }

            if (selecao == 2)
            {

                intIDLivro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
                txtIDLivro.Text = Convert.ToString(intIDLivro);
                strLivro = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
                lblLivro.Text = strLivro;

            }
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtIDLivro.Text != "") && (txtIDLeitor.Text != ""))
            {


                strLeitor = lblLeitor.Text;
                strLivro = lblLivro.Text;
                intIDLeitor = Convert.ToInt32(txtIDLeitor.Text);
                intIDLivro = Convert.ToInt32(txtIDLivro.Text);
                strRetirada = txtRetirada.Text;
                strDevolucao = txtDevolucao.Text;



                string inserir = @"insert into Emprestimo (Id_Leitor, Id_Livro, Aluno, Livro, Retirada, Devolucao) values ('" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "','" + strRetirada + "', '" + strDevolucao + "')";

                SqlCommand _cmd = new SqlCommand(inserir, con);

                // Executa o comando

                _cmd.ExecuteNonQuery();

                //Fecha a conexão

                con.Close();
                //Exibe Mensagem!!

                MessageBox.Show("Emprestimo cadastrado com Sucesso!");
                txtLeitor.Clear();
                txtLivro.Clear();
                txtIDLeitor.Clear();
                txtIDLivro.Clear();
                txtRetirada.Clear();
                txtDevolucao.Clear();
                txtLeitor.Focus();
                

            }

            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtLeitor.Focus();
            }
        }

        private void TxtDevolucao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            strLivro = txtLivro.Text;

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strLivro + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;


            selecao = 2;
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            strLeitor = txtLeitor.Text;

            string selecionar = @"SELECT Nome, Id_Aluno, Endereco, Numero, CPF, Telefone FROM Aluno where Nome like '%" + strLeitor + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

            selecao = 1;
        }

        public CadastraEmprestimo()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
            txtRetirada.Text = DateTime.Now.ToShortDateString();
            txtDevolucao.Text = DateTime.Now.AddDays(7).ToShortDateString();
        }

        private void LblLeitor_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
