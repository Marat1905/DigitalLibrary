using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories.Base;

namespace DigitalLibrary.DAL.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(ApplicationContext db) : base(db) { }
    }
}
