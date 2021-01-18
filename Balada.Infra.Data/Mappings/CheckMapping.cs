using Balada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Balada.Infra.Data.Mappings
{
    public class CheckMapping : IEntityTypeConfiguration<Check>
    {
        public void Configure(EntityTypeBuilder<Check> builder)
        {
            builder.ToTable("Check");
            builder.HasOne(x => x.Alien)
                .WithMany()
                .HasForeignKey(x => x.AlienId);

            builder.HasOne(x => x.Estabelecimento)
                .WithMany()
                .HasForeignKey(x => x.EstabelecimentoId);
        }
    }
}
