namespace Lanches_Damaju
{
    partial class GERENCIAMENTO_DAMAJU
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
            this.dgv_exibir = new System.Windows.Forms.DataGridView();
            this.button_gerenciarproduto = new System.Windows.Forms.Button();
            this.button_gerenciarCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_apagarCliente = new System.Windows.Forms.Button();
            this.button_apagarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exibir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_exibir
            // 
            this.dgv_exibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exibir.Location = new System.Drawing.Point(12, 87);
            this.dgv_exibir.Name = "dgv_exibir";
            this.dgv_exibir.Size = new System.Drawing.Size(382, 254);
            this.dgv_exibir.TabIndex = 0;
            // 
            // button_gerenciarproduto
            // 
            this.button_gerenciarproduto.Location = new System.Drawing.Point(453, 112);
            this.button_gerenciarproduto.Name = "button_gerenciarproduto";
            this.button_gerenciarproduto.Size = new System.Drawing.Size(119, 46);
            this.button_gerenciarproduto.TabIndex = 1;
            this.button_gerenciarproduto.Text = "Gerenciar Produto";
            this.button_gerenciarproduto.UseVisualStyleBackColor = true;
            this.button_gerenciarproduto.Click += new System.EventHandler(this.button_gerenciarproduto_Click);
            // 
            // button_gerenciarCliente
            // 
            this.button_gerenciarCliente.Location = new System.Drawing.Point(453, 266);
            this.button_gerenciarCliente.Name = "button_gerenciarCliente";
            this.button_gerenciarCliente.Size = new System.Drawing.Size(119, 46);
            this.button_gerenciarCliente.TabIndex = 2;
            this.button_gerenciarCliente.Text = "Gerenciar Cliente";
            this.button_gerenciarCliente.UseVisualStyleBackColor = true;
            this.button_gerenciarCliente.Click += new System.EventHandler(this.button_gerenciarCliente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "FECHAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_apagarCliente
            // 
            this.button_apagarCliente.Location = new System.Drawing.Point(669, 266);
            this.button_apagarCliente.Name = "button_apagarCliente";
            this.button_apagarCliente.Size = new System.Drawing.Size(119, 46);
            this.button_apagarCliente.TabIndex = 4;
            this.button_apagarCliente.Text = "Apagar Cliente";
            this.button_apagarCliente.UseVisualStyleBackColor = true;
            this.button_apagarCliente.Click += new System.EventHandler(this.button_apagarCliente_Click);
            // 
            // button_apagarProduto
            // 
            this.button_apagarProduto.Location = new System.Drawing.Point(669, 112);
            this.button_apagarProduto.Name = "button_apagarProduto";
            this.button_apagarProduto.Size = new System.Drawing.Size(119, 46);
            this.button_apagarProduto.TabIndex = 3;
            this.button_apagarProduto.Text = "Apagar Produto";
            this.button_apagarProduto.UseVisualStyleBackColor = true;
            this.button_apagarProduto.Click += new System.EventHandler(this.button_apagarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "GERENCIAMENTO DAMAJU";
            // 
            // GERENCIAMENTO_DAMAJU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_apagarCliente);
            this.Controls.Add(this.button_apagarProduto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_gerenciarCliente);
            this.Controls.Add(this.button_gerenciarproduto);
            this.Controls.Add(this.dgv_exibir);
            this.Name = "GERENCIAMENTO_DAMAJU";
            this.Text = "GERENCIAMENTO_DAMAJU";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_exibir;
        private System.Windows.Forms.Button button_gerenciarproduto;
        private System.Windows.Forms.Button button_gerenciarCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_apagarCliente;
        private System.Windows.Forms.Button button_apagarProduto;
        private System.Windows.Forms.Label label1;
    }
}