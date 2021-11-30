using AutoMapper;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using SSContainer.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SSContainer.Application.Service
{
    public class ApplicationServiceEmpresa : IApplicationServiceEmpresa, IDisposable
    {
        private readonly IServiceEmpresa _serviceEmpresa;
        private readonly IMapper _mapperEmpresa;

        public ApplicationServiceEmpresa(IServiceEmpresa serviceEmpresa, IMapper mapperEmpresa)
        {
            _serviceEmpresa = serviceEmpresa;
            _mapperEmpresa = mapperEmpresa;
        }
        public int? Add(AddEmpresaInputModel obj)
        {
            var objEmpresa = new Empresa(obj.CNPJ, obj.NomeEmpresa, obj.RazaoSocial, obj.Endereco, obj.Telefone, obj.InscricaoEstadual);
            _serviceEmpresa.Add(objEmpresa);

            return objEmpresa.Id;
        }

        public void Dispose()
        {
            _serviceEmpresa.Dispose();
        }

        public IEnumerable<EmpresaViewModel> GetAll()
        {
            var objEmpresas = _serviceEmpresa.GetAll();
            return _mapperEmpresa.Map<List<EmpresaViewModel>>(objEmpresas);
        }

        public EmpresaViewModel GetById(int id)
        {
            var objEmpresa = _serviceEmpresa.GetById(id);
            return _mapperEmpresa.Map<EmpresaViewModel>(objEmpresa);
        }

        public void Remove(int id)
        {
            _serviceEmpresa.Remove(id);
        }

        public void Update(int id, UpdateEmpresaInputModel obj)
        {
            var objEmpresa = _serviceEmpresa.GetById(id);
            objEmpresa.Update(obj.CNPJ, obj.NomeEmpresa, obj.RazaoSocial, obj.Endereco, obj.Telefone, obj.InscricaoEstadual, obj.Ativo);
            _serviceEmpresa.Update(id, objEmpresa);
        }
    }
}
