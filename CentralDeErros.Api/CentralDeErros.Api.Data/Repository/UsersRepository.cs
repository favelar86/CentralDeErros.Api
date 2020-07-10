using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
       public UsersRepository(Context contexto) : base(contexto)
        {

        }
    }
}
