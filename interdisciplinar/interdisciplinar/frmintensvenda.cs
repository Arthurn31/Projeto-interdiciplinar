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
    public partial class frmintensvenda : Form
    {
        public frmintensvenda()
        { 
            InitializeComponent();
            

        }
        
        ConexaoBD bd = new ConexaoBD();
        Produtos prd = new Produtos();
        Vendas ClasseVenda = new Vendas();
        Usuario usr = new Usuario();
        DataTable result = new DataTable();
        string sql;

        public void limpar()
        {
            txt_codigo.Clear();
            txt_quantidade.Clear();
            lbl_valor.Text = "Valor: ";
            txt_nvenda.Clear();
            txt_cdgproduto.Clear();
        }
        public void listar()
        { 
            sql = "select * from itens_venda";
            dgv_listar.DataSource = bd.ConsultarTabela(sql);
        }
        public string abrirForm(string usuarioCpf)
        {
            sql = string.Format("select * from venda where usuarios_cpf = '{0}' and valor = '0';", usuarioCpf);
            result = bd.ConsultarTabela(sql);
            if(result.Rows.Count > 0)
            {
                string enviarDado = result.Rows[0]["numero_venda"].ToString();
                return enviarDado;
            }
            else
            {
                return "ERRO!";
            }
            
        }
        

        private void btn_novo_Click(object sender, EventArgs e)
        {
            prd.procurarValores(txt_cdgproduto.Text);
            float valorProd =float.Parse(prd.retornarValor());
            float valorTotal = valorProd * int.Parse(txt_quantidade.Text);
            int qtnProd = int.Parse(prd.retornarQtn());
            string numVenda = txt_nvenda.Text;
            if (string.IsNullOrEmpty(numVenda))
            {
                numVenda = abrirForm(usr.cpfValidado());
            }
            ClasseVenda.adicionarValor(numVenda);
            if (qtnProd >= int.Parse(txt_quantidade.Text)){
                sql = string.Format("insert into itens_venda values (null, '{0}', '{1}' ,'{2}','{3}');", txt_quantidade.Text, valorTotal, numVenda, txt_cdgproduto.Text);
                bd.AlterarTabelas(sql);
                qtnProd -= int.Parse(txt_quantidade.Text);
                sql = string.Format("update produto set quantidade = '{0}' where cod = '{1}';", qtnProd, prd.retornarCod());
                bd.AlterarTabelas(sql);
                ClasseVenda.somarValor();
                MessageBox.Show("Itens a serem vendidos cadastrados com sucesso!", "Cadastro de Intens a venda.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listar();
                limpar();
            }
            else
            { 
                MessageBox.Show("Não é possivel fazer a venda os produtos no estoque não são o suficiente!","Quantidade Insuficiente!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmintensvenda_Load(object sender, EventArgs e)
        {
            listar();
            limpar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from itens_venda where cod = '{0}' or venda_numero_venda = '{1}'", txt_codigo.Text, txt_nvenda.Text);
            buscar = bd.ConsultarTabela(sql);

            if(buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["cod"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                lbl_valor.Text += buscar.Rows[0]["valor"].ToString();
                txt_nvenda.Text = buscar.Rows[0]["venda_numero_venda"].ToString();
                txt_cdgproduto.Text = buscar.Rows[0]["produto_cod"].ToString();
            }
            else
            {
                MessageBox.Show("Lista de Itens não cadastrada no sistema","Itens Venda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();            
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            prd.procurarValores(txt_cdgproduto.Text);
            float valorProd = float.Parse(prd.retornarValor());
            float valorTotal = valorProd * int.Parse(txt_quantidade.Text);
            int qtnProd = int.Parse(prd.retornarQtn());
            if(qtnProd >= int.Parse(txt_quantidade.Text))
            {
                sql = string.Format("update itens_venda set quantidade = '{0}',valor = '{1}', venda_numero_venda = '{2}', produto_cod = '{3}';", txt_quantidade.Text, valorTotal, txt_nvenda.Text, txt_cdgproduto.Text);
                bd.AlterarTabelas(sql);
                MessageBox.Show("Cadastro de itens Alterado com sucesso!!!", "itens venda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
                limpar();
            }
            else
            {
                MessageBox.Show("Não é possivel fazer a venda os produtos no estoque não são o suficiente!", "Quantidade Insuficiente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from itens_venda where cod = '{0}';", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("cadastro de Item venda deletado com sucesso!", "Excluir Item.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_quantidade.Text = dgv_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_valor.Text += dgv_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nvenda.Text = dgv_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_cdgproduto.Text = dgv_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void lbl_valor_Click(object sender, EventArgs e)
        {

        }
    }
}
