using APISistema;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
    public class RepositoryEmpresa : RepositoryUpdateDelete<Empresa>, IEmpresaRepository
  {
    private new readonly ApiDbContext _context;
    public RepositoryEmpresa(ApiDbContext context) : base(context)
    {
      _context = context;
    }
  }
}