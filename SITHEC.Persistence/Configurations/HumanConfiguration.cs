using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SITHEC.Domain;

namespace SITHEC.Persistence.Configurations
{
    public class HumanConfiguration : IEntityTypeConfiguration<Human>
    {
        public void Configure(EntityTypeBuilder<Human> builder)
        {

            builder.Property(p => p.Id)
                  .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .HasMaxLength(35)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasMaxLength(35)
                .IsRequired();

            builder.Property(p => p.Age)
                .IsRequired();

            builder.Property(p => p.Size)
                .IsRequired();

            builder.Property(p => p.Weight)
                .HasPrecision(10, 2)
                .IsRequired();
        }
    }
}
