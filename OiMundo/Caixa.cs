using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Caixa : Form
    {
        private bool primeiraVez;
        private int contador;
        public Caixa(double valor)
        {
            InitializeComponent();
            this.valorCaixa = valor;
            this.primeiraVez = true;
            this.contador = 1;
        }

        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            //inserirProduto();
            this.tbProdutoTableAdapter.FillByCodBarras(this.mercadoDataSet.tbProduto, textBox1.Text);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[2].Value = numeroItens.Value;
                string s1 = JsonConvert.SerializeObject(dataGridView1.Rows[i].Cells[3].Value).ToString();
                string outra = Regex.Match(s1, @"\d+").Value;
                MessageBox.Show(outra);
                double s2 = Double.Parse(outra);
                double s3 = Double.Parse(numeroItens.Value.ToString());
                dataGridView1.Rows[i].Cells[4].Value = s2*s3;
            }

        }

        private void inserirProduto()
        {
            DAL dao = new DAL();
            //Pesquisa o produto pelo Codigo
            Produto prod = dao.SelectByCod(cmdSelecionarByCod, textBox1.Text);
            if (prod != null)
            {
                ListViewItem list = new ListViewItem(contador.ToString());
                list.SubItems.Add(prod.Descricao);
                list.SubItems.Add(prod.Quantidade.ToString());
                list.SubItems.Add(prod.PrecoVenda.ToString());
                //Multiplica preco de venda com a quantidade
                double final = Double.Parse(prod.PrecoVenda) * Double.Parse(numeroItens.Value.ToString());
                list.SubItems.Add(final.ToString());

                // Inclui os itens no ListView
                //listaComProdutos.Items.Add(list);
                MercadoDataSet dataSet = new MercadoDataSet();
                //  dataSet.tbProduto.DataSet.Tables.

            }

        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(this.valorCaixa);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PesquisaProduto(object sender, KeyPressEventArgs e)
        {
            if (primeiraVez)
            {
                //listaComProdutos.Items.Clear(); listaComProdutos.Items.Clear();
                primeiraVez = false;
            }
            if (e.KeyChar == 13)
            {
                inserirProduto();
                //              ListViewItem a = listaComProdutos.Items.;
                //              a.ToString();
            }
            // Define os itens da lista
        }
    }
}
