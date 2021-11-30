using SSContainer.Application.Interfaces;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using AutoMapper;
using SSContainer.Domain.Entities;

namespace SSContainer.Application.Service
{
    public class ApplicationServicePedido : IApplicationServicePedido, IDisposable
    {
        private readonly IServicePedido _servicePedido;
        private readonly IMapper _mapperPedido;
        private readonly IApplicationServiceEmpresa _service;
        private readonly IApplicationServiceProduto _serviceProduto;

        public ApplicationServicePedido(IServicePedido servicePedido, IMapper mapperPedido, IApplicationServiceEmpresa service, IApplicationServiceProduto serviceProduto)
        {
            _servicePedido = servicePedido;
            _mapperPedido = mapperPedido;
            _service = service;
            _serviceProduto = serviceProduto;
        }
        public void Add(AddPedidoInputModel obj)
        {
            var empresaCompradora = _service.GetById(obj.EmpresaCompradoraId);
            var empresaVendedora = _service.GetById(obj.EmpresaVendedoraId);
            var objPedido = new Pedido(
                new Empresa(empresaCompradora.CNPJ, empresaCompradora.NomeEmpresa, empresaCompradora.RazaoSocial,
                    empresaCompradora.Endereco, empresaCompradora.Telefone, empresaCompradora.InscricaoEstadual),
                new Empresa(empresaVendedora.CNPJ, empresaVendedora.NomeEmpresa, empresaVendedora.RazaoSocial,
                    empresaVendedora.Endereco, empresaVendedora.Telefone, empresaVendedora.InscricaoEstadual));

            foreach (var listProduct in obj.ListProducts)
            {
                var produto = _serviceProduto.GetById(listProduct);
                objPedido.AddProduto(new Produto(produto.Nome, produto.CodigoDeBarras, produto.Valor));
            }


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
