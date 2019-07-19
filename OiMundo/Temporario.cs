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
    public partial class Temporario : Form
    {
        public Temporario()
        {
            InitializeComponent();
        }

        private void TbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadoDataSet);
            MercadoDataSet a = new MercadoDataSet();
            

        }

        private void Temporario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadoDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.mercadoDataSet.tbProduto);


            MercadoDataSet.tbProdutoRow a = this.mercadoDataSet.tbProduto.FindById(2);

        }

       

    }
}
