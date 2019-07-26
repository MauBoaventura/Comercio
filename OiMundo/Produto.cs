using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
  public class Produto
    {
       
        public int Id { get; set; }
        public string CodBarras { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
        public string PrecoCompra { get; set; }
        public string PrecoVenda { get; set; }

    }
}
