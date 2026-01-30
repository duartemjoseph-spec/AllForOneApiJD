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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _service;
        public AskingQuestionsController(AskingQuestionsService service)
        {
            _service = service;
        }

        [HttpGet("Ask/{name}/{wakeUpTime}")]
        public string Ask(string name, string wakeUpTime)
        {
            return _service.AskQuestion(name, wakeUpTime);
        }
    }
}