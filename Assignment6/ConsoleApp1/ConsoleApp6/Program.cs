namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer array (split with space):");
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> hash = new Dictionary<int, int>();
            int maxFrequency = 0;
            int maxNumber = int.MinValue;

            foreach (int number in inputArray)
            {
                if (hash.ContainsKey(number))
                {
                    hash[number]++;
                }
                else
                {
                    hash[number] = 1;
                }

                if (hash[number] > maxFrequency)
                {
                    maxFrequency = hash[number];
                    maxNumber = number;
                }
            }

            Console.WriteLine($"The number {maxNumber} is the most frequent (occurs {maxFrequency} times)");
        }
    }
}