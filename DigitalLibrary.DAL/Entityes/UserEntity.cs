using DigitalLibrary.DAL.Entityes.Base;

namespace DigitalLibrary.DAL.Entityes
{
    /// <summary>Сущность пользователя</summary>
    public  class UserEntity:Entity
    {
        /// <summary>Имя пользователя</summary>
        public string Name { get; set; }

        /// <summary>Электронный адрес</summary>
        public  string Email { get; set; }

        /// <summary>Книги на руках</summary>
        public  List<BookEntity> Books { get; set; }

    }
}
