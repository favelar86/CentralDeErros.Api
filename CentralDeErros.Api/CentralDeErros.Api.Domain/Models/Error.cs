using CentralDeErros.Api.Domain.Repository;
using System.Collections.Generic;

namespace CentralDeErros.Api.Domain.Models
{
    public class Error : IEntity
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int EnvironmentId { get; set; }

        public Environment Environment { get; set;  }

        public int LevelId { get; set; }

        public Level Level { get; set; }

        public ICollection<ErrorOccurrence> ErrorOccurrence { get; set; }
    }
}
