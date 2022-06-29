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
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();

        }
        ConexaoBD bd = new ConexaoBD();
        string sql;
        Produtos prd = new Produtos();

        public void limpar()
        {
            txt_nome.Clear();
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
            txt_unidade.Clear();
        }

        public void listar()
        {
            sql = "select * from produto";
            dgv_listar.DataSource = bd.ConsultarTabela(sql);
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            sql =string.Format("insert into produto values (null, '{0}', '{1}', '{2}', '{3}');",txt_nome.Text, txt_quantidade.Text, txt_valor.Text, txt_unidade.Text);
            bd.AlterarTabelas(sql);

            MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro de produtos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from produto where cod = '{0}' or nome = '{1}' ", txt_codigo.Text, txt_nome.Text);
            buscar = bd.ConsultarTabela(sql);

            if(buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["cod"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                txt_valor.Text = buscar.Rows[0]["valor"].ToString();
                txt_unidade.Text = buscar.Rows[0]["unidade"].ToString();
            }
            else
            {
                MessageBox.Show("Produto não cadastrado no sitema", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update produto set nome = '{0}', quantidade = '{1}', valor = '{2}', unidade ='{3}';", txt_nome.Text, txt_quantidade.Text, txt_valor.Text, txt_unidade.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro de Produto Alterado com sucesso!!!", "Produto.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from produto where cod = '{0}';", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro de produto deletado com sucesso!", "Excluir item.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void frmprodutos_Load(object sender, EventArgs e)
        {
            listar();
            limpar();
        }

        private void dgv_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_quantidade.Text = dgv_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_valor.Text = dgv_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_unidade.Text = dgv_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
