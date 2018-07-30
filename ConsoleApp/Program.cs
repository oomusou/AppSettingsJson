using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    static class Program
    {
        private static void Main()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var configuration =
                new ConfigurationBuilder()
                    .SetBasePath(currentDirectory)
                    .AddJsonFile("config.json", true, true)
                    .Build();

            Console.WriteLine(configuration["Name"]);
        }
    }
}