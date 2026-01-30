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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersService _service;
        public AddingTwoNumbersController(AddingTwoNumbersService service)
        {
            _service = service;
        }
        [HttpGet("Add/{num1}/{num2}")]
        public int Add(int num1, int num2)
        {
            return _service.Add(num1, num2);
        }
    }
}