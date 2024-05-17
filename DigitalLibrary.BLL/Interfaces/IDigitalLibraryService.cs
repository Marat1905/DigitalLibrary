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
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<BookEntity> GetGenreBetweenDates(DateTime startDate, DateTime endDate);


    }
}
