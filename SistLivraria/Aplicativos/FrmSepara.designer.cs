
namespace SistLivraria
{
    partial class FrmSepara
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.ltbPalavras = new System.Windows.Forms.ListBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a frase que terá separação das palavras:";
            // 
            // txbFrase
            // 
            this.txbFrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrase.Location = new System.Drawing.Point(28, 68);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(713, 26);
            this.txbFrase.TabIndex = 1;
            this.txbFrase.TextChanged += new System.EventHandler(this.txbFrase_TextChanged);
            this.txbFrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFrase_KeyPress);
            // 
            // ltbPalavras
            // 
            this.ltbPalavras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPalavras.FormattingEnabled = true;
            this.ltbPalavras.ItemHeight = 18;
            this.ltbPalavras.Location = new System.Drawing.Point(28, 128);
            this.ltbPalavras.Name = "ltbPalavras";
            this.ltbPalavras.Size = new System.Drawing.Size(288, 292);
            this.ltbPalavras.TabIndex = 2;
            // 
            // btnProcessar
            // 
            this.btnProcessar.BackColor = System.Drawing.Color.Navy;
            this.btnProcessar.ForeColor = System.Drawing.Color.White;
            this.btnProcessar.Location = new System.Drawing.Point(597, 128);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(144, 62);
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(597, 239);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 62);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Navy;
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(597, 358);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(144, 62);
            this.btnEncerrar.TabIndex = 5;
            this.btnEncerrar.Text = "&Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(353, 258);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(210, 161);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Label-Texto";
            // 
            // FrmSepara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.ltbPalavras);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmSepara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separa Palavras";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFrase;
        private System.Windows.Forms.ListBox ltbPalavras;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblResultado;
    }
}

