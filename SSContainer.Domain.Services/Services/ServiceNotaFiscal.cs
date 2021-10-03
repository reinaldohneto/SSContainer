using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;

namespace SSContainer.Domain.Services.Services
{
    public class ServiceNotaFiscal : ServiceBase<NotaFiscal>, IServiceNotaFiscal
    {
        public readonly INotaFiscalRepository _notaFiscalRepository;

        public ServiceNotaFiscal(INotaFiscalRepository notaFiscalRepository)
            : base(notaFiscalRepository)
        {
            _notaFiscalRepository = notaFiscalRepository;
        }
    }
}
