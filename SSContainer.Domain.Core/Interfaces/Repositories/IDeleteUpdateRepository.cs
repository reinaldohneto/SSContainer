namespace SSContainer.Domain.Interfaces
{
    public interface IDeleteUpdateRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        void Update(int id, TEntity obj);
        void Remove(int id);
    }
}
