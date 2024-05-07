using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Interfaces;
using DigitalLibrary.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalLibrary.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
             .AddTransient<IRepository<Book>, BookRepository>()
             .AddTransient<IRepository<User>, UserRepository>()
            ;

    }
}
