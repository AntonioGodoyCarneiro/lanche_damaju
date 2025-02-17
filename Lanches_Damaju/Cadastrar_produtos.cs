using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanches_Damaju
{
    public partial class Cadastrar_produtos : Form
    {
        public Cadastrar_produtos()
        {
            InitializeComponent();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            {
                //Define sua string de conexão com o banco
                string conexaoString = "Server=localhost; Port=3306; Database=lanches_damaju; Uid=root; Pwd=;";

                //Defina a inserção de registro no BD
                string query = "INSERT INTO tb_produto (nome, valor, descricao, imagem, categoria) VALUES (@nome, @valor, @descricao, @imagem, @categoria)";

                //Crie uma conexão com o BD
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    try
                    {
                        //Abre a conexao
                        conexao.Open();

                        //Crie o comenado SQL
                        using (MySqlCommand comando = new MySqlCommand(query, conexao))
                        {
                            //Adicionar os parâmetros com os valores dos TexBox
                            comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                            comando.Parameters.AddWithValue("@valor", maskedTextBox_valor.Text);
                            comando.Parameters.AddWithValue("@descricao", richTextBox_descricao.Text);
                            comando.Parameters.AddWithValue("@imagem", pictureBox_produto.Text);
                            comando.Parameters.AddWithValue("@categoria", comboBox_categoria.Text);


                            //Executa o comando de inserção

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Dados inseridos com sucesso!");
                        }
                    }

                    catch (Exception ex)
                    {
                        //em caso de erro, exiba mensagem de erro
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void button_limparCampos_Click(object sender, EventArgs e)
        { 
            textBox_nome.Text = "";
            maskedTextBox_valor.Text = "";
            richTextBox_descricao.Text = "";
            pictureBox_produto.Text = "";
            comboBox_categoria.Text = "";
         }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
