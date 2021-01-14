using Balada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Balada.Infra.Data.Mappings
{
    public class EstabelecimentoMapping : IEntityTypeConfiguration<Estabelecimento>
    {
        
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder.ToTable("Balada");
            builder.Property(x => x.Name).HasMaxLength(60).IsRequired();
            builder.Property(x => x.RestrictedObjects).IsRequired();
        }
    }
}

