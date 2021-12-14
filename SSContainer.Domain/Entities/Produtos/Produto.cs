using System;
using System.Collections;
using System.Collections.Generic;

namespace SSContainer.Domain.Entities
{
    public class Produto : Base
    {
        public Produto()
        {
        }

        public Produto(string nome, string codigoDeBarras, decimal valor)
        {
            Nome = nome;
            DataCadastro = DateTime.Now;
        }
        public string Nome { get; private set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public void Update(string nome, string codigoDeBarras,
                           decimal valor, bool ativo)
        {
            Nome = nome;
        }
    }
}