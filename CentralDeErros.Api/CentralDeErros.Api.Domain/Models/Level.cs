using CentralDeErros.Api.Domain.Repository;
using System.Collections.Generic;

namespace CentralDeErros.Api.Domain.Models
{
    public class Level : IEntity
    {
        public int Id { get; set; }

        public string LevelName { get; set; }

        public ICollection<Error> Errors { get; set; }
    }
}
