using System;
using System.Linq;

namespace ExtensionMethods 
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater then or equal to '0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            //var newString = new StringBuilder();
            //for (int i = 0; i < numberOfWords; i++)
            //{
            //    newString.Append(words[i] + " ");
            //}
            //return Convert.ToString(newString);

            //// OR

            // Join and Take are extension methods of the String class
            return string.Join(" ", words.Take(numberOfWords) + "...");
        }
    }
}