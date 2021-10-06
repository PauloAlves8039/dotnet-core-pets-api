using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pets.Domain.Entities;

namespace Pets.Infra.Mapping
{
    public class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pets");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Specie).IsRequired().HasMaxLength(30);

            builder.Property(p => p.Size).IsRequired().HasMaxLength(20);

            builder.Property(p => p.Available);
        }
    }
}
