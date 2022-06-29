using MySql.Data.MySqlClient;
using System.Data;
namespace interdisciplinar
{
    class ConexaoBD
    {
        private MySqlConnection conexao;
        public void ConectarBD()
        {
            conexao = new MySqlConnection("Persist security info = false; server = localhost; database= trabalho_interdiciplinar; uid = root; passwhord =;SslMode = none;");
            conexao.Open();
        }
        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }
        public DataTable ConsultarTabela(string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
