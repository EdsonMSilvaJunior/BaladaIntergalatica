using Balada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Balada.Infra.Data.Mappings
{
    public class AlienMapping : IEntityTypeConfiguration<Alien>
    {
        public void Configure(EntityTypeBuilder<Alien> builder)
        {
            builder.ToTable("Alien");
            builder.Property(x => x.Name).HasMaxLength(60).IsRequired();
            builder.Property(x => x.DateBirth).IsRequired();
            builder.Property(x => x.Objects).IsRequired();
        }
    }
}
