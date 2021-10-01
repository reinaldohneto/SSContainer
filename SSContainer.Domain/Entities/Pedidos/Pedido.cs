using System;
using System.Collections.Generic;

namespace SSContainer.Domain.Entities
{
  public class Pedido : Base
  {

    public Pedido(Empresa empresaVendedora, Empresa empresaCompradora)
    {
      EmpresaVendedora = empresaVendedora;
      EmpresaCompradora = empresaCompradora;
      Produtos = new List<Produto>();

      DataCadastro = DateTime.Now;
    }
    public Empresa EmpresaVendedora { get; private set; }
    public Empresa EmpresaCompradora { get; private set; }
    public List<Produto> Produtos { get; set; }


    public void Update(Empresa empresaVendedora, Empresa empresaCompradora,
                       List<Produto> produtos)
    {
      EmpresaVendedora = empresaVendedora;
      EmpresaCompradora = empresaCompradora;
      Produtos = produtos;
    }

    public void AddProduto(Produto produto)
    {
      Produtos.Add(produto);
    }
  }
}