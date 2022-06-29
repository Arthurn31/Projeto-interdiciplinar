namespace interdisciplinar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnProdutos = new System.Windows.Forms.PictureBox();
            this.btnItensVenda = new System.Windows.Forms.PictureBox();
            this.btnVendas = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblItensVenda = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lbl_nomeUser = new System.Windows.Forms.Label();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.Location = new System.Drawing.Point(17, 98);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(240, 218);
            this.btnProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.TabStop = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnItensVenda
            // 
            this.btnItensVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnItensVenda.Image")));
            this.btnItensVenda.Location = new System.Drawing.Point(282, 98);
            this.btnItensVenda.Name = "btnItensVenda";
            this.btnItensVenda.Size = new System.Drawing.Size(240, 218);
            this.btnItensVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnItensVenda.TabIndex = 4;
            this.btnItensVenda.TabStop = false;
            this.btnItensVenda.Click += new System.EventHandler(this.btnItensVenda_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(543, 98);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(240, 218);
            this.btnVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVendas.TabIndex = 5;
            this.btnVendas.TabStop = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(78, 333);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(118, 29);
            this.lblProdutos.TabIndex = 6;
            this.lblProdutos.Text = "Produtos";
            this.lblProdutos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblItensVenda
            // 
            this.lblItensVenda.AutoSize = true;
            this.lblItensVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensVenda.Location = new System.Drawing.Point(324, 333);
            this.lblItensVenda.Name = "lblItensVenda";
            this.lblItensVenda.Size = new System.Drawing.Size(200, 29);
            this.lblItensVenda.TabIndex = 7;
            this.lblItensVenda.Text = "Itens de Vendas";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(635, 333);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(87, 29);
            this.lblVenda.TabIndex = 8;
            this.lblVenda.Text = "Venda";
            // 
            // lbl_nomeUser
            // 
            this.lbl_nomeUser.AutoSize = true;
            this.lbl_nomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeUser.Location = new System.Drawing.Point(17, 13);
            this.lbl_nomeUser.Name = "lbl_nomeUser";
            this.lbl_nomeUser.Size = new System.Drawing.Size(125, 25);
            this.lbl_nomeUser.TabIndex = 9;
            this.lbl_nomeUser.Text = "Bem Vindo";
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Location = new System.Drawing.Point(543, 499);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(231, 61);
            this.btnEstatisticas.TabIndex = 10;
            this.btnEstatisticas.Text = "Estatisticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            this.btnEstatisticas.Click += new System.EventHandler(this.btnEstatisticas_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.lbl_nomeUser);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblItensVenda);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnItensVenda);
            this.Controls.Add(this.btnProdutos);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnProdutos;
        private System.Windows.Forms.PictureBox btnItensVenda;
        private System.Windows.Forms.PictureBox btnVendas;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblItensVenda;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lbl_nomeUser;
        private System.Windows.Forms.Button btnEstatisticas;
    }
}