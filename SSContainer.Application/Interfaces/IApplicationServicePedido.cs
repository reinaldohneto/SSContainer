using SSContainer.Application.Models.Models;
using System.Collections.Generic;

namespace SSContainer.Application.Interfaces
{
    public interface IApplicationServicePedido
    {
        void Add(AddPedidoInputModel obj);
        PedidoViewModel GetById(int id);
        IEnumerable<PedidoViewModel> GetAll();
        void Update(int id, UpdatePedidoInputModel obj);
        void Remove(int id);
        void Dispose();
    }
}
