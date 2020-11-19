using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace November18thAzureAppConfigurationApi
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
             webBuilder.ConfigureAppConfiguration((webHostBuilderContext, config) =>
             {
                 config.SetBasePath(webHostBuilderContext.HostingEnvironment.ContentRootPath)
                    .AddUserSecrets(typeof(Program).Assembly)
                    .AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile($"appsettings.{webHostBuilderContext.HostingEnvironment.EnvironmentName}.json");

                 var intermediate = config.Build();

                 config.AddAzureAppConfiguration(options =>
                 {
                     options.Connect(intermediate["AppConfig"])
                        //.Select(KeyFilter.Any, LabelFilter.Null);
                        .Select(KeyFilter.Any, "Ryan");

                     options.ConfigureRefresh(refresh =>
                     {
                         refresh.Register("refreshKey", refreshAll: true);
                     });
                 });

                 config.Build();
             }).UseStartup<Startup>());
    }
}
