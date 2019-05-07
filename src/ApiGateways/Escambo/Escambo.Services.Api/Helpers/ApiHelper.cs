using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Escambo.Services.Api.Helpers
{
    public class ApiHelper
    {
        public static string GetUserApi()
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();
            return Convert.ToString(configuration.GetValue<string>("USER_API"));
        }
    }
}
