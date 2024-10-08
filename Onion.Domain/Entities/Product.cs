﻿using Onion.Domain.Common;

namespace Onion.Domain.Entities;

public class Product:EntityBase 
{
    public required string Title { get; set; } 
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public int BrandId { get; set; }
    public  Brand Brand { get; set; }
    
    public   ICollection<Category> Categories{ get; set; }  //çoka çok ilişki
}