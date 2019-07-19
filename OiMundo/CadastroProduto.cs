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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste dessa caceta!\n\n oi");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_CadastrarProduto(object sender, EventArgs e)
        {
            string CodBarras = textCodigoDeBarras.Text;
            string Descricao = textDescricao.Text;
            int Quantidade = (int)numericQuantidade.Value;
            string PrecoCompra = textPrecoCompra.Text;
            DateTime Validade =dateVencimento.Value;
            string PrecoVenda = textPrecoVenda.Text;

            Produto p = new Produto();
            p.CodBarras = CodBarras;
            p.Descricao = Descricao;
            p.Quantidade = Quantidade;
            p.PrecoCompra = PrecoCompra;
            p.Validade = Validade;
            p.PrecoVenda = PrecoVenda;

            DAL banco = new DAL();
            int flag = banco.Insert(p,cmdInserir);
            if(flag>0)
                System.Windows.Forms.MessageBox.Show("Cadastro efetuado com sucesso!");
            else
                System.Windows.Forms.MessageBox.Show("ERRO! Cadastro não efetuado!");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("10%");
            comboBox1.Items.Add("20%");
            comboBox1.Items.Add("30%");
            comboBox1.Items.Add("40%");
            comboBox1.Items.Add("50%");
            comboBox1.Items.Add("60%");
            comboBox1.Items.Add("70%");
            comboBox1.Items.Add("80%");
            comboBox1.Items.Add("90%");
            comboBox1.Items.Add("100%");
        }
    }
}
