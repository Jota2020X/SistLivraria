using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistLivraria
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "Calc.exe";
            prcExecutor.Start();
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Confirma())
            {
                Application.Exit();
            }
        }

        private void separaPalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSepara objSepara = new FrmSepara(); // instanciamento de um objeto formulário baseado na classe FrmSepara
            objSepara.ShowDialog();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora objEditora = new FrmEditora();
            objEditora.ShowDialog();
        }

        static bool Confirma()
        {
            if (MessageBox.Show("Deseja realmente sair deste sistema?",
                "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                return true;
            else return false;
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor objAutor = new FrmAutor();
            objAutor.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
