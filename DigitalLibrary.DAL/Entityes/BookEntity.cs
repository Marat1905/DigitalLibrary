using DigitalLibrary.DAL.Entityes.Base;

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
        public  List<UserEntity> Users { get; set; }
    }
}
