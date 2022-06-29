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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        Usuario user = new Usuario();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmprodutos cad = new frmprodutos();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btnItensVenda_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmintensvenda cad = new frmintensvenda();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmvendas cad = new frmvendas();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_nomeUser.Text += " " + user.nomeValidado();
            if (user.cargoValidado() != "adm")
            {
                btnEstatisticas.Enabled = false;
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEstatisticas estatisticas = new frmEstatisticas();
            estatisticas.ShowDialog();
            this.Visible = true;
        }
    }
}
