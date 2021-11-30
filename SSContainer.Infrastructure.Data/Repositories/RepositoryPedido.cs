using APISistema;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Data;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryPedido : RepositoryUpdateDelete<Pedido>, IPedidoRepository
    {
        private new readonly ApiDbContext _context;
        public RepositoryPedido(ApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}