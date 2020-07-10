using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
       public ErrorRepository(Context contexto) : base(contexto)
        {

        }
    }
}
