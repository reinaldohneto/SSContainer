namespace SSContainer.Infrastructure.Repository.Repositories
{
  public class RepositoryProduto : RepositoryUpdateDelete<Produto>, IRepositoryProduto
  {
    private readonly SqlContext _context;
    public RepositoryProduto(SqlContext context) : base(context)
    {
      _context = context;
    }
  }
}