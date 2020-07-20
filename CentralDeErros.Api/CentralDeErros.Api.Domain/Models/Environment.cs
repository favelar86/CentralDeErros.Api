using CentralDeErros.Api.Domain.Repository;
using System.Collections.Generic;

namespace CentralDeErros.Api.Domain.Models
{
    public class Environment : IEntity
    {
        public int Id { get; set; }
        public string EnvironmentName { get; set; }

        public ICollection<Error> Errors { get; set; }       
    }
}
