using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Models.Models
{
    public class UpdateEmpresaInputModel
    { 
        public string NomeEmpresa { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public bool Ativo { get; private set; }
    }
}
