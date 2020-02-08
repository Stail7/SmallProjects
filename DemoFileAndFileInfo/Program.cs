using System;
using System.IO;

namespace DemoFileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // File class
            var currentDir = Directory.GetCurrentDirectory();
            var filePath = currentDir + @"\TextDoc.txt";
            var newFilePath = currentDir + @"\newTextDoc.txt";
            File.Copy(filePath, newFilePath, true);
            File.Delete(newFilePath);
            if (File.Exists(filePath))
            {
                Console.WriteLine("Creation time is: " + File.GetCreationTime(filePath));
                var content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }

            // FileInfo class
            var fileInfo = new FileInfo(filePath);
            fileInfo.CopyTo(newFilePath, true);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
                Console.WriteLine("Copy of source file deleted.");
            }
        }
    }
}
