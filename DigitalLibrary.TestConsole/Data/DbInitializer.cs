using DigitalLibrary.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DigitalLibrary.TestConsole.Data
{
    public class DbInitializer
    {
        private readonly ApplicationContext _db;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(ApplicationContext db, ILogger<DbInitializer> Logger)
        {

            _db = db;
            _logger = Logger;
        }
        public async Task InitializeAsync()
        {
            var timer = Stopwatch.StartNew();
            _logger.LogInformation("Удаление существующей БД...");
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            _logger.LogInformation("Удаление существующей БД выполнено за {0} мс", timer.ElapsedMilliseconds);

           
            _logger.LogInformation("Миграция БД...");
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            _logger.LogInformation("Миграция БД выполнена за {0} мс", timer.ElapsedMilliseconds);



            _logger.LogInformation("Инициализация БД выполнена за {0} с", timer.Elapsed.TotalSeconds);

        }
    }
}
