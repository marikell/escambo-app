using Barter.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Barter.Infra.Data
{
    public class BarterContext : DbContext
    {
        public DbSet<Domain.Entities.Barter> Barters { get; set; }

        public BarterContext()
        {

        }
        public BarterContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new BarterMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BarterConnection"));
        }
    }
}
