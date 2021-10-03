using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class UpdateProdutoInputModel
    {
        public string Nome { get; private set; }
        public string CodigoDeBarras { get; private set; }
        public decimal Valor { get; private set; }
        public bool Ativo { get; private set; }
    }
}
