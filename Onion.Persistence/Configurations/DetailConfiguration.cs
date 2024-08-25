using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations;

public class DetailConfiguration : IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
        Faker faker = new("tr");
        Detail detail1 = new()
        {
            Description = faker.Lorem.Sentence(5),
            Title = faker.Lorem.Sentence(1),
            Id = 1,
            CategoryId = 1
        };
        Detail detail2 = new()
        {
            Description = faker.Lorem.Sentence(5),
            Title = faker.Lorem.Sentence(1),
            Id = 2,
            CategoryId =3
        };
        Detail detail3 = new()
        {
            Description = faker.Lorem.Sentence(5),
            Title = faker.Lorem.Sentence(1),
            Id = 3,
            CategoryId =4
        };
        builder.HasData(detail1, detail2, detail3);
    }
}