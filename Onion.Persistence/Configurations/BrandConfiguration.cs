using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations;

public class BrandConfiguration:IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
       builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
       Faker faker = new("tr"); // Bogus fake dummyDate

       Brand brand1= new()
       {
           Id = 1,
           Name = faker.Commerce.Department(),
       };
       Brand brand2= new()
       {
           Id =2,
           Name = faker.Commerce.Department(),
       };
       Brand brand3= new()
       {
           Id =3,
           Name = faker.Commerce.Department(),
       };
       builder.HasData(brand1, brand2, brand3);
    }
}