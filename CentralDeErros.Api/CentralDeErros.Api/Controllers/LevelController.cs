using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Domain.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelRepository _repo;

        public LevelController(ILevelRepository repo)
        {
            _repo = repo;
        }
      
        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<Level> Get()
        {
            return _repo.SelecionarTodos(); 
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public Level Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<Level> Post([FromBody] Level level)
        {
            _repo.Incluir(level);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<Level> Put([FromBody] Level name)
        {
            _repo.Alterar(name);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<Level> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
