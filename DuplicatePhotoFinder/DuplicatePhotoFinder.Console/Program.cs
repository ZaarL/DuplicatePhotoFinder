using System;
using System.Configuration;

namespace DuplicatePhotoFinder.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = ConfigurationManager.AppSettings.Get("Path");
            System.Console.WriteLine("Hello World!");
            System.Console.Read();
        }
    }
}
