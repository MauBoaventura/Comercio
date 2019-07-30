namespace OiMundo
{
    partial class Caixa
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroItens = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mercadoDataSet = new OiMundo.MercadoDataSet();
            this.mercadoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new OiMundo.MercadoDataSetTableAdapters.tbProdutoTableAdapter();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numeroItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cadastrar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CadastrarProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantidade";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(848, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PesquisaProduto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "Caixa";
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Location = new System.Drawing.Point(65, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Caixa";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // numeroItens
            // 
            this.numeroItens.Location = new System.Drawing.Point(104, 115);
            this.numeroItens.Name = "numeroItens";
            this.numeroItens.Size = new System.Drawing.Size(46, 20);
            this.numeroItens.TabIndex = 22;
            this.numeroItens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Finalizar compra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.Total});
            this.dataGridView1.DataSource = this.tbProdutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(407, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // mercadoDataSet
            // 
            this.mercadoDataSet.DataSetName = "MercadoDataSet";
            this.mercadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mercadoDataSetBindingSource
            // 
            this.mercadoDataSetBindingSource.DataSource = this.mercadoDataSet;
            this.mercadoDataSetBindingSource.Position = 0;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.mercadoDataSetBindingSource;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "N";
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 274);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numeroItens);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Caixa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;

        private double valorCaixa;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;

        private static string cmdSelecionarByCod = "Select * from tbProduto Where CodBarras=@CodBarras";
        private static string cmdInserir = "Insert Into tbProduto([CodBarras], [Descricao], [Quantidade], [PrecoCompra], [PrecoVenda], [Validade]) VALUES (@CodBarras, @Descricao, @Quantidade, @PrecoCompra, @PrecoVenda, @Validade);";
        private static string cmdAtualizar = "UPDATE tbProduto SET [CodBarras] = @CodBarras, [Descricao] = @Descricao, [Quantidade] = @Quantidade, [PrecoCompra] = @PrecoCompra, [PrecoVenda] = @PrecoVenda, [Validade] = @Validade WHERE [Id] = @Original_Id;";
        private static string cmdDeletar = "Delete from tbProduto where Id=@codigo";
        private static string cmdSelecionarTudo = "Select * from tbProduto";
        private System.Windows.Forms.NumericUpDown numeroItens;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private System.Windows.Forms.BindingSource mercadoDataSetBindingSource;
        private MercadoDataSet mercadoDataSet;
        private MercadoDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
    }
}