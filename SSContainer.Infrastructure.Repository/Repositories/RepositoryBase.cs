using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Infrastructure.Repository.Repositorys
{
  public class RepositoryBase : IDisposable, IRepositoryBase<TEntity> where TEntity : class
  {
    private readonly SqlContext _context;

    public RepositoryBase(SqlContext context)
    {
      _context = context;
    }

    public virtual void Add(TEntity obj)
    {
      try
      {
        _context.Set<TEntity>().Add(obj);
        _context.SaveChanges();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public virtual TEntity GetById(int id)
    {
      return _context.Set<TEntity>().Find(id);
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
      return _context.Set<TEntity>().ToList();
    }

    public virtual void Dispose()
    {
      _context.Dispose();
    }
  }
}
