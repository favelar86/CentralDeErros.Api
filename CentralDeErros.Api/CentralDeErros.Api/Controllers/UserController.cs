using System;
using System.Text;
using System.Threading.Tasks;
using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using CentralDeErros.Api.ViewModel;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;
        private readonly Token _token;

        public UserController(IUserRepository repo, IOptions<Token> token)
        {
            _repo = repo;
            _token = token?.Value;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] UserViewModel usuario)
        {
            return await _repo.Incluir(usuario.Nome, usuario.Email, usuario.Senha);
        }

        [HttpPost("Login")]
        public async Task<string> Login(LoginViewModel login)
        {
            var iu = await _repo.Login(login.Email, login.Senha);
            return GerarToken(iu);
        }

        private string GerarToken(IdentityUser usuario)
        {
            if (usuario == null) return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_token.Secret);

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = _token.Emissor,
                Audience = _token.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_token.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(descriptor);

            return tokenHandler.WriteToken(token);

        }
    }
}
