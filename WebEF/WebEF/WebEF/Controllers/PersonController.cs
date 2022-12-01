using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{age:int}")]
        public IEnumerable<Person> Get([FromRoute] int age)
        {
            return _testContext.Persons.Where(p => p.Age > 50);
        }

        [HttpPut("{id:guid}")]
        public async Task<Person> UpdatePerson([FromRoute] Guid personId, [FromBody] int age)
        {
            var person = await _testContext.Persons
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == personId);
            person.Age = age;
            await _testContext.SaveChangesAsync();

            return person;


        }


        [HttpPost()]
        public async Task<Person> CreatePerson([FromBody] Person person)
        {
            _testContext.Persons.Add(person);

            await _testContext.SaveChangesAsync();

            return person;
        }


        [HttpPost()]
        public async Task<Person> CreatePerson1([FromBody] Person person)
        {
            var transaction = await _testContext.Database.BeginTransactionAsync();                      
            
            _testContext.Persons.Add(person);

            await _testContext.SaveChangesAsync();
            await _testContext.SaveChangesAsync();
            await _testContext.SaveChangesAsync();

            await transaction.CommitAsync();

            return person;
        }


    }
}