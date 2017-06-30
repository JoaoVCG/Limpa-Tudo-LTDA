using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.Model
{
    public class ItemPedido
    {
        public int id { get; set; }
        public int pedido { get; set; }
        public int produto { get; set; }
        public DateTime entrega { get; set; }
        public float valor { get; set; }
        public int dias { get; set; }

    }
}
