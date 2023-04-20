namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer array (split with space):");
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = 0;
            int maxStartIndex = -1;
            int currentLength = 1;
            int currentStartIndex = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }

                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            // Since we miss to check the last sequence, we check the last one.
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            Console.WriteLine("Longest sequence of equal elements:");
            Console.WriteLine(string.Join(" ", inputArray.Skip(maxStartIndex).Take(maxLength)));
        }
    }
}

