using System.Collections.Generic;

namespace SSContainer.Domain.Core.Interfaces.Services
{
  public interface IServiceBase<TEntity> where TEntity : class
  {
    void Add(TEntity obj);
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    void Dispose();
  }
}