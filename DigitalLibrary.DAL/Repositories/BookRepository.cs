using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DigitalLibrary.DAL.Repositories
{
    public class BookRepository : BaseRepository<BookEntity>
    {
        public override IQueryable<BookEntity> Items => base.Items.Include(item => item.Users);


        public BookRepository(ApplicationContext db) : base(db) { }
 

       
    }
}
