using DigitalLibrary.DAL.Entityes.Base;

namespace DigitalLibrary.DAL.Entityes
{
    /// <summary>Сущность книги</summary>
    public class Book : Entity
    {
        /// <summary>Название книги</summary>
        public string Title { get; set; }

        /// <summary> Год выпуска книги</summary>
        public int YearRelease { get; set; }
    }
}
