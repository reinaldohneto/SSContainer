using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Data;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
  public class RepositoryEmpresa : RepositoryUpdateDelete<Empresa>, IEmpresaRepository
  {
    private new readonly SqlContext _context;
    public RepositoryEmpresa(SqlContext context) : base(context)
    {
      _context = context;
    }
  }
}