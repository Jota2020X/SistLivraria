using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistLivraria
{
    public partial class FrmLogin : Form
    {
        //string de conexão
        SqlConnection con = new SqlConnection(@"Data Source=JOTA-PC\SQLEXPRESS; Initial catalog=Livraria1; User=sa; password=1234567");
        SqlCommand cmd = new SqlCommand();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dados = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usuario = @user and senha = @senha", con);
                da.SelectCommand.Parameters.AddWithValue("@user", txbUsuario.Text);
                da.SelectCommand.Parameters.AddWithValue("@senha", txbSenha.Text);
                da.Fill(dados);
                if (dados.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário / Senha inválido!");
                }
                else
                {
                    FrmPrincipal objPrincipal = new FrmPrincipal();
                    objPrincipal.Show();
                    this.Hide();
                }
                con.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro => " + erro.Message, "Erro no Entrar");
            }
        }
    }
}
