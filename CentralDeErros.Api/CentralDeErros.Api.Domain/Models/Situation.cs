using CentralDeErros.Api.Domain.Repository;
using System.Collections.Generic;

namespace CentralDeErros.Api.Domain.Models
{
    public class Situation : IEntity
    {
        public int SituationId { get; set; }

        public string SituationName { get; set; }

        public ICollection<ErrorOccurrence> ErrorOccurrences { get; set; }

        public int Id { get; set; }
    }
}
