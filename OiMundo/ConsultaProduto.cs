using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class ConsultaProduto : Form
    {
        public ConsultaProduto()
        {
            InitializeComponent();
        }

        private void TbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.tbProdutoTableAdapter.FillBy(this.mercadoDataSet.tbProduto, System.Convert.ToInt32(idTextBox.Text));
            /*this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadoDataSet);
            */
        }

        private void ConsultaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadoDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
          //  this.tbProdutoTableAdapter.Fill(this.mercadoDataSet.tbProduto);

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
           // this.tbProdutoTableAdapter.FillBy(this.mercadoDataSet.tbProduto, System.Convert.ToInt32(idTextBox.Text));

        }
    }
}
