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
    public partial class AlteraDados1 : Form
    {
        //Conectando o banco de dados
        SqlConnection con;
        bancodedados banco = new bancodedados();

        int intId, intNumero;
        string strNome, strEndereco, strCpf, strTelefone;

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
        {
            //Armazenando os valores
            strNome = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
            intId = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            strEndereco = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            intNumero = Convert.ToInt32(data.Rows[e.RowIndex].Cells[3].Value);
            strCpf = Convert.ToString(data.Rows[e.RowIndex].Cells[4].Value);
            strTelefone = Convert.ToString(data.Rows[e.RowIndex].Cells[5].Value);

            btnAlterar.Enabled = true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            AlteraDados2 frmAlteraLeitor2 = new AlteraDados2();
            frmAlteraLeitor2.recebedados(strNome, intId, strEndereco, intNumero, strCpf, strTelefone);
            frmAlteraLeitor2.Show();
            this.Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Id_Aluno, Endereco, Numero, CPF, Telefone FROM Aluno where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        public AlteraDados1()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
            btnAlterar.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
