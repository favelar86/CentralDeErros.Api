using CentralDeErros.Api.Data.Map;
using CentralDeErros.Api.Domain.Repository;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Repository
{
    public class LevelRepository : RepositoryBase<Level>, ILevelRepository
    {
       public LevelRepository(Context contexto) : base(contexto)
        {

        }
    }
}
