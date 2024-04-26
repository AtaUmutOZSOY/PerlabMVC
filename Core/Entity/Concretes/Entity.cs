using Core.Entity.Interfaces;

namespace Core.Entity.Concretes
{
    public class Entity : IEntity
    {
        public Entity() {

            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }

    }

    
}
