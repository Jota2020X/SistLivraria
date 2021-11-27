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
    public partial class FrmEditora : Form
    {
        // Variáveis e instanciamentos globais
        String Strconexao = @"Data Source=JOTA-PC\SQLEXPRESS;Initial Catalog=Livraria1;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(); // instancia um objeto de conexão
        SqlCommand cmd = new SqlCommand(); // instancia um objeto da classe de comandos sql
        SqlDataReader Dr; // Declara um DataReader
        public struct Dados
        {
            public int chave;
            public string editora;
            public string cidade;
        }
        Dados p; // iniciando p como estrutura parametros
        public FrmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            CarregaGridEditora("total");
        }

        private void CarregaGridEditora(string tipo)
        {
            DataTable DtGenerico = new DataTable(); // instanciando uma tabela temporária
            conexao.ConnectionString = Strconexao; // indicando o string de conexão
            cmd.CommandText = "select idEditora, nomeeditora 'Editora', " +
                "Cidade from Editora";
            if(tipo=="total")
            {
                lblGrid.Text = "Lista geral das Editoras Cadastradas:";
            }
            else
            {
                lblGrid.Text = "Lista das Editoras Cadastradas filtradas pelo critério de consulta (depois clique em Limpar):";
                if (p.chave != 0) cmd.CommandText += " where idEditora = " + p.chave;
                else if (p.editora != "" & p.cidade != "") cmd.CommandText += " where NomeEditora like '%" + p.editora +
                             "%' and Cidade like '%" + p.cidade + "%'";
                else if (p.editora != "" & p.cidade == "") cmd.CommandText += " where NomeEditora like '%" + p.editora + "%'";
                else if (p.editora == "" & p.cidade != "") cmd.CommandText += " where Cidade like '%" + p.cidade + "%'";
                else MessageBox.Show("Nenhum critério de consulta foi preenchido!", "Consulta inválida");
            }
            cmd.Connection = conexao;  // indicando o objeto de conexão instanciado nas declarações globais
            try
            {
                conexao.Open(); // Efetiva a abertura de uma conexão com o BD
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader(); // alimenta o DataReader com a execução do comando (select)
                if (tipo == "parcial" & !Dr.HasRows) MessageBox.Show("Critério de consulta não selecionou nenhuma editora!", "Alerta!");
                DtGenerico.Clear(); // limpa a tabela temporária caso tenha algum conteúdo anterior
                DtGenerico.Load(Dr); // carrega tabela temporária com DataReader, ou seja, dados lidos (select)
                dgvEditora.DataSource = "";
                dgvEditora.DataSource = DtGenerico; // movimenta os dados da tabela temporária para o data grid view
                conexao.Close();
            }
            catch (Exception erro) // se deu erro executar:
            {
                MessageBox.Show("Erro==> " + erro.Message + "\n" + cmd.CommandText, "Erro no ADO.NET - seu comando", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int idEditora = 0;
            if (txbNomeEditora.Text != "" & txbCidade.Text != "")
            {
                try
                {
                    conexao.Open();
                    cmd.CommandText = "INSERT INTO  editora(nomeeditora,cidade) VALUES('" +
                        txbNomeEditora.Text + "','" + txbCidade.Text + "')";
                    cmd.ExecuteNonQuery();
                    // Obter e informar id do registro inserido
                    cmd.CommandText = "select scope_identity()";
                    Dr = cmd.ExecuteReader();
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            idEditora = int.Parse(Dr[0].ToString());
                        }
                    }
                    txbIdEditora.Text = idEditora.ToString();
                    MessageBox.Show("Inclusão de Editora " + idEditora + " realizada com sucesso", "Informação");
                    conexao.Close();
                    txbIdEditora.Clear();
                    txbNomeEditora.Clear();
                    txbCidade.Clear();
                    CarregaGridEditora("total");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha as informações da editora antes de usar o botão Incluir", "Orientação");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbIdEditora.Clear();
            txbNomeEditora.Clear();
            txbCidade.Clear();
            CarregaGridEditora("total");
        }

        private void dgvEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIdEditora.Text = dgvEditora.CurrentRow.Cells[0].Value.ToString();
            p.chave = int.Parse(txbIdEditora.Text);
            p.editora = txbNomeEditora.Text = dgvEditora.CurrentRow.Cells[1].Value.ToString();
            p.cidade = txbCidade.Text = dgvEditora.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditora.Text != "" & txbCidade.Text != "" & txbIdEditora.Text!="")
            {
                if (p.editora != txbNomeEditora.Text || p.cidade != txbCidade.Text)
                    try
                    {
                        conexao.Open();
                        cmd.CommandText = "UPDATE editora SET nomeEditora='" + txbNomeEditora.Text + "'," +
                            "cidade = '" + txbCidade.Text + "' WHERE idEditora = " + p.chave;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alteração de Editora " + p.chave + " realizada com sucesso", "Informação");
                        conexao.Close();
                        txbIdEditora.Clear();
                        txbNomeEditora.Clear();
                        txbCidade.Clear();
                        CarregaGridEditora("total");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else MessageBox.Show("Não há nenhuma alteração nos dados da Editora, para gravar no Banco de Dados",
                    "Alteração inválida!");
            }
            else
            {
                MessageBox.Show("Selecionar uma editora antes de usar o botão Alterar", "Orientação");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int qtdReferencias;
            if (txbNomeEditora.Text != "" & txbCidade.Text != "" & txbIdEditora.Text != "")
            {
                qtdReferencias = ChecarExclusaoEditora(); // chamada de método do tipo função
                if (qtdReferencias == 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir a Editora " + p.chave + "?",
                    "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            conexao.Open();
                            cmd.CommandText = "Delete from Editora where IdEditora=" + p.chave; 
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Exclusão da Editora " + p.chave + " realizada com sucesso", "Informação");
                            conexao.Close();
                            txbIdEditora.Clear();
                            txbNomeEditora.Clear();
                            txbCidade.Clear();
                            CarregaGridEditora("total");
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Não faz nada pois desistiu de realizar a exclusão
                    }
                }
                else
                {
                    MessageBox.Show("Esta editora não pode ser excluída por possuir " + qtdReferencias + 
                        " livro(s) que lhe faz(em) referência!", "Exclusão inválida");
                }
            }
            else
            {
                MessageBox.Show("Selecionar uma editora antes de usar o botão Excluir", "Orientação");
            }
        } // fim do método btnExcluir_Click

        private int ChecarExclusaoEditora()
        {
            int qtdRegistros=0;
            conexao.ConnectionString = Strconexao; // indicando o string de conexão
            cmd.CommandText = "select count(*) from livro where ideditora = " + p.chave;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmEditoraConsulta objConsulta = new FrmEditoraConsulta();
            objConsulta.ShowDialog();
            p.chave = objConsulta.Parametro.idEditora;
            p.editora = objConsulta.Parametro.NomeEditora;
            p.cidade = objConsulta.Parametro.CidadeEditora;
            CarregaGridEditora("parcial");
        }
    }
}
