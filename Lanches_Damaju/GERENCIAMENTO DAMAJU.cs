using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Lanches_Damaju
{
    public partial class GERENCIAMENTO_DAMAJU : Form
    {
        public GERENCIAMENTO_DAMAJU()
        {
            InitializeComponent();
        }

        private void button_gerenciarproduto_Click(object sender, EventArgs e)
        {
            // Definindo a string de conexão
            string connectionString = "Server=localhost;Port=3306;Database=lanches_damaju;User ID=root;Password=;";

            try
            {
                // Cria a conexão com o banco de dados MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Abre a conexão
                    conn.Open();

                    // Consulta SQL para selecionar todos os clientes
                    string query = "SELECT id , nome, valor, descricao, imagem, categoria FROM tb_produto";

                    // Cria o comando MySQL
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Executa a consulta e obtém os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // Cria uma lista para armazenar os registros
                        DataTable dtproduto = new DataTable();
                        dtproduto.Load(reader);

                        // Atribui a tabela de dados ao DataGridView
                        dgv_exibir.DataSource = dtproduto;
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe erro caso haja falha
                MessageBox.Show("Erro ao listar clientes: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_gerenciarCliente_Click(object sender, EventArgs e)
        {
            // Definindo a string de conexão
            string connectionString = "Server=localhost;Port=3306;Database=lanches_damaju;User ID=root;Password=;";

            try
            {
                // Cria a conexão com o banco de dados MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Abre a conexão
                    conn.Open();

                    // Consulta SQL para selecionar todos os clientes
                    string query = "SELECT id , nome, email, cpf, telefone, imagem FROM tb_cliente";

                    // Cria o comando MySQL
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Executa a consulta e obtém os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // Cria uma lista para armazenar os registros
                        DataTable dtproduto = new DataTable();
                        dtproduto.Load(reader);

                        // Atribui a tabela de dados ao DataGridView
                        dgv_exibir.DataSource = dtproduto;
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe erro caso haja falha
                MessageBox.Show("Erro ao listar clientes: " + ex.Message);
            }
        }

        private void button_apagarProduto_Click(object sender, EventArgs e)
        {
            if (dgv_exibir.SelectedRows.Count > 0)
            {
                //Pega o ID do cliente da linha selecionada
                int produtoID = Convert.ToInt32(dgv_exibir.SelectedRows[0].Cells["id"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=lanches_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão 
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_produto WHERE id = @id";


                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", produtoID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Produto excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o produto.");
                                }


                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cliente poara excluir");
                }




            }
        }

        private void button_apagarCliente_Click(object sender, EventArgs e)
        {
            if (dgv_exibir.SelectedRows.Count > 0)
            {
                //Pega o ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dgv_exibir.SelectedRows[0].Cells["id"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=lanches_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão 
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_cliente WHERE id = @id";


                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente.");
                                }


                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cliente poara excluir");
                }




            }
        }
    }
}
