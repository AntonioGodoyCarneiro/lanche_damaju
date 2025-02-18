namespace Lanches_Damaju
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_cadastrarProduto = new System.Windows.Forms.Button();
            this.button_cadastrarCliente = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            this.button_gerenciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LANCHES DAMAJU";
            // 
            // button_cadastrarProduto
            // 
            this.button_cadastrarProduto.Location = new System.Drawing.Point(112, 140);
            this.button_cadastrarProduto.Name = "button_cadastrarProduto";
            this.button_cadastrarProduto.Size = new System.Drawing.Size(78, 47);
            this.button_cadastrarProduto.TabIndex = 1;
            this.button_cadastrarProduto.Text = "Cadastrar produto";
            this.button_cadastrarProduto.UseVisualStyleBackColor = true;
            this.button_cadastrarProduto.Click += new System.EventHandler(this.button_cadastrarProduto_Click);
            // 
            // button_cadastrarCliente
            // 
            this.button_cadastrarCliente.Location = new System.Drawing.Point(357, 140);
            this.button_cadastrarCliente.Name = "button_cadastrarCliente";
            this.button_cadastrarCliente.Size = new System.Drawing.Size(78, 47);
            this.button_cadastrarCliente.TabIndex = 2;
            this.button_cadastrarCliente.Text = "Cadastrar cliente";
            this.button_cadastrarCliente.UseVisualStyleBackColor = true;
            this.button_cadastrarCliente.Click += new System.EventHandler(this.button_cadastrarCliente_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Location = new System.Drawing.Point(357, 354);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(78, 47);
            this.button_fechar.TabIndex = 5;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // button_gerenciar
            // 
            this.button_gerenciar.Location = new System.Drawing.Point(557, 140);
            this.button_gerenciar.Name = "button_gerenciar";
            this.button_gerenciar.Size = new System.Drawing.Size(78, 47);
            this.button_gerenciar.TabIndex = 3;
            this.button_gerenciar.Text = "Gerenciar";
            this.button_gerenciar.UseVisualStyleBackColor = true;
            this.button_gerenciar.Click += new System.EventHandler(this.button_gerenciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_gerenciar);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_cadastrarCliente);
            this.Controls.Add(this.button_cadastrarProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cadastrarProduto;
        private System.Windows.Forms.Button button_cadastrarCliente;
        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Button button_gerenciar;
    }
}

