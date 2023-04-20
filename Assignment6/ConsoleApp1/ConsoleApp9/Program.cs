namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] separators = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = words.Where(word => IsPalindrome(word)).Distinct().OrderBy(word => word);
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static bool IsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}