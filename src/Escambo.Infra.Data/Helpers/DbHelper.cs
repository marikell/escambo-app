using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.IO;

namespace Escambo.Infra.Data.Helpers
{
    public class DbHelper
    {

        public static EscamboContext GetEscamboContext()
        {
            var path = Directory.GetCurrentDirectory();

            var configuration = new ConfigurationBuilder()
                                            .SetBasePath(path)
                                            .AddJsonFile("appsettings.json")
                                            .Build();

            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            dbContextOptionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new EscamboContext(dbContextOptionsBuilder.Options);
        }

    }
}
