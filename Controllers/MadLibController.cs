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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _service;
        public MadLibController(MadLibService service)
        {
            _service = service;
        }
        [HttpGet("Create/{name}/{color}/{noun}/{adjective}")]
        public string Create(string name, string color, string noun, string adjective)
        {
            return _service.MadlibChoices(name, color, noun, adjective);
        }
    }
}