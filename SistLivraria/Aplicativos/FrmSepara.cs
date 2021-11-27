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
    public partial class FrmSepara : Form
    {
        public FrmSepara()
        {
            InitializeComponent();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (Confirma())
            {
                this.Close();
            }
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (txbFrase.Text == "")
            {
                MessageBox.Show("Antes de acionar o botão Processar, digite uma frase!", "Orientação",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else AlimentaLista();
        }

        private void AlimentaLista()
        {
            char[] letra = new char[200]; // matriz de 1 dimensão -> vetor
            int pos, max, qtdPalavra=0;
            string palavra="";
            letra = txbFrase.Text.ToCharArray();
            max = letra.Length;
            for (pos = 0; pos < max; pos++)
            {
                palavra = palavra + letra[pos].ToString();
                if (letra[pos] == ' ' || pos == max-1)
                {
                    ltbPalavras.Items.Add(palavra);
                    palavra = "";
                    qtdPalavra++;
                }
            }
            lblResultado.Text = "A frase contém " + max + " letras e resultou em " + qtdPalavra + " palavras";
            if(max % 2 == 0)
            {
                lblResultado.Text = lblResultado.Text + " (black por quantidade de letras par)";
                lblResultado.ForeColor = Color.Black;
            }
            else
            {
                lblResultado.Text = lblResultado.Text + " (white por quantidade de letras impar)";
                lblResultado.ForeColor = Color.White;
            }
        }

        static bool Confirma()
        {
            if (MessageBox.Show("Deseja realmente sair deste aplicativo?",
                "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                return true;
            else return false; 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void txbFrase_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            ltbPalavras.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbFrase.Clear();
            lblResultado.Text = "";
            ltbPalavras.Items.Clear();
        }

        private void txbFrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnProcessar_Click(sender, e);
            //if (e.KeyChar == 'a') e.KeyChar = 'b';
        }
    }
}
