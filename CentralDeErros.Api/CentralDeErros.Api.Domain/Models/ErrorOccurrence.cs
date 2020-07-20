using CentralDeErros.Api.Domain.Repository;
using System;

namespace CentralDeErros.Api.Domain.Models
{
    public class ErrorOccurrence : IEntity
    {
        public int Id { get; set; }

        public string Origin { get; set; }

        public string Details { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }

        public Users User { get; set; }

        public int ErrorId { get; set; }

        public Error Error { get; set; }
    }
}
