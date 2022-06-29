using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace interdisciplinar
{
    class Usuario
    {
        private static string cpf;
        public static string nome;
        public static string cargo;
        public static string dtNasc;
        private static string senha;
       
        ConexaoBD bd = new ConexaoBD();

        public bool Logar(string UserCpf,string senha)
        {
            string sql = string.Format("select * from usuarios where cpf = '{0}' and senha = '{1}';", UserCpf, senha);
            DataTable consultar = new DataTable();
            consultar = bd.ConsultarTabela(sql);
            if(consultar.Rows.Count > 0)
            {
                cpf = consultar.Rows[0]["cpf"].ToString();
                nome = consultar.Rows[0]["nome"].ToString();
                cargo = consultar.Rows[0]["cargo"].ToString();
                dtNasc = consultar.Rows[0]["data_nasct"].ToString();
                senha = consultar.Rows[0]["senha"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string nomeValidado()
        {
            return nome; 
        }
        public string cargoValidado()
        {
            return cargo;
        }
        public string dataNascValidado()
        {
            return dtNasc;
        }
        public string cpfValidado()
        {
            return cpf;
        }
    }
}
