using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("table/get")]
    public class JSController : ControllerBase
    {
        
        private readonly ILogger<JSController> _logger;

        public JSController(ILogger<JSController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var table = new JSTable();
            JSPerson person = table.Json();
            
            return $"Name: {person.Name}";
        }
    }
}
