using DigitalLibrary.BLL.Models;
using DigitalLibrary.DAL.Entityes;

namespace DigitalLibrary.BLL.Extensions
{
    public static class EntityExtension
    {
        public static UserEntity ToUserEntity (this UserModel model)
        {
            UserEntity userEntity = new UserEntity ();
            userEntity.Id = model.Id;
            userEntity.Name = model.Name;
            userEntity.Email = model.Email;

            return userEntity;
        }

        public static BookEntity ToBookEntity (this BookModel model)
        {
            BookEntity bookEntity = new BookEntity ();
            bookEntity.Id = model.Id;
            bookEntity.Author = model.Author;
            bookEntity.Title = model.Title;
            bookEntity.YearRelease = model.YearRelease;
            bookEntity.Genre = model.Genre;

            return bookEntity;
        }

        public static UserModel ToUserModel (this UserModel model)
        {
            return new UserModel (model.Id,model.Name,model.Email);
        }

        public static BookModel ToBookModel (this BookEntity model)
        {
            return new BookModel(model.Id,model.Title,model.YearRelease,model.Author,model.Genre);
        }
    }
}
