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

            var config =
                new ConfigurationBuilder()
                    .SetBasePath(currentDirectory)
                    .AddJsonFile("config.json")
                    .Build();

            Console.WriteLine(config["Name"]);
        }
    }
}