namespace Core.Entity.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime? CreatedTime { get; set; }
        DateTime? UpdatedTime { get; set; }
        DateTime? DeletedTime { get; set; }
    }
}
