namespace Day7_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array to generate:");
            int inputLength = int.Parse(Console.ReadLine());
            int[] numbers = GenerateNumbers(inputLength);
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        static int[] GenerateNumbers(int length)
        {
            Console.WriteLine("Here is the generated array:");
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = i + 1;
                Console.Write($"{result[i]} ");
            }
            Console.Write("\n");
            return result;
        }
        static void Reverse(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }
        static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine("Here is the reversed array:");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}