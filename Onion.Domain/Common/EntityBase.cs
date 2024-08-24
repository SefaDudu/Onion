namespace Onion.Domain.Common;

public class EntityBase:IEntityBase
{
    public int Id { get; set; }
    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
    public bool IsActive { get; set; } = false;
}