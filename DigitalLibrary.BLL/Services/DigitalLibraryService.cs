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
            _userRepository.Add(user.ToUserEntity());
            return user;
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            foreach (var item in _bookRepository.Items)
                yield return item.ToBookModel();
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            foreach (var item in _userRepository.Items)
                yield return item.ToUserModel();
        }

        public BookModel GetBook(int id)
        {
           return _bookRepository.Get(id).ToBookModel();
        }

        public IEnumerable<BookEntity> GetGenreBetweenDates(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(int id)
        {
            return _userRepository.Get(id).ToUserModel();
        }

        public void RemoveBook(BookModel book)
        {
            _bookRepository.Remove(book.Id);
        }

        public void RemoveUser(UserModel user)
        {
           _userRepository.Remove(user.Id);
        }

        public BookModel UpdateBook(int id, int yearRelease)
        {
            var book = _bookRepository.Get(id);
            if (book != null)
            {
                book.YearRelease = yearRelease;
                _bookRepository.Update(book);
                return book.ToBookModel();
            }
            else
                return null;
        }

        public BookModel UpdateBook(BookModel book)
        {
            var bookEntity = _bookRepository.Get(book.Id);
            if (bookEntity != null)
            {
                bookEntity.Author = book.Author;
                bookEntity.Title = book.Title;
                bookEntity.YearRelease = book.YearRelease;
                _bookRepository.Update(bookEntity);
            }
            return book;
        }

        public UserModel UpdateUser(int id, string name)
        {
           var user= _userRepository.Get(id);
            if (user != null)
            {
                user.Name = name;
                _userRepository.Update(user);
                return user.ToUserModel();
            }
            else
                return null;
        }

        public UserModel UpdateUser(UserModel user)
        {
           var userEntity=_userRepository.Get(user.Id);
            if(userEntity != null)
            {
                userEntity.Name = user.Name;
                userEntity.Email = user.Email;
                _userRepository.Update(userEntity);
            }
            return user;
        }
    }
}
