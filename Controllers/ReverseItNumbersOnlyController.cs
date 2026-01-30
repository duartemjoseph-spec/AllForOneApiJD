using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneApiJD.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApiJD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        private readonly ReverseItNumbersOnlyService _service;

        public ReverseItNumbersOnlyController(ReverseItNumbersOnlyService service)
        {
            _service = service;
        }

        [HttpGet("Reverse/{input}")]
        public string Reverse(string input)
        {
            return _service.ReverseNumbersOnly(input);
        }
    }
}