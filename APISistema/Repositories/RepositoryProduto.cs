using APISistema;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryProduto : RepositoryUpdateDelete<Produto>, IProdutoRepository
    {
        private new readonly ApiDbContext _context;
        public RepositoryProduto(ApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}