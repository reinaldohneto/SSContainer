using APISistema;
using SSContainer.Domain;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryCliente : RepositoryUpdateDelete<Cliente>, IClienteRepository
    {
        private new readonly ApiDbContext _context;
        public RepositoryCliente(ApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}