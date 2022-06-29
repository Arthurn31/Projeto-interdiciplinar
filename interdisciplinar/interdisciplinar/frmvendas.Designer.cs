namespace interdisciplinar
{
    partial class frmvendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvendas));
            this.lbl_nvenda = new System.Windows.Forms.Label();
            this.lbl_dtvenda = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_dtentrega = new System.Windows.Forms.Label();
            this.lbl_cpfcliente = new System.Windows.Forms.Label();
            this.txt_nvenda = new System.Windows.Forms.TextBox();
            this.txt_cpfcliente = new System.Windows.Forms.TextBox();
            this.dtp_venda = new System.Windows.Forms.DateTimePicker();
            this.dtp_entrega = new System.Windows.Forms.DateTimePicker();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            this.lbl_usrCpf = new System.Windows.Forms.Label();
            this.lbl_tipoVenda = new System.Windows.Forms.Label();
            this.cbx_tipoVenda = new System.Windows.Forms.ComboBox();
            this.btnRecarregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nvenda
            // 
            this.lbl_nvenda.AutoSize = true;
            this.lbl_nvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nvenda.Location = new System.Drawing.Point(93, 24);
            this.lbl_nvenda.Name = "lbl_nvenda";
            this.lbl_nvenda.Size = new System.Drawing.Size(94, 20);
            this.lbl_nvenda.TabIndex = 0;
            this.lbl_nvenda.Text = "N° da venda";
            // 
            // lbl_dtvenda
            // 
            this.lbl_dtvenda.AutoSize = true;
            this.lbl_dtvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtvenda.Location = new System.Drawing.Point(268, 24);
            this.lbl_dtvenda.Name = "lbl_dtvenda";
            this.lbl_dtvenda.Size = new System.Drawing.Size(113, 20);
            this.lbl_dtvenda.TabIndex = 1;
            this.lbl_dtvenda.Text = "Data da venda";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(535, 45);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(54, 20);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor: ";
            // 
            // lbl_dtentrega
            // 
            this.lbl_dtentrega.AutoSize = true;
            this.lbl_dtentrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dtentrega.Location = new System.Drawing.Point(365, 93);
            this.lbl_dtentrega.Name = "lbl_dtentrega";
            this.lbl_dtentrega.Size = new System.Drawing.Size(125, 20);
            this.lbl_dtentrega.TabIndex = 3;
            this.lbl_dtentrega.Text = "Data da entrega";
            // 
            // lbl_cpfcliente
            // 
            this.lbl_cpfcliente.AutoSize = true;
            this.lbl_cpfcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpfcliente.Location = new System.Drawing.Point(639, 96);
            this.lbl_cpfcliente.Name = "lbl_cpfcliente";
            this.lbl_cpfcliente.Size = new System.Drawing.Size(112, 20);
            this.lbl_cpfcliente.TabIndex = 5;
            this.lbl_cpfcliente.Text = "CPF do cliente";
            // 
            // txt_nvenda
            // 
            this.txt_nvenda.Location = new System.Drawing.Point(97, 47);
            this.txt_nvenda.Name = "txt_nvenda";
            this.txt_nvenda.Size = new System.Drawing.Size(100, 20);
            this.txt_nvenda.TabIndex = 6;
            // 
            // txt_cpfcliente
            // 
            this.txt_cpfcliente.Location = new System.Drawing.Point(643, 119);
            this.txt_cpfcliente.Name = "txt_cpfcliente";
            this.txt_cpfcliente.Size = new System.Drawing.Size(100, 20);
            this.txt_cpfcliente.TabIndex = 9;
            // 
            // dtp_venda
            // 
            this.dtp_venda.Location = new System.Drawing.Point(272, 47);
            this.dtp_venda.Name = "dtp_venda";
            this.dtp_venda.Size = new System.Drawing.Size(212, 20);
            this.dtp_venda.TabIndex = 10;
            // 
            // dtp_entrega
            // 
            this.dtp_entrega.Location = new System.Drawing.Point(369, 116);
            this.dtp_entrega.Name = "dtp_entrega";
            this.dtp_entrega.Size = new System.Drawing.Size(212, 20);
            this.dtp_entrega.TabIndex = 11;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(502, 340);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(115, 73);
            this.btn_voltar.TabIndex = 23;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(643, 340);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(115, 73);
            this.btn_excluir.TabIndex = 22;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(361, 340);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(115, 73);
            this.btn_alterar.TabIndex = 21;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(220, 340);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 73);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(79, 340);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(115, 73);
            this.btn_novo.TabIndex = 19;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgv_listar
            // 
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.Location = new System.Drawing.Point(30, 145);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(794, 178);
            this.dgv_listar.TabIndex = 18;
            this.dgv_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_CellContentClick);
            // 
            // lbl_usrCpf
            // 
            this.lbl_usrCpf.AutoSize = true;
            this.lbl_usrCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usrCpf.Location = new System.Drawing.Point(94, 108);
            this.lbl_usrCpf.Name = "lbl_usrCpf";
            this.lbl_usrCpf.Size = new System.Drawing.Size(130, 20);
            this.lbl_usrCpf.TabIndex = 4;
            this.lbl_usrCpf.Text = "Cpf do Vendedor";
            // 
            // lbl_tipoVenda
            // 
            this.lbl_tipoVenda.AutoSize = true;
            this.lbl_tipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoVenda.Location = new System.Drawing.Point(699, 27);
            this.lbl_tipoVenda.Name = "lbl_tipoVenda";
            this.lbl_tipoVenda.Size = new System.Drawing.Size(112, 20);
            this.lbl_tipoVenda.TabIndex = 26;
            this.lbl_tipoVenda.Text = "Tipo de Venda";
            // 
            // cbx_tipoVenda
            // 
            this.cbx_tipoVenda.FormattingEnabled = true;
            this.cbx_tipoVenda.Items.AddRange(new object[] {
            "Dinheiro",
            "Debito",
            "Credito"});
            this.cbx_tipoVenda.Location = new System.Drawing.Point(703, 48);
            this.cbx_tipoVenda.Name = "cbx_tipoVenda";
            this.cbx_tipoVenda.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipoVenda.TabIndex = 27;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecarregar.Image")));
            this.btnRecarregar.Location = new System.Drawing.Point(30, 75);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(38, 38);
            this.btnRecarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRecarregar.TabIndex = 28;
            this.btnRecarregar.TabStop = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.cbx_tipoVenda);
            this.Controls.Add(this.lbl_tipoVenda);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dgv_listar);
            this.Controls.Add(this.dtp_entrega);
            this.Controls.Add(this.dtp_venda);
            this.Controls.Add(this.txt_cpfcliente);
            this.Controls.Add(this.txt_nvenda);
            this.Controls.Add(this.lbl_cpfcliente);
            this.Controls.Add(this.lbl_usrCpf);
            this.Controls.Add(this.lbl_dtentrega);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_dtvenda);
            this.Controls.Add(this.lbl_nvenda);
            this.Name = "frmvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmvendas";
            this.Load += new System.EventHandler(this.frmvendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nvenda;
        private System.Windows.Forms.Label lbl_dtvenda;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_dtentrega;
        private System.Windows.Forms.Label lbl_cpfcliente;
        private System.Windows.Forms.TextBox txt_nvenda;
        private System.Windows.Forms.TextBox txt_cpfcliente;
        private System.Windows.Forms.DateTimePicker dtp_venda;
        private System.Windows.Forms.DateTimePicker dtp_entrega;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgv_listar;
        private System.Windows.Forms.Label lbl_usrCpf;
        private System.Windows.Forms.Label lbl_tipoVenda;
        private System.Windows.Forms.ComboBox cbx_tipoVenda;
        private System.Windows.Forms.PictureBox btnRecarregar;
    }
}