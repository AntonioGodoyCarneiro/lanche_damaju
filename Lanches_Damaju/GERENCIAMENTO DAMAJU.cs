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
    }
}
