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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_cadastrarProduto_Click(object sender, EventArgs e)
        {
            Cadastrar_produtos form = new Cadastrar_produtos();
            form.ShowDialog();
        }

        private void button_cadastrarCliente_Click(object sender, EventArgs e)
        {
            Tabela_Cliente form = new Tabela_Cliente();
            form.ShowDialog();
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_gerenciar_Click(object sender, EventArgs e)
        {
            GERENCIAMENTO_DAMAJU form = new GERENCIAMENTO_DAMAJU();
            form.ShowDialog();
        }
    }
}
