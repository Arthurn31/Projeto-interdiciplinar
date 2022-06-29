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
    public partial class frmvendas : Form
    {
        public frmvendas()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        Usuario user = new Usuario();
        itensVenda itv = new itensVenda();
        string sql;
        DataTable result = new DataTable();
        DateTime dataEntrega, dataVenda;
   

        public void limpar()
        {
            txt_nvenda.Clear();
            lbl_usrCpf.Text = "Cpf do Usuario";
            lbl_valor.Text = "Valor: ";
            txt_cpfcliente.Clear();
            dtp_entrega.Text = DateTime.Now.ToString();
        }
        public void listar()
        {
            sql = "select * from venda";
            dgv_listar.DataSource = bd.ConsultarTabela(sql);
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            dataEntrega = DateTime.Parse(dtp_entrega.Text);
            dataVenda = DateTime.Parse(dtp_venda.Text);
            sql = string.Format("insert into venda values(null, '{0}', '000', '{1}', '{2}', '{3}', '{4}');", dataVenda.ToString("yyyy-MM-dd"),dataEntrega.ToString("yyyy-MM-dd"), cbx_tipoVenda.Text, user.cpfValidado(), txt_cpfcliente.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Agora adicione os Itens que estarão sendo vendidos!","ADICIONAR ITENS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmintensvenda itnvenda = new frmintensvenda();
            itnvenda.ShowDialog();


            /* itv.procurarValores(txt_nvenda.Text);
            float valor = itv.SomaValor();
            sql = string.Format("insert into venda values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", dataVenda.ToString("yyyy-MM-dd"),valor, dataEntrega.ToString("yyyy-MM-dd"), cbx_tipoVenda.Text, int.Parse(user.cpfValidado()), txt_cpfcliente.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Venda cadastrada com sucesso!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar(); */
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataEntrega = DateTime.Parse(dtp_entrega.Text);
            dataVenda = DateTime.Parse(dtp_venda.Text);
            DataTable buscar = new DataTable();
            sql = string.Format("select * from venda where numero_venda = '{0}'", txt_nvenda.Text);
            buscar = bd.ConsultarTabela(sql);

            if (buscar.Rows.Count > 0)
            {
                txt_nvenda.Text = buscar.Rows[0]["numero_venda"].ToString();
                dtp_venda.Text = buscar.Rows[0]["dt_venda"].ToString();
                lbl_valor.Text = buscar.Rows[0]["valor"].ToString();
                dtp_entrega.Text = buscar.Rows[0]["dt_entrega"].ToString();
                txt_cpfcliente.Text = buscar.Rows[0]["cliente_cpf"].ToString();
                listar();
            }
            else
            {
                MessageBox.Show("Venda não cadastrada no sistema", "Venda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            dataEntrega = DateTime.Parse(dtp_entrega.Text);
            dataVenda = DateTime.Parse(dtp_venda.Text);
            itv.procurarValores(txt_nvenda.Text);
            sql = string.Format("update venda set dt_venda = '{0}', valor = '{1}', dt_entrega = '{2}', usuarios_cpf = '{3}', cliente_cpf = '{4}';",dataVenda.ToString("yyyy-MM-dd"), 0, dataEntrega.ToString("yyyy-MM-dd"),user.cpfValidado(), txt_cpfcliente.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro de Venda Alterado com sucesso!!!", "Venda.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            sql = string.Format("delete from venda where numero_venda = '{0}';", txt_nvenda.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro venda deletado com secesso!","Cadastro Vendas",MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void dgv_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nvenda.Text = dgv_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtp_venda.Text = dgv_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_valor.Text = dgv_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtp_entrega.Text = dgv_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbx_tipoVenda.Text = dgv_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
            lbl_usrCpf.Text += ": " + dgv_listar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cpfcliente.Text = dgv_listar.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void frmvendas_Load(object sender, EventArgs e)
        {
            limpar();
            listar();
        }
    }
}
