namespace SSContainer.Infrastructure.Repository.Repositories
{
  public class RepositoryUpdateDelete : RepositoryBase, IRepositoryUpdateDelete<TEntity>
      where TEntity : class
  {
    private readonly SqlContext _context;

    public RepositoryUpdateDelete(SqlContext context) : base(context)
    {
      _context = context;
    }

    public virtual void Update(int id, TEntity obj)
    {
      try
      {
        _context.Entry(obj).State = EntityState.Modified;
        _context.SaveChanges();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public virtual void Remove(TEntity obj)
    {
      try
      {
        _context.Set<TEntity>().Remove(obj);
        _context.SaveChanges();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}