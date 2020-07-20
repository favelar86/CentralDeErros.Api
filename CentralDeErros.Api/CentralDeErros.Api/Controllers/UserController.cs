using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using CentralDeErros.Api.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] UserViewModel usuario)
        {
            return await _repo.Incluir(usuario.Nome, usuario.Email, usuario.Senha);
        }

        [HttpPost("Login")]
        public async Task<IdentityUser> Login(LoginViewModel login)
        {
            return await _repo.Login(login.Email, login.Senha);
        }
    }
}
