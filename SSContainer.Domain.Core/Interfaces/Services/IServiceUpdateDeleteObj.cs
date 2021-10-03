namespace SSContainer.Domain.Core.Interfaces.Services
{
  public interface IServiceUpdateDeleteObj<TEntity> : IServiceBase<TEntity> where TEntity : class
  {
    void Update(int id, TEntity obj);
    void Remove(int id);
  }
}