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

        private void Button1_Click(object sender, EventArgs e)
        {
           
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

        private void pesquisaProduto(object sender, KeyPressEventArgs e)
        { 
            if (primeiraVez)
            {
                listView1.Items.Clear(); listView1.Items.Clear();
                primeiraVez = false;
            }
            if (e.KeyChar == 13)
            {
                DAL dao = new DAL();
                Produto prod = dao.SelectByCod(cmdSelecionarByCod, textBox1.Text);
                ListViewItem list = new ListViewItem(contador.ToString());
                list.SubItems.Add(prod.Descricao);
                list.SubItems.Add(prod.Quantidade.ToString());
                list.SubItems.Add(prod.PrecoVenda.ToString());
                double final = Double.Parse(prod.PrecoVenda)*1;
                list.SubItems.Add(final.ToString());

                // Inclui os itens no ListView
                listView1.Items.Add(list);

            }
            // Define os itens da lista
        }
    }
}
