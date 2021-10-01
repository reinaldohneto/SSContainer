using System;

namespace SSContainer.Domain.Entities
{
  public class Produto : Base
  {
    public Produto(string nome, string codigoDeBarras, decimal valor)
    {
      Nome = nome;
      CodigoDeBarras = codigoDeBarras;
      Valor = valor;

      DataCadastro = DateTime.Now;
      Ativo = true;
    }
    public string Nome { get; private set; }
    public string CodigoDeBarras { get; private set; }
    public decimal Valor { get; private set; }
    public bool Ativo { get; private set; }

    public void Update(string nome, string codigoDeBarras,
                       decimal valor, bool ativo)
    {
      Nome = nome;
      CodigoDeBarras = codigoDeBarras;
      Valor = valor;

      Ativo = ativo;
    }
  }
}