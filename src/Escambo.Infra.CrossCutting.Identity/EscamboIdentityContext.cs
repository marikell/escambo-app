using Escambo.Infra.CrossCutting.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Escambo.Infra.CrossCutting.Identity.Mappings;

namespace Escambo.Infra.CrossCutting.Identity
{
    public class EscamboIdentityContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHostingEnvironment _env;

        public EscamboIdentityContext(
                    DbContextOptions<EscamboIdentityContext> options,
                    IHostingEnvironment env) : base(options)
        {
            _env = env;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(_env.ContentRootPath)
                                                          .AddJsonFile("appsettings.json", false, true)
                                                          .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserMap());

            base.OnModelCreating(builder);
        }
    }
}
