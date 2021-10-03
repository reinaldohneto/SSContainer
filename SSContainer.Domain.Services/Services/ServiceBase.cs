using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SSContainer.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable,
                                                 IServiceBase<TEntity> where TEntity : class
    {
        protected readonly IBaseRepository<TEntity> _repository;

        public ServiceBase(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}