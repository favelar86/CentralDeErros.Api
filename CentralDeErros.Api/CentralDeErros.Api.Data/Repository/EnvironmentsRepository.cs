using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class EnvironmentsRepository : RepositoryBase<Environment>, IEnvironmentRepository
    {
       public EnvironmentsRepository(Context contexto) : base(contexto)
        {

        }
    }
}
