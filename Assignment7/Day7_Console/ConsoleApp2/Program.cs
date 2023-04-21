namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the first 10 of the Fibonacci:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}