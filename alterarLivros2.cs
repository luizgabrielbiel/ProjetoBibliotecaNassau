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
    public partial class alterarLivros2 : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        public alterarLivros2()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
        }
        public void recebedados(string strNome, int intId, string strAutor, string strGenero, int intPaginas, int intQuantidade)
        {

            txtID.Text = Convert.ToString(intId);
            txtNome.Text = strNome;
            txtAutor.Text = strAutor;
            txtGenero.Text = strGenero;
            txtPaginas.Text = Convert.ToString(intPaginas);
            txtQuantidade.Text = Convert.ToString(intQuantidade);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int intId = Convert.ToInt16(txtID.Text);
            string strNome = txtNome.Text;
            string strAutor = txtAutor.Text;
            string strGenero = txtGenero.Text;
            int intPaginas = Convert.ToInt32(txtPaginas.Text);
            int intQuantidade = Convert.ToInt32(txtQuantidade.Text);

            string alterar = @"UPDATE Livro SET Nome = '" + strNome + "', Autor = '" + strAutor + "', Genero='" + strGenero + "', Paginas='" + intPaginas + "', Quantidade='" + intQuantidade + "' WHERE id_Livro ='" + intId + "';";
            SqlCommand _cmd = new SqlCommand(alterar, con);

            _cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Atualização Realizada Com Sucesso!!!");
        }
    }
}
