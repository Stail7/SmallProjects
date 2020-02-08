using System;
using System.Collections.Generic;

namespace SummarizeText
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length <= maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                totalCharacters += word.Length + 1; // +1 ' ' after each word
                summaryWords.Add(word);
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }

    }
}
