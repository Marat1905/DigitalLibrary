using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories;
using Microsoft.Extensions.Configuration;

namespace DigitalLibrary.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();


            var db = new ApplicationContext(GetConnectionString(config.GetSection("Database")))

            BookRepository bookRepository = new BookRepository(db);

            Book book1= new Book { Title="Война и Мир", YearRelease=1900 };
            bookRepository.Add(book1);
           var t= bookRepository.Items.ToList();

        }

       private  static string GetConnectionString(IConfiguration Configuration)
        {
            var type = Configuration["Type"];
            switch (type)
            {
                case null: throw new InvalidOperationException("Не определён тип БД");

                default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
                case "MSSQL":
                    return Configuration.GetConnectionString(type);

                case "SQLite":
                    return Configuration.GetConnectionString(type);

            };
        }

    }
}
