using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class NotaFiscalViewModel
    {
        public int? Id { get; set; }
        public int NumeroNF { get; private set; }
        public string SerieNF { get; set; }
        public DateTime DataGeracao { get; private set; }
        public PedidoViewModel Pedido { get; private set; }
    }
}
