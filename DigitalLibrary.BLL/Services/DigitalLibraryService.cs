using DigitalLibrary.BLL.Extensions;
using DigitalLibrary.BLL.Interfaces;
using DigitalLibrary.BLL.Models;
using DigitalLibrary.DAL.Entityes;
using DigitalLibrary.DAL.Interfaces;

namespace DigitalLibrary.BLL.Services
{
    public class DigitalLibraryService:IDigitalLibraryService
    {
        private readonly IRepository<BookEntity> _bookRepository;
        private readonly IRepository<UserEntity> _userRepository;


        public DigitalLibraryService(IRepository<BookEntity> bookRepository,IRepository<UserEntity> userRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
        }

        public BookModel AddBook(BookModel book)
        {
            _bookRepository.Add(book.ToBookEntity());
            return book;
        }
    }
}
