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

            BookModel book1 = new BookModel(1, "Книга 1", 2004, "Иванов И.И.", "Научное");
            BookModel book2 = new BookModel(2, "Книга 2", 2005, "Смирнов И.И.", "Художественное");
            BookModel book3 = new BookModel(3, "Книга 3", 2006, "Иванов И.И.", "Художественное");
            BookModel book4 = new BookModel(4, "Книга 4", 2007, "Пушкин А.С.", "Научное");
            BookModel book5 = new BookModel(5, "Книга 5", 2008, "Лермонтов", "Научное");

            UserModel user1 = new UserModel(1, "Сидоров С.С", "email1@gmail.com");
            UserModel user2 = new UserModel(1, "Антонов С.С", "email2@gmail.com");
            UserModel user3 = new UserModel(1, "Иванов С.С", "email3@gmail.com");
            UserModel user4 = new UserModel(1, "Смирнов С.С", "email4@gmail.com");
            UserModel user5 = new UserModel(1, "Юрин С.С", "email5@gmail.com");

            digitalLibrary.AddBook(book1);
            digitalLibrary.AddBook(book2);
            digitalLibrary.AddBook(book3);
            digitalLibrary.AddBook(book4);
            digitalLibrary.AddBook(book5);


            digitalLibrary.AddUser(user1);
            digitalLibrary.AddUser(user2);
            digitalLibrary.AddUser(user3);
            digitalLibrary.AddUser(user4);
            digitalLibrary.AddUser(user5);

            var Books = digitalLibrary.GetAllBooks().ToList();

            var Users=digitalLibrary.GetAllUsers().ToList();

            var GetBook2 = digitalLibrary.GetBook(2);

            var GetUser3=digitalLibrary.GetUser(3);

            //digitalLibrary.RemoveUser(GetUser3);

            //digitalLibrary.RemoveBook(GetBook2);
            //GetBook2.Title = "Супер Книга";
            //digitalLibrary.UpdateBook(GetBook2);

            //GetUser3.Email = "googler@gmail.com";
            //digitalLibrary.UpdateUser(GetUser3);
            digitalLibrary.UpdateBook(GetBook2.Id, 1990);
            digitalLibrary.UpdateUser(GetUser3.Id, "Петров");

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
