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
        public AbstractServiceUpdateDelete(IBaseRepository<TEntity> repository) : base(repository)
        {
        }

        public override void Add(TEntity obj)
        {
            base.Add(obj);
        }

        public override IEnumerable<TEntity> GetAll()
        {
            return base.GetAll();
        }

        public override TEntity GetById(int id)
        {
            return base.GetById(id);
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
