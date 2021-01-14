using Balada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;

namespace Balada.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Alien> Aliens { get; set; }
        public DbSet<Estabelecimento> Baladas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    
                    .UseSqlServer("BaladaConnectionString");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var splitStringConverter = new ValueConverter<IList<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            builder.Entity<Alien>().Property(nameof(Alien.Objects)).HasConversion(splitStringConverter);
            builder.Entity<Estabelecimento>().Property(nameof(Estabelecimento.RestrictedObjects)).HasConversion(splitStringConverter);
            builder.Entity<Estabelecimento>().Property(nameof(Estabelecimento.BannedList)).HasConversion(splitStringConverter);

        }

    }
}

