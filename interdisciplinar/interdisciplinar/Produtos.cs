using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace interdisciplinar
{
    class Produtos
    {
        public static string cod;
        public static string nome;
        public static string quantidade;
        public static string valor;
        public static string unidade;
        string sql;
        ConexaoBD bd = new ConexaoBD();
        
        public void procurarValores(string codigo)
        {
            DataTable result = new DataTable();
            sql = string.Format("select * from produto where cod = '{0}';", codigo);
            result = bd.ConsultarTabela(sql);
            if(result.Rows.Count > 0)
            {
                cod = result.Rows[0]["cod"].ToString();
                nome = result.Rows[0]["nome"].ToString();
                quantidade = result.Rows[0]["quantidade"].ToString();
                valor = result.Rows[0]["valor"].ToString();
                unidade = result.Rows[0]["unidade"].ToString();
            }
        }

        public string retornarCod()
        {
            return cod;
        }
        public string retornarNome()
        {
            return nome;
        }
        public string retornarQtn()
        {
            return quantidade;
        }
        public string retornarValor()
        {
            return valor;
        }
        public string retornarUnidade()
        {
            return unidade;
        }

    }
}
