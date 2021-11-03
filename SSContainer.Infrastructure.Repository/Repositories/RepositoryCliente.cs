namespace SSContainer.Infrastructure.Repository.Repositories
{
  public class RepositoryCliente : RepositoryUpdateDelete<Empresa>, IRepositoryCliente
  {
    private readonly SqlContext _context;
    public RepositoryCliente(SqlContext context) : base(context)
    {
      _context = context;
    }
  }
}