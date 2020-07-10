using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class ErrorOccurrenceRepository : RepositoryBase<ErrorOccurrence>, IErrorOccurrenceRepository
    {
       public ErrorOccurrenceRepository(Context contexto) : base(contexto)
        {

        }
    }
}
