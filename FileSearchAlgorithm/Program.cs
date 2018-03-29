using System;
using System.IO;

namespace FileSearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var rootPath = @"F:\Folder"; // This is the path to root folder
            FindFiles(rootPath);
            Console.ReadLine();
        }

        public static void FindFiles(string rootPath)
        {
            int i = 0;
            foreach (string fileName in Directory.GetFiles(rootPath))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(rootPath))
            {
                FindFiles(directory);
            }
        }
    }
}
