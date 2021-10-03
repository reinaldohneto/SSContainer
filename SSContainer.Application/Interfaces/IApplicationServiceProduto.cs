using SSContainer.Application.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(AddProdutoInputModel obj);
        ProdutoViewModel GetById(int id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Update(int id, UpdateProdutoInputModel obj);
        void Remove(int id);
        void Dispose();
    }
}
