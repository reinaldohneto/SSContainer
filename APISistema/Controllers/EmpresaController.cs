using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SSContainer.Application;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;

namespace APISistema.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepository _repository;

        public EmpresaController(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<EmpresaViewModel> Adicionar(AddEmpresaInputModel empresaModel)
        {
            if (!ModelState.IsValid) return BadRequest(); 
            
            _repository.Add(new Empresa(empresaModel.CNPJ, empresaModel.NomeEmpresa, empresaModel.RazaoSocial, empresaModel.Endereco, empresaModel.Telefone, empresaModel.InscricaoEstadual));
            
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<EmpresaViewModel> GetById(int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var empresa = _repository.GetById(id);

            if (empresa==null)
            {
                empresa = new Empresa();
            }

            return Ok(empresa);
        }

        [HttpGet]
        public ActionResult<List<Empresa>> GetAll()
        {
            if (!ModelState.IsValid) return BadRequest();

            var empresa = _repository.GetAll();

            if (empresa != null)
            {
                return Ok(empresa);
            }

            return NotFound();

        }
    }
}