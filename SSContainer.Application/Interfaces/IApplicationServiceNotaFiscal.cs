using SSContainer.Application.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Interfaces
{
    public interface IApplicationServiceNotaFiscal
    {
        void Add(AddNotaFiscalInputModel obj);
        NotaFiscalViewModel GetById(int id);
        IEnumerable<NotaFiscalViewModel> GetAll();
        void Dispose();
    }
}
