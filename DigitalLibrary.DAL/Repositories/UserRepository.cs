using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DigitalLibrary.DAL.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>
    {
        public override IQueryable<UserEntity> Items => base.Items.Include(item => item.Books);

        public UserRepository(ApplicationContext db) : base(db) { }
    }
}
