using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Escambo.Services.Api.Helpers
{
    public class ApiHelper
    {
        private static IConfigurationRoot _root;

        private static void Setup()
        {
            if(_root != null) { return; }

            _root = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                              .AddJsonFile("appsettings.json")
                                              .Build();
        }
        public static string GetUserApi()
        {
            Setup();
            return Convert.ToString(_root.GetValue<string>("USER_API"));
        }

        public static string GetBarterApi()
        {
            Setup();
            return Convert.ToString(_root.GetValue<string>("BARTER_API"));
        }
    }
}
