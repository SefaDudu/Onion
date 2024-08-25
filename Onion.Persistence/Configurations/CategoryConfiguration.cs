using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
        Category category1 = new()
        {
            Id = 1,
            Name = "Elektrik",
            Priority = 1,
            ParentId = 0,
        };
        Category category2 = new()
        {
            Id = 2,
            Name = "Moda",
            Priority = 2,
            ParentId = 0,
        };
        Category parent1 = new()
        {
            Id =3,
            Name = "Bilgisayar",
            Priority = 1,
            ParentId = 1,
            IsActive = false,
        };
        Category parent2 = new()
        {
            Id =4,
            Name = "Kadın",
            Priority = 1,
            ParentId = 2,
            IsActive = false,
        };
        
        builder.HasData(category1, category2, parent1, parent2);
    }
}