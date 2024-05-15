namespace DigitalLibrary.BLL.Models
{
    public class BookModel
    {
        /// <summary>Идентификатор</summary>
        public int Id { get; set; }

        /// <summary>Название книги</summary>
        public string Title { get; set; }

        /// <summary> Год выпуска книги</summary>
        public int YearRelease { get; set; }

        /// <summary>Автор книги </summary>
        public string? Author { get; set; }

        /// <summary>Жанр</summary>
        public string? Genre { get; set; }

        /// <summary>Список у кого книги</summary>
        public virtual IEnumerable<UserModel>? Users { get; set; }

        public BookModel(int id,string title,int yearRelease,string? author, string? genre)
        {
            Id = id;
            Title = title;
            YearRelease = yearRelease;
            Author = author;
            Genre = genre;
        }
    }
}
