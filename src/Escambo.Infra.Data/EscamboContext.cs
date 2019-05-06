using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;
using Escambo.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Escambo.Infra.Data
{
    public class EscamboContext : DbContext, IDbContext
    {
        private readonly IHostingEnvironment _env;

        public EscamboContext(IHostingEnvironment env, DbContextOptions options) : base(options)
        {
            _env = env;
        }

        public EscamboContext(DbContextOptions options) : base(options)
        {

        }

        public EscamboContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
