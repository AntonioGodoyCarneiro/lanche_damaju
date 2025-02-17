namespace Lanches_Damaju
{
    partial class Cadastrar_produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_limparCampos = new System.Windows.Forms.Button();
            this.button_cadastrarProduto = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_valor = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox_descricao = new System.Windows.Forms.RichTextBox();
            this.pictureBox_produto = new System.Windows.Forms.PictureBox();
            this.label_cadastradoComSucesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTOS DAMAJU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "VALOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CATEGORIA";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(181, 83);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(264, 22);
            this.textBox_nome.TabIndex = 1;
            // 
            // button_limparCampos
            // 
            this.button_limparCampos.Location = new System.Drawing.Point(197, 391);
            this.button_limparCampos.Name = "button_limparCampos";
            this.button_limparCampos.Size = new System.Drawing.Size(75, 38);
            this.button_limparCampos.TabIndex = 5;
            this.button_limparCampos.Text = "LIMPAR CAMPOS";
            this.button_limparCampos.UseVisualStyleBackColor = true;
            this.button_limparCampos.Click += new System.EventHandler(this.button_limparCampos_Click);
            // 
            // button_cadastrarProduto
            // 
            this.button_cadastrarProduto.Location = new System.Drawing.Point(359, 391);
            this.button_cadastrarProduto.Name = "button_cadastrarProduto";
            this.button_cadastrarProduto.Size = new System.Drawing.Size(96, 38);
            this.button_cadastrarProduto.TabIndex = 6;
            this.button_cadastrarProduto.Text = "CADASTRAR";
            this.button_cadastrarProduto.UseVisualStyleBackColor = true;
            this.button_cadastrarProduto.Click += new System.EventHandler(this.button_cadastrarProduto_Click_1);
            // 
            // button_fechar
            // 
            this.button_fechar.Location = new System.Drawing.Point(514, 391);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(75, 38);
            this.button_fechar.TabIndex = 7;
            this.button_fechar.Text = "FECHAR";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Items.AddRange(new object[] {
            "LANCHES",
            "SALGADO",
            "BEBIDA",
            "PORÇÃO",
            "DOCE"});
            this.comboBox_categoria.Location = new System.Drawing.Point(181, 305);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(264, 21);
            this.comboBox_categoria.TabIndex = 4;
            // 
            // maskedTextBox_valor
            // 
            this.maskedTextBox_valor.Location = new System.Drawing.Point(181, 158);
            this.maskedTextBox_valor.Mask = "$000.00";
            this.maskedTextBox_valor.Name = "maskedTextBox_valor";
            this.maskedTextBox_valor.Size = new System.Drawing.Size(264, 20);
            this.maskedTextBox_valor.TabIndex = 2;
            // 
            // richTextBox_descricao
            // 
            this.richTextBox_descricao.Location = new System.Drawing.Point(181, 236);
            this.richTextBox_descricao.Name = "richTextBox_descricao";
            this.richTextBox_descricao.Size = new System.Drawing.Size(264, 22);
            this.richTextBox_descricao.TabIndex = 3;
            this.richTextBox_descricao.Text = "";
            // 
            // pictureBox_produto
            // 
            this.pictureBox_produto.Location = new System.Drawing.Point(487, 83);
            this.pictureBox_produto.Name = "pictureBox_produto";
            this.pictureBox_produto.Size = new System.Drawing.Size(232, 244);
            this.pictureBox_produto.TabIndex = 15;
            this.pictureBox_produto.TabStop = false;
            // 
            // label_cadastradoComSucesso
            // 
            this.label_cadastradoComSucesso.AutoSize = true;
            this.label_cadastradoComSucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cadastradoComSucesso.Location = new System.Drawing.Point(272, 355);
            this.label_cadastradoComSucesso.Name = "label_cadastradoComSucesso";
            this.label_cadastradoComSucesso.Size = new System.Drawing.Size(0, 33);
            this.label_cadastradoComSucesso.TabIndex = 16;
            // 
            // Cadastrar_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_cadastradoComSucesso);
            this.Controls.Add(this.pictureBox_produto);
            this.Controls.Add(this.richTextBox_descricao);
            this.Controls.Add(this.maskedTextBox_valor);
            this.Controls.Add(this.comboBox_categoria);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_cadastrarProduto);
            this.Controls.Add(this.button_limparCampos);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar_produtos";
            this.Text = "Cadastrar_produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_limparCampos;
        private System.Windows.Forms.Button button_cadastrarProduto;
        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_valor;
        private System.Windows.Forms.RichTextBox richTextBox_descricao;
        private System.Windows.Forms.PictureBox pictureBox_produto;
        private System.Windows.Forms.Label label_cadastradoComSucesso;
    }
}