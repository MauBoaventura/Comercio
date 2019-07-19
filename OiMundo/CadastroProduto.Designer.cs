namespace OiMundo
{
    partial class CadastroProduto
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
            this.textCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrecoCompra = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textPrecoVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateVencimento = new System.Windows.Forms.DateTimePicker();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // textCodigoDeBarras
            // 
            this.textCodigoDeBarras.Location = new System.Drawing.Point(111, 52);
            this.textCodigoDeBarras.Name = "textCodigoDeBarras";
            this.textCodigoDeBarras.Size = new System.Drawing.Size(281, 20);
            this.textCodigoDeBarras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar de Produto";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Barras:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(111, 78);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(281, 20);
            this.textDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(30, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço Compra:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // textPrecoCompra
            // 
            this.textPrecoCompra.Location = new System.Drawing.Point(111, 130);
            this.textPrecoCompra.Name = "textPrecoCompra";
            this.textPrecoCompra.Size = new System.Drawing.Size(281, 20);
            this.textPrecoCompra.TabIndex = 4;
            this.textPrecoCompra.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(99, 209);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(89, 30);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.Button1_CadastrarProduto);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(30, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(30, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Preço Venda:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textPrecoVenda
            // 
            this.textPrecoVenda.Location = new System.Drawing.Point(303, 183);
            this.textPrecoVenda.Name = "textPrecoVenda";
            this.textPrecoVenda.Size = new System.Drawing.Size(89, 20);
            this.textPrecoVenda.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(238, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Valor Final:";
            // 
            // dateVencimento
            // 
            this.dateVencimento.Location = new System.Drawing.Point(111, 157);
            this.dateVencimento.Name = "dateVencimento";
            this.dateVencimento.Size = new System.Drawing.Size(213, 20);
            this.dateVencimento.TabIndex = 33;
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(111, 105);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(39, 20);
            this.numericQuantidade.TabIndex = 34;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 254);
            this.Controls.Add(this.numericQuantidade);
            this.Controls.Add(this.dateVencimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPrecoVenda);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPrecoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodigoDeBarras);
            this.Name = "CadastroProduto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigoDeBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrecoCompra;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textPrecoVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateVencimento;
        private System.Windows.Forms.NumericUpDown numericQuantidade;

        //String SQL Banco - Tabela tbProduto
        private static string cmdInserir = "Insert Into tbProduto([CodBarras], [Descricao], [Quantidade], [PrecoCompra], [PrecoVenda], [Validade]) VALUES (@CodBarras, @Descricao, @Quantidade, @PrecoCompra, @PrecoVenda, @Validade);";
        private static string cmdAtualizar = "UPDATE tbProduto SET [CodBarras] = @CodBarras, [Descricao] = @Descricao, [Quantidade] = @Quantidade, [PrecoCompra] = @PrecoCompra, [PrecoVenda] = @PrecoVenda, [Validade] = @Validade WHERE [Id] = @Original_Id;";
        private static string cmdDeletar = "Delete from tbProduto where Id=@codigo";
        private static string cmdSelecionarById = "Select * from tbProduto Where Id=@Id";
        private static string cmdSelecionarTudo = "Select * from tbProduto";
        
    }
}

