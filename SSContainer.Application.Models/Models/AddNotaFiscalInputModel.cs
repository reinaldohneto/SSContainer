using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class AddNotaFiscalInputModel
    {
        public int PedidoId { get; set; }
        public int EmpresaVendedoraId { get; set; }
        public int EmpresaCompradoraId { get; set; }
        public string SerieNf { get; set; }
    }
}
