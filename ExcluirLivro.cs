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
    public partial class ExcluirLivro : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int codigo_livro;
        public ExcluirLivro()
        {
            InitializeComponent();
            con = banco.Abrir_conexao();
            btnExcluir.Enabled = false;
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        private void selecionaRegistro(object sender, DataGridViewCellEventArgs e)
        {
            codigo_livro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Deleta registro


                string deletar = @"DELETE FROM Livro WHERE Id_Livro='" + codigo_livro + "';";

                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtNome.Text = "";

                //Atualiza Data
                string strNome = txtNome.Text;
                string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

                SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
                DataTable t = new DataTable();
                a.Fill(t);
                data.DataSource = t;
                btnExcluir.Enabled = false;

            }
        }
    }
}
