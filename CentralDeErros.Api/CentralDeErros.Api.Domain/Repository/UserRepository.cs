using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CentralDeErros.Api.Domain.Repository
{
    public interface IUserRepository
    {
        Task<bool> Incluir(string nome, string email, string senha);
        Task<IdentityUser> Login(string email, string senha);
    }
}
