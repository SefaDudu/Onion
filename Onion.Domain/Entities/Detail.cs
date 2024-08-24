using Onion.Domain.Common;

namespace Onion.Domain.Entities;

public  class Detail(string title,string description,int categoryId):EntityBase
{
    public required string Title { get; set; } = title;
    public required string Description { get; set; } = description;

    #region Relation
    public int CategoryId { get; set; } = categoryId;
    public required Category Category { get; set; } 
    #endregion
}