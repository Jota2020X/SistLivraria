
namespace SistLivraria
{
    partial class FrmPrincipal
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
            this.mnsUnico = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeAjusteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasAuxiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separaPalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prcExecutor = new System.Diagnostics.Process();
            this.mnsUnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsUnico
            // 
            this.mnsUnico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.tabelasAuxiliaresToolStripMenuItem,
            this.aplicativosToolStripMenuItem,
            this.fecharSistemaToolStripMenuItem});
            this.mnsUnico.Location = new System.Drawing.Point(0, 0);
            this.mnsUnico.Name = "mnsUnico";
            this.mnsUnico.Size = new System.Drawing.Size(784, 24);
            this.mnsUnico.TabIndex = 0;
            this.mnsUnico.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorasToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.livrosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentoDeEntradaToolStripMenuItem,
            this.movimentoDeSaídaToolStripMenuItem,
            this.movimentoDeAjusteToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // movimentoDeEntradaToolStripMenuItem
            // 
            this.movimentoDeEntradaToolStripMenuItem.Name = "movimentoDeEntradaToolStripMenuItem";
            this.movimentoDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimentoDeEntradaToolStripMenuItem.Text = "Movimento de Entrada";
            // 
            // movimentoDeSaídaToolStripMenuItem
            // 
            this.movimentoDeSaídaToolStripMenuItem.Name = "movimentoDeSaídaToolStripMenuItem";
            this.movimentoDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimentoDeSaídaToolStripMenuItem.Text = "Movimento de Saída";
            // 
            // movimentoDeAjusteToolStripMenuItem
            // 
            this.movimentoDeAjusteToolStripMenuItem.Name = "movimentoDeAjusteToolStripMenuItem";
            this.movimentoDeAjusteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimentoDeAjusteToolStripMenuItem.Text = "Movimento de Ajuste";
            // 
            // tabelasAuxiliaresToolStripMenuItem
            // 
            this.tabelasAuxiliaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.tabelasAuxiliaresToolStripMenuItem.Name = "tabelasAuxiliaresToolStripMenuItem";
            this.tabelasAuxiliaresToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.tabelasAuxiliaresToolStripMenuItem.Text = "Tabelas Auxiliares";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.separaPalavrasToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // separaPalavrasToolStripMenuItem
            // 
            this.separaPalavrasToolStripMenuItem.Name = "separaPalavrasToolStripMenuItem";
            this.separaPalavrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.separaPalavrasToolStripMenuItem.Text = "Separa Palavras";
            // 
            // fecharSistemaToolStripMenuItem
            // 
            this.fecharSistemaToolStripMenuItem.Name = "fecharSistemaToolStripMenuItem";
            this.fecharSistemaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fecharSistemaToolStripMenuItem.Text = "Fechar Sistema";
            this.fecharSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharSistemaToolStripMenuItem_Click);
            // 
            // prcExecutor
            // 
            this.prcExecutor.StartInfo.Domain = "";
            this.prcExecutor.StartInfo.LoadUserProfile = false;
            this.prcExecutor.StartInfo.Password = null;
            this.prcExecutor.StartInfo.StandardErrorEncoding = null;
            this.prcExecutor.StartInfo.StandardOutputEncoding = null;
            this.prcExecutor.StartInfo.UserName = "";
            this.prcExecutor.SynchronizingObject = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mnsUnico);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnsUnico;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Livraria Parceria";
            this.mnsUnico.ResumeLayout(false);
            this.mnsUnico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsUnico;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeAjusteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasAuxiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separaPalavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSistemaToolStripMenuItem;
        private System.Diagnostics.Process prcExecutor;
    }
}

