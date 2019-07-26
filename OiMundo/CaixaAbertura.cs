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
    public partial class CaixaAbertura : Form
    {
        public CaixaAbertura()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double valorAberturaCaixa = Double.Parse(textBox1.Text);
            Caixa a = new Caixa(valorAberturaCaixa);
            a.Show();
            this.Close();
        }

        private void ApertaEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                double valorAberturaCaixa = Double.Parse(textBox1.Text);
                Caixa a = new Caixa(valorAberturaCaixa);
                a.Show();
                this.Close();
            }
        }
    }
}
