using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistLivraria
{
    public partial class FrmAutor : Form
    {
        // Variáveis e instanciamentos globais
        String Strconexao = @"Data Source=JOTA-PC\SQLEXPRESS;Initial Catalog=Livraria1;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(); // instancia um objeto de conexão
        SqlCommand cmd = new SqlCommand(); // instancia um objeto da classe de comandos sql
        SqlDataReader Dr; // Declara um DataReader
        public struct Dados
        {
            public int chave;
            public string autor;
        }
        Dados d; // iniciando d como estrutura Dados

        public FrmAutor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaGridAutor(string tipo)
        {
            conexao.ConnectionString = Strconexao; // indicando o string de conexão
            cmd.Connection = conexao;  // indicando o objeto de conexão instanciado nas declarações globais
            DataTable DtGenerico = new DataTable(); // instanciando uma tabela temporária
            cmd.CommandText = "select idAutor, nomeAutor 'Nome do Autor' from Autor ";
            try
            {
                conexao.Open(); // Efetiva a abertura de uma conexão com o BD
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader(); // alimenta o DataReader com a execução do comando (select)
                // *** Avaliar se terá tipo parcial !!!
                if (tipo == "parcial" & !Dr.HasRows) MessageBox.Show("Critério de consulta não selecionou nenhuma editora!", "Alerta!");
                DtGenerico.Clear(); // limpa a tabela temporária caso tenha algum conteúdo anterior
                DtGenerico.Load(Dr); // carrega tabela temporária com DataReader, ou seja, dados lidos (select)
                dgvEditora.DataSource = "";
                dgvEditora.DataSource = DtGenerico; // movimenta os dados da tabela temporária para o data grid view
                conexao.Close();
            }
            catch (Exception erro) // se deu erro executar:
            {
                MessageBox.Show("Erro==> " + erro.Message + "\n" + cmd.CommandText, "Erro no ADO.NET - CarregaGridAutor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGridAutor("total");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int idAutor = 0;
            if (txbNomeAutor.Text != "")
            {
                try
                {
                    conexao.Open();
                    cmd.CommandText = "INSERT INTO  autor(nomeautor) VALUES('" +
                        txbNomeAutor.Text + "')";
                    cmd.ExecuteNonQuery();
                    // Obter e informar id do registro inserido
                    cmd.CommandText = "select scope_identity()";
                    Dr = cmd.ExecuteReader();
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            idAutor = int.Parse(Dr[0].ToString());
                        }
                    }
                    txbIdAutor.Text = idAutor.ToString();
                    MessageBox.Show("Inclusão de Autor " + idAutor + " realizada com sucesso", "Informação");
                    conexao.Close();
                    txbIdAutor.Clear();
                    txbNomeAutor.Clear();
                    CarregaGridAutor("total");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome do autor antes de usar o botão Incluir", "Orientação");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbIdAutor.Clear();
            txbNomeAutor.Clear();
            CarregaGridAutor("total");
        }

        private void dgvEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIdAutor.Text = dgvEditora.CurrentRow.Cells[0].Value.ToString();
            d.chave = int.Parse(txbIdAutor.Text);
            d.autor = txbNomeAutor.Text = dgvEditora.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txbNomeAutor.Text != "" & txbIdAutor.Text != "")
            {
                if (d.autor != txbNomeAutor.Text)
                    try
                    {
                        conexao.Open();
                        cmd.CommandText = "UPDATE autor SET nomeAutor='" + txbNomeAutor.Text +
                            "' WHERE idAutor = " + d.chave;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alteração de Autor " + d.chave + " realizada com sucesso", "Informação");
                        conexao.Close();
                        txbIdAutor.Clear();
                        txbNomeAutor.Clear();
                        CarregaGridAutor("total");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else MessageBox.Show("Não há nenhuma alteração nos dados do Autor, para gravar no Banco de Dados",
                    "Alteração inválida!");
            }
            else
            {
                MessageBox.Show("Selecionar um autor antes de usar o botão Alterar", "Orientação");
            }
        }

        private int ChecarExclusaoAutor() // Completar desenvolvimento e acertando linha em comentário
        {
            int qtdRegistros = 0;
            conexao.ConnectionString = Strconexao; // indicando o string de conexão
            //cmd.CommandText = "select count(*) from livro where ideditora = " + p.chave;
            cmd.Connection = conexao;  // indicando o objeto de conexão instanciado nas declarações globais
            try
            {
                conexao.Open();
                Dr = cmd.ExecuteReader();
                Dr.Read();
                qtdRegistros = int.Parse(Dr[0].ToString());
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - ChecarExclusaoEditora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return qtdRegistros;
        }
    }
}
