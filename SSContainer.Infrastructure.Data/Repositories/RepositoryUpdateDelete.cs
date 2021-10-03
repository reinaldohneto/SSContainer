using Microsoft.EntityFrameworkCore;
using SSContainer.Infrastructure.Data;
using System;

namespace SSContainer.Infrastructure.Repositories
{
    public class RepositoryUpdateDelete<TEntity> : RepositoryBase<TEntity> where TEntity : class
    {
        public RepositoryUpdateDelete(SqlContext sqlContext) : base(sqlContext) { }

        public virtual void Remove(int id)
        {
            try
            {
                var obj = base._context.Set<TEntity>().Find(id);
                _context.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(int id, TEntity obj)
        {
            try
            {
                var objDB = _context.Set<TEntity>().Find(id);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
