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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _service;
        public OddOrEvenController(OddOrEvenService service)
        {
            _service = service;
        }

        [HttpGet("Check/{number}")]
        public string Check(int number)
        {
            return _service.CheckOddOrEven(number);
        }
    }
}