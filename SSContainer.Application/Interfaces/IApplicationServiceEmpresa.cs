using SSContainer.Application.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application
{
    public interface IApplicationServiceEmpresa
    {
        int? Add(AddEmpresaInputModel obj);
        EmpresaViewModel GetById(int id);
        IEnumerable<EmpresaViewModel> GetAll();
        void Update(int id, UpdateEmpresaInputModel obj);
        void Remove(int id);
        void Dispose();
    }
}
