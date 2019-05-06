using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace User.Infra.Data
{
    public class DbHelper
    {
        public static UserContext GetUserContext()
        {
            return new UserContext(GetOptions());
        }

        public static DbContextOptions GetOptions()
        {
            var path = Directory.GetCurrentDirectory();

            var configuration = new ConfigurationBuilder()
                                         .SetBasePath(path)
                                         .AddJsonFile("appsettings.json")
                                         .Build();

            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            dbContextOptionsBuilder.UseSqlServer(configuration.GetConnectionString("UserConnection"));

            return dbContextOptionsBuilder.Options;

        }

    }
}
