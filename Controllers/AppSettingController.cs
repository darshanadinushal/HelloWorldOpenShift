using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace HelloWorldOpenShift.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppSettingController : ControllerBase
    {
        private readonly Models.Config _config;
        public AppSettingController(IOptionsMonitor<Models.Config> config)
        {
            _config = config.CurrentValue;
        }


        [HttpGet]
        [Route("GetVolumeConfig")]
        public ActionResult<IEnumerable<string>> GetVolumeConfig()
        {
            var settingArray = new string[] { _config.message, _config.Dbcon, _config.Email ,_config.SMTPPort };

            return settingArray;
        }



        [HttpGet]
        [Route("GetEnvConfig")]
        public ActionResult<string> GetEnvConfig()
        {
            var environmentName = "ENV Variable4 :"+Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            return environmentName.ToString();
        }


    }
}
