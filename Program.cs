using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_WEB.Controllers//WebApplication3
{
    [ApiController]
    [Route("api")]
    public class PersonsController : ControllerBase
    {
        [HttpGet("persons /{id})")]
        public ActionResult<PersonModel> GetById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet("persons/search")]
        public Task<IEnumerable<PersonModel>> FinaBuName([FromQuery] string SearchName,
            [FromQuery] int skip = 1,
            [FromQuery] int take = 50)
        {
            return (Task<IEnumerable<PersonModel>>)(IEnumerable<PersonModel>)Ok();
        }

        [HttpGet("persons/search/all")]
        public async Task<IEnumerable<PersonModel>> FindAll([FromQuery] int skip = 1, [FromQuery] int take = 50)
        {
            return (Task<IEnumerable<PersonModel>>)(IEnumerable<PersonModel>)Ok();
        }

        [HttpPost("persons/add")]
        public async Task<ActionResult<PersonModel>> AddAsync([FromBody] PersonModel person)
        {
            return Ok();
        }

        [HttpPut("persons/update")]
        public async Task<IActionResult> UpdateAsync([FromBody] PersonModel person)
        {
            return Ok();
        }

        [HttpDelete("persons/delete")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            return Ok();
        }
    }
}

