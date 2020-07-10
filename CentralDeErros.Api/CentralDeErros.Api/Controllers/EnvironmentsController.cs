using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Data.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentsController : ControllerBase
    {
        private EnvironmentsRepository _repo;

        public EnvironmentsController()
        {
            _repo = new EnvironmentsRepository();
        }
      
        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<Environment> Get()
        {
            return _repo.RetornarTodos(); 
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public Environment Get(int id)
        {
            return _repo.BuscarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<Environment> Post([FromBody] Environment environment)
        {
            _repo.Incluir(environment);
            return _repo.RetornarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<Environment> Put([FromBody] Environment name)
        {
            _repo.Alterar(name);
            return _repo.RetornarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<Environment> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
