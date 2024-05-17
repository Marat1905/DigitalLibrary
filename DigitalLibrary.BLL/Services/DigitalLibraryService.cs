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

        public IEnumerable<BookModel> GetGenreBooksBetweenDates(int startDate, int endDate, string genre)
        {
            foreach (var item in _bookRepository.Items.Where(item => item.Genre == genre)
                                                     .Where(item => item.YearRelease >= startDate)
                                                     .Where(item => item.YearRelease <= endDate))
            {
                yield return item.ToBookModel();
            }
        }

        public int GetCountBookCertainAuthor(string autor)
        {
           return _bookRepository.Items.Count(item => item.Author == autor);
        }

        public int GetCountBookGenre(string genre)
        {
           return _bookRepository.Items.Count(item=>item.Genre.Contains(genre));
        }

        public bool IsBookCertainAuthor(string autor, string title)
        {
          return _bookRepository.Items.Any(item=>item.Author== autor && item.Title == title);
        }

        public BookModel LastBookPublished()
        {
            return AllBooksYearReleaseDesc().FirstOrDefault();
        }

        public IEnumerable<BookModel> AllBooksTitleAsc()
        {
            foreach (var item in _bookRepository.Items.OrderBy(item => item.Title))
            {
                yield return item.ToBookModel();
            }
        }

        public IEnumerable<BookModel> AllBooksYearReleaseDesc()
        {
            foreach (var item in _bookRepository.Items.OrderByDescending(item => item.YearRelease))
            {
                yield return item.ToBookModel();
            }
        }

        public bool IsBookUserInHand(int id, string bookName)
        {
            return _userRepository.Items.Where(item=>item.Id==id).Any(b=>b.Books.Any(p=>p.Title==bookName));
        }

        public int GetCountUserBooks(int id)
        {
            return _userRepository.Items.FirstOrDefault(p=>p.Id==id)?.Books?.Count ?? 0;
        }

        public void AddUserBook(UserModel user, BookModel book)
        {
           var bookEntity= _bookRepository.Get(book.Id);
           var userEntity= _userRepository.Get(user.Id);
            userEntity.Books.Add(bookEntity);
            _userRepository.Update(userEntity);

        }
    }
}
