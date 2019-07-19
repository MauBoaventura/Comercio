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
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        private void Abertura_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gambiarra, consertar usando Thread
            CadastroProduto cad = new CadastroProduto();
            cad.Show();
        }

        private void CadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
     //       CadastroCliente cada = new CadastroCliente();
       //     cada.Show();
        }

        private void ExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutoExistente cad = new CadastroProdutoExistente();
            cad.Show();
        }

        private void AdicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temporario cad = new Temporario();
            cad.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Consultar produto em estoque
            ConsultaProduto consultaProduto = new ConsultaProduto();
            consultaProduto.Show();
        }
    }
}
