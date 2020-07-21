using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Authorization;

namespace CentralDeErros.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentsController : ControllerBase
    {
        private readonly IEnvironmentRepository _repo;

        public EnvironmentsController(IEnvironmentRepository repo)
        {
            _repo = repo;
        }
      
        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<Environment> Get()
        {
            return _repo.SelecionarTodos(); 
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public Environment Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<Environment> Post([FromBody] Environment environment)
        {
            _repo.Incluir(environment);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<Environment> Put([FromBody] Environment name)
        {
            _repo.Alterar(name);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<Environment> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
