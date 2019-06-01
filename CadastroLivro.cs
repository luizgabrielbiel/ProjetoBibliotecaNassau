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
    public partial class CadastroLivro : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        public CadastroLivro()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtAutor.Text != "") && (txtGenero.Text != "") && (txtPaginas.Text != "") && (txtQuantidade.Text != ""))
            {

                try
                {
                    String strNome = txtNome.Text;
                    String strAutor = txtAutor.Text;
                    String strGenero = txtGenero.Text;
                    int intPaginas = Convert.ToInt32(txtPaginas.Text);
                    int intQuantidade = Convert.ToInt32(txtQuantidade.Text);


                    string inserir = @"insert into Livro (Nome, Autor, Genero, Paginas, Quantidade) values ('" + strNome + "','" + strAutor + "','" + strGenero + "','" + intPaginas + "','" + intQuantidade + "')";

                    SqlCommand _cmd = new SqlCommand(inserir, con);

                    // executa o comando

                    _cmd.ExecuteNonQuery();

                    //Fecha a conexão

                    con.Close();
                    //Exibe Mensagem!!

                    MessageBox.Show("LIVRO CADASTRADO COM SUCESSO!");

                    txtNome.Clear();
                    txtAutor.Clear();
                    txtQuantidade.Clear();
                    txtPaginas.Clear();


                }

                catch (System.FormatException)
                {
                    MessageBox.Show("Certifique-se que você digitou um número no(s) campo(s) Páginas/Quantidade");

                }

            }

            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtNome.Focus();
            }
        }

        private void TxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAutor.Clear();
            txtQuantidade.Clear();
            txtPaginas.Clear();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPagina_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
