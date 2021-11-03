using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Data;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryNotaFiscal : RepositoryBase<NotaFiscal>, INotaFiscalRepository
    {
        private new readonly SqlContext _context;
        public RepositoryNotaFiscal(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}