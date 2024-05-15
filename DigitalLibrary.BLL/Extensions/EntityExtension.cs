using DigitalLibrary.BLL.Models;
using DigitalLibrary.DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

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
    }
}
