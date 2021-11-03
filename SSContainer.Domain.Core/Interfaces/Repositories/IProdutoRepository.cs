using SSContainer.Domain.Entities;

namespace SSContainer.Domain.Interfaces
{
  public interface IProdutoRepository : IDeleteUpdateRepository<Produto>
  {
    //novos comportamentos do repository
  }
}