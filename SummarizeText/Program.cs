using System;

namespace SummarizeText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "This is gonna be a really really really really really really really really really really long text";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 30));
        }
    }
}
