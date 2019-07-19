namespace OiMundo
{
    partial class ConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProduto));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label codBarrasLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precoCompraLabel;
            System.Windows.Forms.Label precoVendaLabel;
            System.Windows.Forms.Label validadeLabel;
            System.Windows.Forms.Label label1;
            this.mercadoDataSet = new OiMundo.MercadoDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new OiMundo.MercadoDataSetTableAdapters.tbProdutoTableAdapter();
            this.tableAdapterManager = new OiMundo.MercadoDataSetTableAdapters.TableAdapterManager();
            this.tbProdutoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbProdutoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.codBarrasTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.precoCompraTextBox = new System.Windows.Forms.TextBox();
            this.precoVendaTextBox = new System.Windows.Forms.TextBox();
            this.validadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            codBarrasLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precoCompraLabel = new System.Windows.Forms.Label();
            precoVendaLabel = new System.Windows.Forms.Label();
            validadeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingNavigator)).BeginInit();
            this.tbProdutoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mercadoDataSet
            // 
            this.mercadoDataSet.DataSetName = "MercadoDataSet";
            this.mercadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.mercadoDataSet;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbProdutoTableAdapter = this.tbProdutoTableAdapter;
            this.tableAdapterManager.UpdateOrder = OiMundo.MercadoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbProdutoBindingNavigator
            // 
            this.tbProdutoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbProdutoBindingNavigator.BindingSource = this.tbProdutoBindingSource;
            this.tbProdutoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbProdutoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbProdutoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbProdutoBindingNavigatorSaveItem});
            this.tbProdutoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbProdutoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbProdutoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbProdutoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbProdutoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbProdutoBindingNavigator.Name = "tbProdutoBindingNavigator";
            this.tbProdutoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbProdutoBindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.tbProdutoBindingNavigator.TabIndex = 0;
            this.tbProdutoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tbProdutoBindingNavigatorSaveItem
            // 
            this.tbProdutoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProdutoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbProdutoBindingNavigatorSaveItem.Image")));
            this.tbProdutoBindingNavigatorSaveItem.Name = "tbProdutoBindingNavigatorSaveItem";
            this.tbProdutoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbProdutoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbProdutoBindingNavigatorSaveItem.Click += new System.EventHandler(this.TbProdutoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 81);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 78);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // codBarrasLabel
            // 
            codBarrasLabel.AutoSize = true;
            codBarrasLabel.Location = new System.Drawing.Point(12, 107);
            codBarrasLabel.Name = "codBarrasLabel";
            codBarrasLabel.Size = new System.Drawing.Size(62, 13);
            codBarrasLabel.TabIndex = 3;
            codBarrasLabel.Text = "Cod Barras:";
            // 
            // codBarrasTextBox
            // 
            this.codBarrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "CodBarras", true));
            this.codBarrasTextBox.Location = new System.Drawing.Point(95, 104);
            this.codBarrasTextBox.Name = "codBarrasTextBox";
            this.codBarrasTextBox.Size = new System.Drawing.Size(200, 20);
            this.codBarrasTextBox.TabIndex = 4;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(12, 133);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(95, 130);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descricaoTextBox.TabIndex = 6;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(12, 159);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 7;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(95, 156);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidadeTextBox.TabIndex = 8;
            // 
            // precoCompraLabel
            // 
            precoCompraLabel.AutoSize = true;
            precoCompraLabel.Location = new System.Drawing.Point(12, 185);
            precoCompraLabel.Name = "precoCompraLabel";
            precoCompraLabel.Size = new System.Drawing.Size(77, 13);
            precoCompraLabel.TabIndex = 9;
            precoCompraLabel.Text = "Preco Compra:";
            // 
            // precoCompraTextBox
            // 
            this.precoCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "PrecoCompra", true));
            this.precoCompraTextBox.Location = new System.Drawing.Point(95, 182);
            this.precoCompraTextBox.Name = "precoCompraTextBox";
            this.precoCompraTextBox.Size = new System.Drawing.Size(200, 20);
            this.precoCompraTextBox.TabIndex = 10;
            // 
            // precoVendaLabel
            // 
            precoVendaLabel.AutoSize = true;
            precoVendaLabel.Location = new System.Drawing.Point(12, 211);
            precoVendaLabel.Name = "precoVendaLabel";
            precoVendaLabel.Size = new System.Drawing.Size(72, 13);
            precoVendaLabel.TabIndex = 11;
            precoVendaLabel.Text = "Preco Venda:";
            // 
            // precoVendaTextBox
            // 
            this.precoVendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "PrecoVenda", true));
            this.precoVendaTextBox.Location = new System.Drawing.Point(95, 208);
            this.precoVendaTextBox.Name = "precoVendaTextBox";
            this.precoVendaTextBox.Size = new System.Drawing.Size(200, 20);
            this.precoVendaTextBox.TabIndex = 12;
            // 
            // validadeLabel
            // 
            validadeLabel.AutoSize = true;
            validadeLabel.Location = new System.Drawing.Point(12, 238);
            validadeLabel.Name = "validadeLabel";
            validadeLabel.Size = new System.Drawing.Size(51, 13);
            validadeLabel.TabIndex = 13;
            validadeLabel.Text = "Validade:";
            // 
            // validadeDateTimePicker
            // 
            this.validadeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbProdutoBindingSource, "Validade", true));
            this.validadeDateTimePicker.Location = new System.Drawing.Point(95, 234);
            this.validadeDateTimePicker.Name = "validadeDateTimePicker";
            this.validadeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validadeDateTimePicker.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(67, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 37);
            label1.TabIndex = 15;
            label1.Text = "Consultar";
            // 
            // tbProdutoDataGridView
            // 
            this.tbProdutoDataGridView.AutoGenerateColumns = false;
            this.tbProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbProdutoDataGridView.DataSource = this.tbProdutoBindingSource;
            this.tbProdutoDataGridView.Location = new System.Drawing.Point(324, 78);
            this.tbProdutoDataGridView.Name = "tbProdutoDataGridView";
            this.tbProdutoDataGridView.Size = new System.Drawing.Size(748, 220);
            this.tbProdutoDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodBarras";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodBarras";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecoCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "PrecoCompra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PrecoVenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "PrecoVenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Validade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Validade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 358);
            this.Controls.Add(this.tbProdutoDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(codBarrasLabel);
            this.Controls.Add(this.codBarrasTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(precoCompraLabel);
            this.Controls.Add(this.precoCompraTextBox);
            this.Controls.Add(precoVendaLabel);
            this.Controls.Add(this.precoVendaTextBox);
            this.Controls.Add(validadeLabel);
            this.Controls.Add(this.validadeDateTimePicker);
            this.Controls.Add(this.tbProdutoBindingNavigator);
            this.Name = "ConsultaProduto";
            this.Text = "ConsultaProduto";
            this.Load += new System.EventHandler(this.ConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingNavigator)).EndInit();
            this.tbProdutoBindingNavigator.ResumeLayout(false);
            this.tbProdutoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MercadoDataSet mercadoDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private MercadoDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private MercadoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbProdutoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbProdutoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox codBarrasTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox precoCompraTextBox;
        private System.Windows.Forms.TextBox precoVendaTextBox;
        private System.Windows.Forms.DateTimePicker validadeDateTimePicker;
        private System.Windows.Forms.DataGridView tbProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}