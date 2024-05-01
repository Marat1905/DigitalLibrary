using DigitalLibrary.DAL.Entityes.Base;

namespace DigitalLibrary.DAL.Entityes
{
    /// <summary>Сущность пользователя</summary>
    public  class User:Entity
    {
        /// <summary>Имя пользователя</summary>
        public required string Name { get; set; }

        /// <summary>Электронный адрес</summary>
        public required string Email { get; set; }

    }
}
