using System.Collections.Generic;

namespace SSContainer.Application.Models.Models
{
    public class PedidoViewModel
    {
        public EmpresaViewModel EmpresaVendedora { get; private set; }
        public EmpresaViewModel EmpresaCompradora { get; private set; }
        public List<ProdutoViewModel> Produtos { get; set; }
    }
}
