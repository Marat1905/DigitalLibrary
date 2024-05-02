using DigitalLibrary.DAL.Configurations;
using DigitalLibrary.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace DigitalLibrary.DAL.Context
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connection;
        //public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        //{
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //}

        public ApplicationContext(string connection)
        {
            _connection = connection;
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
