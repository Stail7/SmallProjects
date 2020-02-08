using System;
using System.IO;

namespace DemoDirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Directory (has only static methods)
            var currentDir = Directory.GetCurrentDirectory();
            var dirPath = currentDir + @"\TestDir";

            if (Directory.Exists(dirPath))
                Directory.Delete(dirPath, true);

            Directory.CreateDirectory(dirPath);
            File.Create(dirPath + @"\TestDoc.txt");

            // Returns full path and file name
            var files = Directory.GetFiles(dirPath, "*.*", 
                SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(currentDir, "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            //// DirectoryInfo
            var directoryInfo = new DirectoryInfo(dirPath);

            // Returns only file name (not a full path)
            var filesDirInfo = directoryInfo.GetFiles("*.*", 
                SearchOption.AllDirectories);
            foreach (var file in filesDirInfo)
                Console.WriteLine(file);
        }
    }
}
