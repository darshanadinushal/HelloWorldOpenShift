using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldOpenShift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostingContext, conf) =>
                    {
                        conf.Sources.Clear();

                        var env = hostingContext.HostingEnvironment;

                        conf.AddJsonFile($"conf/config.{env.EnvironmentName}.json",optional: true, reloadOnChange: true);
                        conf.AddJsonFile("appsettings.json", optional: true);
                        conf.AddEnvironmentVariables();
                    }).UseStartup<Startup>();
                });
    }
}
