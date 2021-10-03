using SSContainer.Domain.Interfaces;
using SSContainer.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSContainer.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly SqlContext _context;
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

        public virtual void Dispose()
        {
            _context.Dispose();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
