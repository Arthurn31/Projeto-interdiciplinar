using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace interdisciplinar
{
    class Vendas
    {
        public static string numero_venda;
        public static string valor;
        ConexaoBD bd = new ConexaoBD();
      
        public void adicionarValor(string NumVenda)
        {
            DataTable buscar = new DataTable();
            string sql =string.Format("select * from venda where numero_venda = '{0}';",NumVenda);
            buscar = bd.ConsultarTabela(sql);
            valor = buscar.Rows[0]["valor"].ToString();
            numero_venda = buscar.Rows[0]["numero_venda"].ToString();
        }
        public void somarValor()
        {
            string sql = string.Format("select sum(valor) from itens_venda where venda_numero_venda = '{0}'",numero_venda);
            DataTable result = new DataTable();
            result = bd.ConsultarTabela(sql);
            string valor = result.Rows[0][0].ToString();
            string valorTotal = valor;
            sql = string.Format("UPDATE `trabalho_interdiciplinar`.`venda` SET `valor` = '{0}' WHERE (`numero_venda` = '{1}');", valorTotal, numero_venda);
            bd.AlterarTabelas(sql);
        }
        public string retornarNumVenda() 
        {
            return numero_venda;
        }


    }
}
