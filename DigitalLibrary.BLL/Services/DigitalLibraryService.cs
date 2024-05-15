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

        public UserModel AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public BookModel GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookEntity> GetGenreBetweenDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public BookModel RemoveBook(BookModel book)
        {
            throw new NotImplementedException();
        }

        public UserModel RemoveBook(UserModel user)
        {
            throw new NotImplementedException();
        }

        public BookModel UpdateBook(int id, int yearRelease)
        {
            throw new NotImplementedException();
        }

        public BookModel UpdateBook(BookModel book)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUser(int id, string name)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
