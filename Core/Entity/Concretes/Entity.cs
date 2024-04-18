using Core.Entity.Interfaces;

namespace Core.Entity.Concretes
{
    public class Entity : IEntity
    {
        public Entity() {

            EntityStatus = EntityStatuses.Active;
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int CreatedById { get; set; }
        public int? DeletedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
        public EntityStatuses EntityStatus { get; set; }

    }

    public enum EntityStatuses
    {
        Active,
        Inactive
    }   
}
