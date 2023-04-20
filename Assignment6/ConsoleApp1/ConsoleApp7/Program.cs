namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // convert the input string to a char array
            char[] charArray = input.ToCharArray();

            // reverse the char array
            Array.Reverse(charArray);

            // convert the char array back to string
            string reversedString = new string(charArray);

            for (int i = 0; i < reversedString.Length; i++)
            {
                Console.Write(reversedString[i]);
            }
        }
    }
}