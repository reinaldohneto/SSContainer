using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Domain.Services.Services
{
    public class ServiceEmpresa : AbstractServiceUpdateDelete<Empresa>, IServiceEmpresa
    {
        public readonly IEmpresaRepository _empresaRepository;

        public ServiceEmpresa(IEmpresaRepository empresaRepository)
            :base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
