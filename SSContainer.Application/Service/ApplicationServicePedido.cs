using SSContainer.Application.Interfaces;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SSContainer.Application.Service
{
    public class ApplicationServicePedido : IApplicationServicePedido, IDisposable
    {
        private readonly IServicePedido _servicePedido;
        private readonly IMapperPedido _mapperPedido;

        public ApplicationServicePedido(IServicePedido servicePedido, IMapperPedido mapperPedido)
        {
            _servicePedido = servicePedido;
            _mapperPedido = mapperPedido;
        }
        public void Add(AddPedidoInputModel obj)
        {
            var objPedido = _mapperPedido.MapperToEntity(obj);
            _servicePedido.Add(objPedido);
        }

        public void Dispose()
        {
            _servicePedido.Dispose();
        }

        public IEnumerable<PedidoViewModel> GetAll()
        {
            var objPedidos = _servicePedido.GetAll();
            return _mapperPedido.MapperListPedidos(objPedidos);
        }

        public PedidoViewModel GetById(int id)
        {
            var objPedido = _servicePedido.GetById(id);
            return _mapperPedido.MapperToViewModel(objPedido);
        }

        public void Remove(int id)
        {
            _servicePedido.Remove(id);
        }

        public void Update(int id, UpdatePedidoInputModel obj)
        {
            var objPedido = _mapperPedido.MapperToEntity(obj);
            _servicePedido.Update(id, objPedido);
        }
    }
}
