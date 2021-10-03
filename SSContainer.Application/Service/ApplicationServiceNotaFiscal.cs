using SSContainer.Application.Interfaces;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SSContainer.Application.Service
{
    public class ApplicationServiceNotaFiscal : IApplicationServiceNotaFiscal, IDisposable
    {
        private readonly IServiceNotaFiscal _serviceNotaFiscal;
        private readonly IMapperNotaFiscal _mapperNotaFiscal;

        public ApplicationServiceNotaFiscal(IServiceNotaFiscal serviceNotaFiscal, IMapperNotaFiscal mapperNotaFiscal)
        {
            _serviceNotaFiscal = serviceNotaFiscal;
            _mapperNotaFiscal = mapperNotaFiscal;
        }
        public void Add(AddNotaFiscalInputModel obj)
        {
            var objNotaFiscal = _mapperNotaFiscal.MapperToEntity(obj);
            _serviceNotaFiscal.Add(objNotaFiscal);
        }

        public void Dispose()
        {
            _serviceNotaFiscal.Dispose();
        }

        public IEnumerable<NotaFiscalViewModel> GetAll()
        {
            var objNotaFiscal = _serviceNotaFiscal.GetAll();
            return _mapperNotaFiscal.MapperListNotaFiscal(objNotaFiscal);
        }

        public NotaFiscalViewModel GetById(int id)
        {
            var objNotaFiscal = _serviceNotaFiscal.GetById(id);
            return _mapperNotaFiscal.MapperToViewModel(objNotaFiscal);
        }
    }
}
