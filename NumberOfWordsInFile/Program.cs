using System;
using System.Collections.Generic;
using System.IO;

namespace NumberOfWordsInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file .txt path or hit 'ENTER' to run test file: ");
            var filePath = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = Directory.GetCurrentDirectory() + @"\TextFile.txt";
                Console.WriteLine("No path provided - default test file was created here: \n" + filePath + "\n");
            }
            if (!File.Exists(filePath))
                File.AppendAllText(filePath, "This is a text you have created. " +
                                             "\nSo, what are you going to do next? " +
                                             "\nDo you want to count the number of words that I have? " +
                                             "\n\nLorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                                             "\nAenean commodo ligula eget dolor. Aenean massa. " +
                                             "\nCum sociis natoque penatibus et magnis dis parturient montes, " +
                                             "\nnascetur ridiculus mus. Donec quam felis, ultricies nec, " +
                                             "\npellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. " +
                                             "\nDonec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. " +
                                             "\nIn enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. " +
                                             "\nNullam dictum felis eu pede mollis pretium. Integer tincidunt. " +
                                             "\nCras dapibus. Vivamus elementum semper nisi.");

            Console.WriteLine("File has {0} words.", WordsCount(filePath));
            Console.WriteLine("The longest words are: ");
            foreach (var word in LongestWords(filePath))
                Console.WriteLine(word);
        }

        public static int WordsCount(string filePath)
        {
            var text = File.ReadAllText(filePath);
            var words = text.Split(' ');

            var wordsList = new List<string>();
            foreach (var word in words) 
                wordsList.Add(word.Trim());
            wordsList.TrimExcess();

            return wordsList.Count;
        }

        public static List<string> LongestWords(string filePath)
        {
            var inputWords = File.ReadAllText(filePath).Split(' ');

            var words = new List<string>();
            foreach (var word in inputWords)
                words.Add(word.Trim(',', '.', '!', '?', ' '));
            words.TrimExcess();

            var charCount = new List<int>();
            foreach (var word in words)
                charCount.Add(word.Length);
            charCount.TrimExcess();
            charCount.Sort();
            charCount.Reverse();

            var longestWords = new List<string>();
            foreach (var word in words)
                if (word.Length == charCount[0])
                    longestWords.Add(word);
            longestWords.TrimExcess();

            return longestWords;
        }
    }
}
