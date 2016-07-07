using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Poc.AspnetCore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return new[] { 1, 2, 4, 5 };
        }
    }
}