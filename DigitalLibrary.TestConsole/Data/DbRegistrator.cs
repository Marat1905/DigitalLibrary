using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalLibrary.TestConsole.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
           .AddDbContext<ApplicationContext>(opt =>
           {
               var type = Configuration["Type"];
               switch (type)
               {
                   case null: throw new InvalidOperationException("Не определён тип БД");
                   default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");

                   case "MSSQL":
                       opt.UseSqlServer(Configuration.GetConnectionString(type));
                       break;
                   case "SQLite":
                       throw new InvalidOperationException("Не реализован");
               };
               opt.EnableSensitiveDataLogging(false);
           })
           .AddTransient<DbInitializer>()
           .AddRepositoriesInDB()
          
        ;
    }
}
