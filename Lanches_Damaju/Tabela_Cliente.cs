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
    public partial class Tabela_Cliente : Form
    {


        public Tabela_Cliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_limparCampos_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = "";
            textBox_senha.Text = "";
            maskedTextBox_email.Text = "";
            maskedTextBox_CPF.Text = "";
            maskedTextBox_numero.Text = "";
            maskedTextBox_telefone.Text = "";
            maskedTextBox_CEP.Text = "";
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cadastrarClientes_Click(object sender, EventArgs e)
        {
            {
                //Define sua string de conexão com o banco
                string conexaoString = "Server=localhost; Port=3306; Database=lanches_damaju; Uid=root; Pwd=;";

                //Defina a inserção de registro no BD
                string query = "INSERT INTO tb_cliente (senha, email, CEP, CPF, numero, telefone, imagem, nome) VALUES (@senha, @email, @CEP, @CPF, @numero, @telefone, @imagem, @nome)";

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
                            comando.Parameters.AddWithValue("@senha", textBox_senha.Text);
                            comando.Parameters.AddWithValue("@email", maskedTextBox_email.Text);
                            comando.Parameters.AddWithValue("@CPF", maskedTextBox_CPF.Text);
                            comando.Parameters.AddWithValue("@numero", maskedTextBox_numero.Text);
                            comando.Parameters.AddWithValue("@telefone", maskedTextBox_telefone.Text);
                            comando.Parameters.AddWithValue("@CEP", maskedTextBox_CEP.Text);
                            comando.Parameters.AddWithValue("@imagem", pictureBox1.Text);
                            comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
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
    }
}

