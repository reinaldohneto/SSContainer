using System.Collections.Generic;

namespace SSContainer.Domain.Interfaces
{
  public interface IBaseRepository<TEntity> where TEntity : class
  {
    void Add(TEntity obj);
    TEntity GetById(int id);
    IEnumerable<TEntity> GetAll();
    void Dispose();
  }
}