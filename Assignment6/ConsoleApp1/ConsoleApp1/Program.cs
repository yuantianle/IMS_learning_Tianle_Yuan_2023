namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] secondArray = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                secondArray[i] = myArray[i];
            }

            Console.WriteLine("Initial array:");
            foreach (int value in myArray)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Copied array:");
            foreach (int value in secondArray)
            {
                Console.Write(value + " ");
            }
        }
    }
}