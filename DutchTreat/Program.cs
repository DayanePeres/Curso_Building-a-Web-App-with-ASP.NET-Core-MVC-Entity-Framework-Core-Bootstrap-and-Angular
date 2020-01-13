using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DutchTreat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Primeira linha a ser executada  
            //CreateHostBuilder(args).Build().Run();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>//IHostBuilder CreateHostBuilder(string[] args) =>
                                                             //Host.CreateDefaultBuilder(args)
                                                             //    .ConfigureWebHostDefaults(webBuilder =>
                                                             //    {
                                                             //        webBuilder.UseStartup<Startup>();
                                                             //    });

        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}
