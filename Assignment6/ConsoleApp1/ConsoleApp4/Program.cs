namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer array (splite with space):");
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter the number of rotations:");
            int k = int.Parse(Console.ReadLine());

            int[] sumArray = new int[inputArray.Length];
            for (int r = 0; r < k; r++)
            {
                int[] rotatedArray = RotateRight(inputArray, r);
                for (int i = 0; i < inputArray.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
            }

            Console.WriteLine("Sum array:");
            Console.WriteLine(string.Join(" ", sumArray));
        }

        static int[] RotateRight(int[] array, int rotations)
        {
            int n = array.Length;
            int[] rotatedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newPos = (i + rotations) % n;
                rotatedArray[newPos] = array[i];
            }

            return rotatedArray;
        }
    }
    
}