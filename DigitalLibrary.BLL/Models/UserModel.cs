namespace DigitalLibrary.BLL.Models
{
    public class UserModel
    {
        /// <summary>Идентификатор</summary>
        public int Id { get; set; }

        /// <summary>Имя пользователя</summary>
        public string Name { get; set; }

        /// <summary>Электронный адрес</summary>
        public string Email { get; set; }

        /// <summary>Книги на руках</summary>
        public virtual IEnumerable<BookModel> Books { get; set; }

        public UserModel(int id , string name , string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
