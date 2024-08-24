using Onion.Domain.Common;

namespace Onion.Domain.Entities;

public class Category : EntityBase
{
    public required int ParentId { get; set; } 
    public required string Name { get; set; }
    public required int  Priority { get; set; } 
    public  ICollection<Detail>? Details{ get; set; } 
    
    public  required ICollection<Product> Products{ get; set; } //çoka çok ilişki

}