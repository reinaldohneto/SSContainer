using System;
using System.Collections.Generic;
using SSContainer.Domain.Entities;

namespace SSContainer.Domain
{
    public class Cliente : Base
    {

        public string Nome { get; set; }
        public ICollection<JoinEmpresas> Pedidos { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}