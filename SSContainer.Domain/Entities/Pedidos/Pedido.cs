using System;
using System.Collections.Generic;

namespace SSContainer.Domain.Entities
{
    public class Pedido : Base
    {
        public Pedido()
        {
        }

        public Pedido(Empresa empresaVendedora, Cliente cliente)
        {
            EmpresaVendedora = empresaVendedora;
            Cliente = cliente;
            Produtos = new List<Produto>();

            DataCadastro = DateTime.Now;
        }
        public Empresa EmpresaVendedora { get; private set; }
        public Cliente Cliente { get; private set; }
        public ICollection<JoinEmpresas> Pedidos { get; set; }
        public List<Produto> Produtos { get; set; }
        
        public void Update(Empresa empresaVendedora, Cliente cliente,
                           List<Produto> produtos)
        {
            EmpresaVendedora = empresaVendedora;
            Cliente = cliente;
            Produtos = produtos;
        }

        public void AddProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}