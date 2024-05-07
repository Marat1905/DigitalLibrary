using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories;
using DigitalLibrary.TestConsole.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DigitalLibrary.TestConsole
{
    internal class Program
    {
        private static IHost __Host;
        static async Task Main(string[] args)
        {;

            IHost Host = __Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();


            IServiceProvider Services = Host.Services;

            using (var scope = Services.CreateScope())
            {
                await scope.ServiceProvider.GetRequiredService<DbInitializer>().InitializeAsync();
            }



        }



        static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
               .AddDatabase(host.Configuration.GetSection("Database"))        
      ;

        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureServices(ConfigureServices)
               .ConfigureLogging(builder =>
               {
                   builder.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.None);
               })
            ;


    }
}
