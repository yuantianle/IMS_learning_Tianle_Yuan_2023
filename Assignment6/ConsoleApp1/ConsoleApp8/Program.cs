using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string sentence = Console.ReadLine(); //"C# is not C++, and PHP is not Delphi!"
            char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] separatorsAndSpaces = sentence.Split(words, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            string reversedSentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                reversedSentence += words[i] + separatorsAndSpaces[i];
            }
            Console.WriteLine(reversedSentence);
        }
    }
}