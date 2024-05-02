using DigitalLibrary.DAL.Context;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Repositories.Base;

namespace DigitalLibrary.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(ApplicationContext db) : base(db) { }
    }
}
