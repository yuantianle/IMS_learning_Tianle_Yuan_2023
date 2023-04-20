using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int left = 10;
            int right = 50;

            int[] primes = FindPrimesInRange(left, right);

            Console.WriteLine($"Prime numbers between {left} and {right}:");
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
        }

        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] primes = new int[0];
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes = AppendToArray(primes, i);
                }
            }
            return primes;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static int[] AppendToArray(int[] array, int primeNum)
        {
            int[] appendedArray = new int[array.Length + 1];
            array.CopyTo(appendedArray, 0);
            appendedArray[array.Length] = primeNum;
            return appendedArray;
        }
    }
}