using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;

namespace SSContainer.Domain.Services.Services
{
    public class ServiceProduto : AbstractServiceUpdateDelete<Produto>, IServiceProduto
    {
        public readonly IProdutoRepository _produtoRepository;

        public ServiceProduto(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
