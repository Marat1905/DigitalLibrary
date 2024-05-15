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

        /// <summary>Получать список книг определенного жанра и вышедших между определенными годами.</summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<BookEntity> GetGenreBetweenDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        /// <summary>Метод получения количество книг определенного автора </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GrtCountCertainAuthor()
        {
            throw new NotImplementedException();
        }

        /// <summary>Есть ли книга определенного автора и с определенным названием в библиотеке.</summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsBookCertainAuthor()
        {
            throw new NotImplementedException();
        }

        /// <summary>Получение последней вышедшей книги.</summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public BookEntity LastBookPublished()
        {
            throw new NotImplementedException();
        }

        /// <summary>Получение списка всех книг, отсортированного в алфавитном порядке по названию.</summary>
        /// <returns></returns>
        public IEnumerable<BookEntity> AllBooksTitleAsc() => Items.OrderBy(item => item.Title);

        /// <summary>Получение списка всех книг, отсортированного в порядке убывания года их выхода</summary>
        /// <returns></returns>
        public IEnumerable<BookEntity> AllBooksYearReleaseDesc() => Items.OrderByDescending(item => item.YearRelease);
    }
}
