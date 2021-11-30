using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSContainer.Application;
using SSContainer.Application.Models.Models;
using SSContainer.Domain.Entities;
using SSContainer.Domain.Interfaces;

namespace APISistema.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpGet]
        public ActionResult<EmpresaViewModel> GetById(int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var empresa = _repository.GetById(id);

            if (empresa != null)
            {
                return Ok(empresa);
            }

            return NotFound();

        }
    }
}