using System;
using System.IO;

namespace Chuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\users\opilane\samples";
            string fileName = "chuck.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile[rnd.Next(dataFromFile.Length)]);
        }
    }
}
