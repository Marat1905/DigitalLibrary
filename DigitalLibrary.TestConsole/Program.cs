using DigitalLibrary.TestConsole.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DigitalLibrary.BLL.Services;
using DigitalLibrary.DAL.Interfaces;
using DigitalLibrary.BLL.Interfaces;
using DigitalLibrary.BLL.Models;

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

          

            IDigitalLibraryService digitalLibrary =Services.CreateScope().ServiceProvider.GetService<IDigitalLibraryService>();

            BookModel book1 = new BookModel(1, "Книга 1", 2004, "Иванов И.И.", "Драма");

            digitalLibrary.AddBook(book1);

        }



        static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddDatabase(host.Configuration.GetSection("Database"))
            .AddCarDriverService()
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
