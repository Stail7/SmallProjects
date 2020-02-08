using System;
using System.IO;

namespace DemoPathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var filePath = currentDir + @"\TextDoc.txt";
            Console.WriteLine(filePath);

            Console.WriteLine("Get extension: " + Path.GetExtension(filePath));
            Console.WriteLine("File name: " + Path.GetFileName(filePath));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(filePath));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(filePath));
        }
    }
}
