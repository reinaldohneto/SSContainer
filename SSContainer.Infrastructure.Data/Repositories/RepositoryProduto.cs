using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Data;
using SSContainer.Infrastructure.Repositories;

namespace SSContainer.Infrastructure.Repository.Repositories
{
  public class RepositoryProduto : RepositoryUpdateDelete<Produto>, IProdutoRepository
  {
    private new readonly SqlContext _context;
    public RepositoryProduto(SqlContext context) : base(context)
    {
      _context = context;
    }
  }
}