using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace interdisciplinar
{
    class itensVenda
    {
        public static string cod;
        public static string qtn;
        public static string valor;
        public static string vendaNum;
        public static string produtoCod;

        string sql;
        ConexaoBD bd = new ConexaoBD();
        DataTable result = new DataTable();

        public void procurarValores(string codigo)
        {
            DataTable result = new DataTable();
            sql = string.Format("select * from itens_venda where venda_numero_venda = '{0}';",codigo);
            result = bd.ConsultarTabela(sql);
            if(result.Rows.Count > 0)
            {
                cod = result.Rows[0]["cod"].ToString();
                qtn = result.Rows[0]["quantidade"].ToString();
                valor = result.Rows[0]["valor"].ToString();
                vendaNum = result.Rows[0]["venda_numero_venda"].ToString();
                produtoCod = result.Rows[0]["produto_cod"].ToString();
            }
        }
        public string retornarCod()
        {
            return cod;
        }
        public string retornarQtn()
        {
            return qtn;
        }
        public string retornarValor()
        {
            return valor;
        }
        public string retornarVendaNum()
        {
            return vendaNum;
        }
        public string retornarProdutoCod()
        {
            return produtoCod;
        }
    }
}
