using CentralDeErros.Api.Domain.Repository;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CentralDeErros.Api.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Incluir(string nome, string email, string senha)
        {
            var usu = new IdentityUser()
            {
                UserName = nome,
                Email = email,
                EmailConfirmed = true
            };

            var retorno = await _userManager.CreateAsync(usu, senha);

            return retorno.Succeeded;
        }

        public async Task<IdentityUser> Login(string email, string senha)
        {
            var usuario = await _userManager.FindByEmailAsync(email);
            if (usuario != null &&
                await _userManager.CheckPasswordAsync(usuario, senha))
            {
                return usuario;
            }

            return null;
        }
    }
}
