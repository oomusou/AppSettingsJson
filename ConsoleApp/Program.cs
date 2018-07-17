using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var configuration =
                new ConfigurationBuilder()
                    .SetBasePath(currentDirectory)
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

            Console.WriteLine(configuration["Name"]);
        }
    }
}