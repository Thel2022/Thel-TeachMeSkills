using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
    }
}
