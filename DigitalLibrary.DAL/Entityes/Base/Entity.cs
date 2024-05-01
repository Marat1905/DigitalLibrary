using DigitalLibrary.DAL.Interfaces;

namespace DigitalLibrary.DAL.Entityes.Base
{
    public abstract class Entity: IEntity
    {
        public int Id { get; set; }
    }
}
