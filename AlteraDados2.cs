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
    public partial class AlteraDados2 : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        public AlteraDados2()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
        }

        public void recebedados(string strNome, int intId, string strEndereco, int intNumero, string strCpf, string strTelefone)
        {

            //Criando os atributos
            txtID.Text = Convert.ToString(intId);
            txtNome.Text = strNome;
            txtEndereco.Text = strEndereco;
            txtNumero.Text = Convert.ToString(intNumero);
            txtCPF.Text = strCpf;
            txtTelefone.Text = strTelefone;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Atualizando os dados no banco
            int intId = Convert.ToInt16(txtID.Text);
            string strNome = txtNome.Text;
            string strEndereco = txtEndereco.Text;
            int intNumero = Convert.ToInt16(txtNumero.Text);
            string strCpf = txtCPF.Text;
            string strTelefone = txtTelefone.Text;
            string alterar = @"UPDATE Aluno SET Nome = '" + strNome + "', Endereco = '" + strEndereco + "', Numero='" + intNumero + "', CPF='" + strCpf + "', Telefone='" + strTelefone + "' WHERE id_Aluno ='" + intId + "';";
            SqlCommand _cmd = new SqlCommand(alterar, con);

            _cmd.ExecuteNonQuery(); con.Close();


            MessageBox.Show("Atualização Realizada Com Sucesso!!!");
        }
    }
}
