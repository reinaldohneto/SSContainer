using SSContainer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Domain.Services.Services
{
  public abstract class AbstractServiceUpdateDelete<TEntity> : ServiceBase<TEntity> where TEntity : class
  {

    private new readonly IDeleteUpdateRepository<TEntity> _repository;
    public AbstractServiceUpdateDelete(IDeleteUpdateRepository<TEntity> repository) : base(repository)
    {
      _repository = repository;
    }

    public virtual void Update(int id, TEntity obj)
    {
      _repository.Update(id, obj);
    }

    public virtual void Remove(int id)
    {
      _repository.Remove(id);
    }
  }
}
