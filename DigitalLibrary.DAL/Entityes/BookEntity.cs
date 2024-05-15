using DigitalLibrary.DAL.Entityes.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DigitalLibrary.DAL.Entityes
{
    /// <summary>Сущность книги</summary>
    public class BookEntity : Entity
    {
        /// <summary>Название книги</summary>
        public string Title { get; set; }

        /// <summary> Год выпуска книги</summary>
        public int YearRelease { get; set; }

        /// <summary>Автор книги </summary>
        public string? Author { get; set; }

        /// <summary>Жанр</summary>
        public string? Genre { get; set; }

        /// <summary>Список у кого книги</summary>
        public virtual IEnumerable<UserEntity> Users { get; set; }
    }
}
