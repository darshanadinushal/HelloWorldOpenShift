using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldOpenShift.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppSettingController : ControllerBase
    {
        private IConfiguration configuration;
        public AppSettingController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        [HttpGet]
        public IActionResult Get()
        {
            string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;

            return Ok(dbConn);
        }
    }
}
