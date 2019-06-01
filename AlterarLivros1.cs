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
    public partial class AlterarLivros1 : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();


        int intId, intPaginas, intQuantidade;

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            string strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

        }

        private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
        {
            strNome = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
            intId = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            strAutor = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            strGenero = Convert.ToString(data.Rows[e.RowIndex].Cells[3].Value);
            intPaginas = Convert.ToInt32(data.Rows[e.RowIndex].Cells[4].Value);
            intQuantidade = Convert.ToInt32(data.Rows[e.RowIndex].Cells[5].Value);

            btnAlterar.Enabled = true;

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            alterarLivros2 frmAlteraLivro2 = new alterarLivros2();
            frmAlteraLivro2.recebedados(strNome, intId, strAutor, strGenero, intPaginas, intQuantidade);
            frmAlteraLivro2.Show();
            this.Close();
        }

        string strNome, strAutor, strGenero;
        public AlterarLivros1()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
            btnAlterar.Enabled = false;
        }
    }
}
