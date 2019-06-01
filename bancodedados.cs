using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Biblioteca_Nassau
{
    class bancodedados
    {
        SqlConnection con;
        public SqlConnection Abrir_conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabri\source\repos\Projeto Biblioteca Nassau\Projeto Biblioteca Nassau\bdBiblioteca.mdf;Integrated Security=True";

            con.Open();
            return con;
        }

        public void Fechar_conexao(SqlConnection con)
        {
            con.Close();
        }

    }
}
