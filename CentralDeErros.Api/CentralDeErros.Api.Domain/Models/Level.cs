using System;
using System.Collections.Generic;
using System.Text;

namespace CentralDeErros.Api.Domain.Models
{
    public class Level
    {
        public int LevelId { get; set; }

        public string LevelName { get; set; }

        public ICollection<Error> Errors { get; set; }
    }
}
