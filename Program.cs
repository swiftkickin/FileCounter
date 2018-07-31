using System;

namespace FileCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var totalFiles = GetFileCount(currentDirectory);

            Console.WriteLine($"The directory {currentDirectory} contains {totalFiles} files.");
        }

        private static long GetFileCount(string currentDirectory)
        {
            var fileCount = System.IO.Directory.GetFiles(currentDirectory).LongLength;
            var directories = System.IO.Directory.GetDirectories(currentDirectory);

            foreach(var directory in directories){
                fileCount += GetFileCount(directory);
            }
            return fileCount;
        }
    }
}
