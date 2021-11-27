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
    public partial class FrmEditoraConsulta : Form
    {
        public struct Dados
        {
            public int idEditora;
            public string NomeEditora;
            public string CidadeEditora;
        }
        Dados transf;

        public Dados Parametro
        {
            get { return transf; }
            set { } // textBoxParametro.Text = value; }
        }
        public FrmEditoraConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txbIdEditora.Text, out transf.idEditora))
                transf.idEditora = 0;
            transf.NomeEditora = txbNomeEditora.Text;
            transf.CidadeEditora = txbCidade.Text;
            this.Hide();
        }
    }
}
