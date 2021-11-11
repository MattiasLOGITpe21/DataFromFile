using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favourite color?:");
            string favColour = Console.ReadLine();

            string output = GetLineFromfileData(favColour);

            if(output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, color couldn't be found");
            }

        }



        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\users\opilane\samples";
            string fileName = "personality.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);

            return dataFromFile;
        }

        private static string GetLineFromfileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";




            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }

            }
            return result;
        }
    }
}