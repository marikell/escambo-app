using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Barter.Infra.Data
{
    public class DbHelper
    {
        public static BarterContext GetUserContext()
        {
            return new BarterContext(GetOptions());
        }

        public static DbContextOptions GetOptions()
        {
            var path = Directory.GetCurrentDirectory();

            var configuration = new ConfigurationBuilder()
                                         .SetBasePath(path)
                                         .AddJsonFile("appsettings.json")
                                         .Build();

            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            dbContextOptionsBuilder.UseSqlServer(configuration.GetConnectionString("BarterConnection"));

            return dbContextOptionsBuilder.Options;

        }

    }
}
