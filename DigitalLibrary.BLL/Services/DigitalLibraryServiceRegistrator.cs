using DigitalLibrary.BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalLibrary.BLL.Services
{
    public static class DigitalLibraryServiceRegistrator
    {
        public static IServiceCollection AddCarDriverService(this IServiceCollection services) => services
        .AddTransient<IDigitalLibraryService, DigitalLibraryService>()
         ;
    }
}
