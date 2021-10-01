namespace SSContainer.Domain.Core.Interfaces.Services
{
  public interface IServiceUpdateDeleteObj<TEntity> : IServiceBase<TEntity> where TEntity : class
  {
    void Update(TEntity obj);
    void Remove(TEntity obj);
  }
}