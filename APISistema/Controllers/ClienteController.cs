using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSContainer.Application.Models.Models;
using SSContainer.Domain;
using SSContainer.Domain.Interfaces;

namespace APISistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _cliente;

        public ClienteController(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        [HttpPost]
        public ActionResult<ClienteViewModel> Adicionar(ClienteInputModel clienteModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            Cliente cliente = new Cliente(clienteModel.Nome);

            _cliente.Add(cliente);

            return Ok(new ClienteViewModel(cliente.Id, cliente.Nome));
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetAll()
        {
            return Ok(_cliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetAll(int id)
        {
            return Ok(_cliente.GetById(id));
        }
    }
}
