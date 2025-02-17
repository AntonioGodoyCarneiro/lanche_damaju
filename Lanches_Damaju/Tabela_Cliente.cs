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
    }
}
