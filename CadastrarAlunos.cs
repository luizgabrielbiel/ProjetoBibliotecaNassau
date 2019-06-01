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
    public partial class CadastrarAlunos : Form
    {
        public CadastrarAlunos()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if ((txtNome.Text != "") && (txtEndereco.Text != "") && (txtNumero.Text != "") && (txtCPF.Text != "") && (txtTelefone.Text != ""))
            {
                try
                {

                    //Define os Atributos
                    String strNome = txtNome.Text;
                    String strEndereco = txtEndereco.Text;
                    int intNumero = Convert.ToInt32(txtNumero.Text);
                    String strCPF = txtCPF.Text;
                    String strTelefoe = txtTelefone.Text;


                    bancodedados banco = new bancodedados();

                    SqlConnection con;

                    con = banco.Abrir_conexao();


                    string inserir = @"insert into Aluno (Nome, Endereco, Numero, CPF, Telefone) values ('" + strNome + "','" + strEndereco + "','" + intNumero + "','" + strCPF + "','" + strTelefoe + "')";


                    SqlCommand _cmd = new SqlCommand(inserir, con);

                    //executa o comando

                    _cmd.ExecuteNonQuery();

                    //Fecha a conexão

                    con.Close();

                    //Exibe Mensagem!!

                    MessageBox.Show("ALUNO CADASTRADO COM SUCESSO!");
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtNumero.Clear();
                    txtCPF.Clear();
                    txtTelefone.Clear();
                    txtNome.Focus();
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Certifique-se de que digitou um número no campo Nª ");
                    txtNumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("CERTIFIQUE-SE QUE TODOS OS CAMPOS FORAM PREENCHIDOS! ");
                txtNome.Focus();

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }
    }
}
