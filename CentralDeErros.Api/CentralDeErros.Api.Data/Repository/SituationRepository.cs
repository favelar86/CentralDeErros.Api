using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class SituationRepository : RepositoryBase<Situation>, ISituationRepository
    {
       public SituationRepository(Context contexto) : base(contexto)
        {

        }
    }
}
