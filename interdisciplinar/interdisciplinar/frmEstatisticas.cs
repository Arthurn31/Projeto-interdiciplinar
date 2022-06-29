using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar
{
    public partial class frmEstatisticas : Form
    {
        public frmEstatisticas()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        Produtos prd = new Produtos();
        Vendas vendas = new Vendas();
        string sql;
        DataTable buscar = new DataTable();


        private void frmEstatisticas_Load(object sender, EventArgs e)
        {
            DateTime dtHoje = DateTime.Today;
            sql = string.Format("select sum(valor) from venda where dt_venda = '{0}';", dtHoje.ToString("yyyy-MM-dd"));
            buscar = bd.ConsultarTabela(sql);
            lbl_rendaTotal.Text +=" R$ "+buscar.Rows[0][0].ToString();

            sql = string.Format("select produto.nome , sum(itens_venda.quantidade) from produto join itens_venda on produto.cod = itens_venda.produto_cod group by produto_cod order by min(itens_venda.quantidade) asc;");
            buscar = bd.ConsultarTabela(sql);
            lbl_PdrMenosVendido.Text += " " + buscar.Rows[0][0].ToString();

            sql = string.Format("select produto.nome , sum(itens_venda.quantidade) from produto join itens_venda on produto.cod = itens_venda.produto_cod group by produto_cod order by min(itens_venda.quantidade) desc;");
            buscar = bd.ConsultarTabela(sql);
            lbl_PdrMaisVendido.Text += " " + buscar.Rows[0][0].ToString();

            sql = "select count(*) from produto where quantidade < 50 ;";
            buscar = bd.ConsultarTabela(sql);
            int i = int.Parse(buscar.Rows[0][0].ToString());
            for(int cont = 0; cont < i; cont++)
            {
                sql = "select * from produto where quantidade < 50";
                buscar = bd.ConsultarTabela(sql);
                ltx_produtosFaltantes.Items.Add(buscar.Rows[cont]["nome"].ToString());
            }
            
        }
    }
}
