using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Domain.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorOccurrenceController : ControllerBase
    {
        private readonly IErrorOccurrenceRepository _repo;

        public ErrorOccurrenceController(IErrorOccurrenceRepository repo)
        {
            _repo = repo;
        }
      
        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<ErrorOccurrence> Get()
        {
            return _repo.SelecionarTodos(); 
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public ErrorOccurrence Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<ErrorOccurrence> Post([FromBody] ErrorOccurrence errorOccurrence)
        {
            _repo.Incluir(errorOccurrence);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<ErrorOccurrence> Put([FromBody] ErrorOccurrence name)
        {
            _repo.Alterar(name);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<ErrorOccurrence> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
