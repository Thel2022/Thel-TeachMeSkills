using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebEF.Models;

namespace WebEF.Controllers
{
    [ApiController]
    [Route("Person")]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PersonController> _logger;
        private readonly TestContext _testContext;

        public PersonController(ILogger<PersonController> logger, TestContext testContext)
        {
            _logger = logger;
            _testContext = testContext;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _testContext.Persons.ToList();
        }
    }
}