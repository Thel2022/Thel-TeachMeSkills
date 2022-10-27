using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHomeService _homeService;
        private readonly IConfiguration _config;

        public ValuesController(IHomeService homeService)
        {
            _homeService = homeService;

        }

        [HttpGet("say")] ///api/say
        public string Say()
        {
            return _homeService.SaySomething();

        }

        [HttpGet("secret-key")]
        public string GetKey()
        {
            return _config.GetValue<string>("SecretKey");
        }

        [HttpGet("secret-key1")]
        public IActionResult GetKey1()
        {
            return Ok(_config.GetValue<string>("SecretKey"));
        }

        [HttpPost("some-data")]
        public void SomeData([FromBody] BasicData data)
        {

        }

        public class BasicData
        {
            public int Number { get; set; }
            public string Text { get; set; }
        }

        public class BasicData1
        {
            [Range(0, 10)]
            public int Number { get; set; }
            [MaxLength(100)]
            public string Text { get; set; }
        }

        [HttpGet("guid")]
        public IActionResult GetGuid()
        {
            Guid g = Guid.NewGuid();
            return Ok();
        }
    }
}
