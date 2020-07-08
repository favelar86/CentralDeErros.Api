using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CentralDeErros.Api.Domain.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<ErrorOccurrence> ErrorOccurrences { get; set; }
    }
}
