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

        }
    }
}
