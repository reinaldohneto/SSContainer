using SSContainer.Application.Interfaces;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SSContainer.Application.Service
{
    public class ApplicationServiceProduto : IApplicationServiceProduto, IDisposable
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }
        public void Add(AddProdutoInputModel obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _serviceProduto.Add(objProduto);
        }

        public void Dispose()
        {
            _serviceProduto.Dispose();
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var objProdutos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListProdutos(objProdutos);
        }

        public ProdutoViewModel GetById(int id)
        {
            var objProduto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperToViewModel(objProduto);
        }

        public void Remove(int id)
        {
            _serviceProduto.Remove(id);
        }

        public void Update(int id, UpdateProdutoInputModel obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _serviceProduto.Update(id, objProduto);
        }
    }
}
