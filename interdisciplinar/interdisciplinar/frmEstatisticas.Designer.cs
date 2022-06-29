
namespace interdisciplinar
{
    partial class frmEstatisticas
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
            this.lbl_PdrMaisVendido = new System.Windows.Forms.Label();
            this.lbl_PdrMenosVendido = new System.Windows.Forms.Label();
            this.lbl_rendaTotal = new System.Windows.Forms.Label();
            this.lbl_produtosfaltantes = new System.Windows.Forms.Label();
            this.ltx_produtosFaltantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_PdrMaisVendido
            // 
            this.lbl_PdrMaisVendido.AutoSize = true;
            this.lbl_PdrMaisVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PdrMaisVendido.Location = new System.Drawing.Point(40, 83);
            this.lbl_PdrMaisVendido.Name = "lbl_PdrMaisVendido";
            this.lbl_PdrMaisVendido.Size = new System.Drawing.Size(229, 24);
            this.lbl_PdrMaisVendido.TabIndex = 0;
            this.lbl_PdrMaisVendido.Text = "Produto Mais vendidos:";
            // 
            // lbl_PdrMenosVendido
            // 
            this.lbl_PdrMenosVendido.AutoSize = true;
            this.lbl_PdrMenosVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PdrMenosVendido.Location = new System.Drawing.Point(40, 211);
            this.lbl_PdrMenosVendido.Name = "lbl_PdrMenosVendido";
            this.lbl_PdrMenosVendido.Size = new System.Drawing.Size(249, 24);
            this.lbl_PdrMenosVendido.TabIndex = 1;
            this.lbl_PdrMenosVendido.Text = "Produto menos vendidos:";
            // 
            // lbl_rendaTotal
            // 
            this.lbl_rendaTotal.AutoSize = true;
            this.lbl_rendaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rendaTotal.Location = new System.Drawing.Point(40, 349);
            this.lbl_rendaTotal.Name = "lbl_rendaTotal";
            this.lbl_rendaTotal.Size = new System.Drawing.Size(206, 24);
            this.lbl_rendaTotal.TabIndex = 2;
            this.lbl_rendaTotal.Text = "Renda Total de hoje:";
            // 
            // lbl_produtosfaltantes
            // 
            this.lbl_produtosfaltantes.AutoSize = true;
            this.lbl_produtosfaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtosfaltantes.Location = new System.Drawing.Point(490, 56);
            this.lbl_produtosfaltantes.Name = "lbl_produtosfaltantes";
            this.lbl_produtosfaltantes.Size = new System.Drawing.Size(191, 24);
            this.lbl_produtosfaltantes.TabIndex = 3;
            this.lbl_produtosfaltantes.Text = "prodututos faltantes";
            // 
            // ltx_produtosFaltantes
            // 
            this.ltx_produtosFaltantes.FormattingEnabled = true;
            this.ltx_produtosFaltantes.Location = new System.Drawing.Point(463, 83);
            this.ltx_produtosFaltantes.Name = "ltx_produtosFaltantes";
            this.ltx_produtosFaltantes.Size = new System.Drawing.Size(261, 290);
            this.ltx_produtosFaltantes.TabIndex = 4;
            // 
            // frmEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.ltx_produtosFaltantes);
            this.Controls.Add(this.lbl_produtosfaltantes);
            this.Controls.Add(this.lbl_rendaTotal);
            this.Controls.Add(this.lbl_PdrMenosVendido);
            this.Controls.Add(this.lbl_PdrMaisVendido);
            this.Name = "frmEstatisticas";
            this.Text = "frmEstatisticas";
            this.Load += new System.EventHandler(this.frmEstatisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PdrMaisVendido;
        private System.Windows.Forms.Label lbl_PdrMenosVendido;
        private System.Windows.Forms.Label lbl_rendaTotal;
        private System.Windows.Forms.Label lbl_produtosfaltantes;
        private System.Windows.Forms.ListBox ltx_produtosFaltantes;
    }
}