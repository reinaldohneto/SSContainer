using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;

namespace SSContainer.Domain.Services.Services
{
    public class ServicePedido : AbstractServiceUpdateDelete<Pedido>, IServicePedido
    {
        public readonly IPedidoRepository _pedidoRepository;

        public ServicePedido(IPedidoRepository pedidoRepository)
            : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
    }
}
