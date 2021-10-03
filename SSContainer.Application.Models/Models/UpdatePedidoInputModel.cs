using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class UpdatePedidoInputModel
    {
        public int EmpresaVendedoraId { get; private set; }
        public int EmpresaCompradoraId { get; private set; }
        public List<int> Produtos { get; set; }
    }
}
