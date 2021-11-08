using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Name> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new Name
            {
                fname = "Alexander",
                lname = "Gajic"
            });
        }
    }
}
