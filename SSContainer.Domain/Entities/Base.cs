using System;

namespace SSContainer.Domain.Entities
{
  public abstract class Base
  {
    public int? Id { get; set; }
    public DateTime DataCadastro { get; set; }
  }
}