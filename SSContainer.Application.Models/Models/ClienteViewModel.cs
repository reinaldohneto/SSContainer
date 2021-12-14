using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class ClienteViewModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; }

        public ClienteViewModel(int? id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
