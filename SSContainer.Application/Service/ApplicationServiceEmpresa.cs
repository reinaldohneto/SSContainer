using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SSContainer.Application.Service
{
    public class ApplicationServiceEmpresa : IApplicationServiceEmpresa, IDisposable
    {
        private readonly IServiceEmpresa _serviceEmpresa;
        private readonly IMapperEmpresa _mapperEmpresa;

        public ApplicationServiceEmpresa(IServiceEmpresa serviceEmpresa, IMapperEmpresa mapperEmpresa)
        {
            _serviceEmpresa = serviceEmpresa;
            _mapperEmpresa = mapperEmpresa;
        }
        public void Add(AddEmpresaInputModel obj)
        {
            var objEmpresa = _mapperEmpresa.MapperToEntity(obj);
            _serviceEmpresa.Add(objEmpresa);
        }

        public void Dispose()
        {
            _serviceEmpresa.Dispose();
        }

        public IEnumerable<EmpresaViewModel> GetAll()
        {
            var objEmpresas = _serviceEmpresa.GetAll();
            return _mapperEmpresa.MapperListEmpresas(objEmpresas);
        }

        public EmpresaViewModel GetById(int id)
        {
            var objEmpresa = _serviceEmpresa.GetById(id);
            return _mapperEmpresa.MapperToViewModel(objEmpresa);
        }

        public void Remove(int id)
        {
            _serviceEmpresa.Remove(id);
        }

        public void Update(int id, UpdateEmpresaInputModel obj)
        {
            var objEmpresa = _mapperEmpresa.MapperToEntity(obj);
            _serviceEmpresa.Update(id, objEmpresa);
        }
    }
}
