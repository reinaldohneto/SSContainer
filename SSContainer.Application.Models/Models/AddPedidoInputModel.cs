using System.Collections.Generic;

namespace SSContainer.Application.Models.Models
{
    public class AddPedidoInputModel
    {
        public int EmpresaVendedoraId { get; set; }
        public int EmpresaCompradoraId { get; set; }
        public List<int> ListProducts { get; set; }
    }
}
