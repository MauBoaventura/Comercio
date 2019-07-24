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
        public Caixa(double valor)
        {
            InitializeComponent();
            this.valorCaixa = valor;
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
            if (e.KeyChar == 13)
            {
                ListViewItem list = new ListViewItem();
                list.SubItems.Add("a");
                list.SubItems.Add("b");

                // Inclui os itens no ListView
                listView1.Items.Add(list);

            }
            // Define os itens da lista
        }
    }
}
