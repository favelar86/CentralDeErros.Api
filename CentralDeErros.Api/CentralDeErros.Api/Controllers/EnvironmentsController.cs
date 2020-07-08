using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CentralDeErros.Api.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CentralDeErros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentsController : ControllerBase
    {
        List<Environment> lst;

        public EnvironmentsController()
        {
            lst = new List<Environment>();
            lst.Add(new Environment() { EnvironmentId = 1, EnvironmentName = "Produção" });
            lst.Add(new Environment() { EnvironmentId = 2, EnvironmentName = "Homologação" });
            lst.Add(new Environment() { EnvironmentId = 3, EnvironmentName = "Dev" });
        }

        // GET: api/<EnvironmentsController>
        [HttpGet]
        public IEnumerable<Environment> Get()
        {
            return lst;
        }

        // GET api/<EnvironmentsController>/5
        [HttpGet("{id}")]
        public Environment Get(int id)
        {
            return lst.FirstOrDefault(x => x.EnvironmentId == id);
        }

        // POST api/<EnvironmentsController>
        [HttpPost]
        public IEnumerable<Environment> Post([FromBody] Environment environment)
        {
            lst.Add(environment);
            return lst;
        }

        // PUT api/<EnvironmentsController>/5
        [HttpPut("{id}")]
        public IEnumerable<Environment> Put(int id, [FromBody] Environment name)
        {
            int index = lst.FindIndex(x => x.EnvironmentId == id);
            if (index > -1)
            {
                lst[index].EnvironmentName = name.EnvironmentName;
            }

            return lst;
        }

        // DELETE api/<EnvironmentsController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Environment> Delete(int environmentid)
        {
            var environment = lst.FirstOrDefault(x => x.EnvironmentId == environmentid);
            if (environment != null) lst.Remove(environment);

            return lst;
        }
    }
}
