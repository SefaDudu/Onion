using Onion.Domain.Common;

namespace Onion.Domain.Entities;

public  class Detail:EntityBase
{
    public required string Title { get; set; } 
    public required string Description { get; set; }

    #region Relation
    public int CategoryId { get; set; }
    public  Category Category { get; set; } 
    #endregion
}