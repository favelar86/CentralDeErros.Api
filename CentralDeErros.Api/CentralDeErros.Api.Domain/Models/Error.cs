using System;
using System.Collections.Generic;
using System.Text;

namespace CentralDeErros.Api.Domain.Models
{
    public class Error
    {
        public int ErrorId { get; set; }

        public int Code { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int EnvironmentId { get; set; }

        public int LevelId { get; set; }
    }
}
