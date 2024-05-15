using DigitalLibrary.BLL.Models;

namespace DigitalLibrary.BLL.Interfaces
{
    public interface IDigitalLibraryService
    {

        /// <summary>Добавить новую книгу в библиотеку</summary>
        /// <param name="book">Книга</param>
        /// <returns>Книга</returns>
        public BookModel AddBook(BookModel book);
    }
}
