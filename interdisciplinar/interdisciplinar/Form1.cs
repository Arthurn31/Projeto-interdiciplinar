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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexaoBD bd = new ConexaoBD();
        Usuario user = new Usuario();
        string sql;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string cpf, senha;
            cpf = txt_cpf.Text;
            senha = txt_senha.Text;
            if (user.Logar(cpf, senha) == true)
            {
                string dado = user.cpfValidado();
                this.Visible = false;
                Form2 menu = new Form2();
                menu.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Falhou! tente novamente!!!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_ncarteira_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
