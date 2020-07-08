using System;
using System.Collections.Generic;
using System.Text;

namespace CentralDeErros.Api.Domain.Models
{
    public class ErrorOccurrence
    {
        public int ErrorOccurrenceId { get; set; }

        public string Origin { get; set; }

        public string Details { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }

        public int ErrorId { get; set; }

        public int SituationId { get; set; }
    }
}
