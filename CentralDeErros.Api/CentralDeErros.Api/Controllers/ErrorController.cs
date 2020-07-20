using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Domain.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly IErrorRepository _repo;

        public ErrorController(IErrorRepository repo)
        {
            _repo = repo;
        }
      
        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<Error> Get()
        {
            return _repo.SelecionarTodos(); 
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public Error Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<Error> Post([FromBody] Error error)
        {
            _repo.Incluir(error);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<Error> Put([FromBody] Error name)
        {
            _repo.Alterar(name);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<Error> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
