using CentralDeErros.Api.Domain.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CentralDeErros.Api.Domain.Models
{
    public class Users : IEntity
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<ErrorOccurrence> ErrorOccurrences { get; set; }

        public int Id { get; set; }
    }
}
