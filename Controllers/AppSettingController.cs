using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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
        public ActionResult<IEnumerable<string>> Get()
        {
            var settingArray = new string[] { _config.message, _config.Dbcon, _config.Email ,_config.SMTPPort };

            return settingArray;
        }
    }
}
