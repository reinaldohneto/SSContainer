using AutoMapper;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSContainer.Infrastructure.Profiles
{
    public class NotaFiscalProfile : Profile
    {
        public NotaFiscalProfile()
        {
            CreateMap<NotaFiscal, NotaFiscalViewModel>(); 
        }
    }
}
