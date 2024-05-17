using DigitalLibrary.BLL.Models;
using DigitalLibrary.DAL.Entityes;

namespace DigitalLibrary.BLL.Interfaces
{
    public interface IDigitalLibraryService
    {

        /// <summary>Добавить новую книгу в библиотеку</summary>
        /// <param name="book">Книга</param>
        /// <returns>Книга</returns>
        public BookModel AddBook(BookModel book);

        /// <summary>Выбрать книгу по идентификатору</summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Возвращаем модель книги</returns>
        public BookModel GetBook(int id);

        /// <summary>Метод получения всех книг в библиотеке</summary>
        /// <returns></returns>
        public IEnumerable<BookModel> GetAllBooks();

        /// <summary>Удалить книгу</summary>
        /// <param name="book">Модель книги</param>
        /// <returns></returns>
        public void RemoveBook(BookModel book);

        /// <summary>Обновление года выпуска у книги</summary>
        /// <param name="id">Идентификатор книги</param>
        /// <param name="yearRelease">Обновленный год выпуска книги</param>
        /// <returns></returns>
        public BookModel UpdateBook(int id, int yearRelease);

        /// <summary>Обновление книги</summary>
        /// <param name="book">Модель книги</param>
        /// <returns></returns>
        public BookModel UpdateBook(BookModel book);

        /// <summary>Добавить читателя </summary>
        /// <param name="user">Читатель</param>
        /// <returns></returns>
        public UserModel AddUser(UserModel user);

        /// <summary>Получить читателя</summary>
        /// <param name="id">идентификатор читателя</param>
        /// <returns></returns>
        public UserModel GetUser(int id);

        /// <summary>Получить всех читателей </summary>
        /// <returns></returns>
        public IEnumerable<UserModel> GetAllUsers();

        /// <summary>Удалить читателя</summary>
        /// <param name="user">модель пользователя</param>
        /// <returns></returns>
        public void RemoveUser(UserModel user);

        /// <summary>Обновить имя читателя</summary>
        /// <param name="id">идентификатор читателя</param>
        /// <param name="name">Имя читателя</param>
        /// <returns></returns>
        public UserModel UpdateUser(int id, string name);

        /// <summary>Обновление читателя </summary>
        /// <param name="user">модель читателя</param>
        /// <returns></returns>
        public UserModel UpdateUser(UserModel user);

        /// <summary>Получать список книг определенного жанра и вышедших между определенными годами.</summary>
        /// <param name="startDate">Начальная дата поиска</param>
        /// <param name="endDate">Конечная дата поиска</param>
        /// <param name="genre">Жанр</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<BookModel> GetGenreBooksBetweenDates(int startDate, int endDate, string genre);

        /// <summary>Метод получения количество книг определенного автора </summary>
        /// <param name="autor">Автор</param>
        /// <returns></returns>
        public int GetCountBookCertainAuthor(string autor);

        /// <summary>Метод получения количество книг определенного жанра</summary>
        /// <param name="genre">Жанр</param>
        /// <returns></returns>
        public int GetCountBookGenre(string genre);

        /// <summary>Есть ли книга определенного автора и с определенным названием в библиотеке.</summary>
        /// <param name="autor">Автор книги</param>
        /// <param name="title">Название книги</param>
        /// <returns></returns>
        public bool IsBookCertainAuthor(string autor, string title);

        /// <summary>Получение последней вышедшей книги.</summary>
        /// <returns></returns>
        public BookModel LastBookPublished();

        /// <summary>Получение списка всех книг, отсортированного в алфавитном порядке по названию.</summary>
        /// <returns></returns>
        public IEnumerable<BookModel> AllBooksTitleAsc();

        /// <summary>Получение списка всех книг, отсортированного в порядке убывания года их выхода</summary>
        /// <returns></returns>
        public IEnumerable<BookModel> AllBooksYearReleaseDesc();

        /// <summary>Есть ли книга на руках у пользователя</summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="bookName">Имя книги</param>
        /// <returns></returns>
        public bool IsBookUserInHand(int id,string bookName);

        /// <summary>Получение количества книг на руках у порльзователя</summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetCountUserBooks(int id);

        /// <summary>Добавить читателю книгу</summary>
        /// <param name="user"></param>
        /// <param name="book"></param>
        public void AddUserBook(UserModel user, BookModel book);
    }
}
