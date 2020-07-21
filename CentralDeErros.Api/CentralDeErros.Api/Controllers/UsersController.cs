using System.Collections.Generic;
using CentralDeErros.Api.Domain.Models;
using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _repo;

        public UsersController(IUsersRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<Environments>
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET api/<Environments>/5
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Environments>
        [HttpPost]
        public IEnumerable<Users> Post([FromBody] Users Users)
        {
            _repo.Incluir(Users);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Environments>/5
        [HttpPut]
        public IEnumerable<Users> Put([FromBody] Users name)
        {
            _repo.Alterar(name);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Environments>/5
        [HttpDelete("{id}")]
        public IEnumerable<Users> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
