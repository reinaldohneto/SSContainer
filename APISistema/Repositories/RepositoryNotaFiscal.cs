using APISistema;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryNotaFiscal : RepositoryBase<NotaFiscal>, INotaFiscalRepository
    {
        private new readonly ApiDbContext _context;
        public RepositoryNotaFiscal(ApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}