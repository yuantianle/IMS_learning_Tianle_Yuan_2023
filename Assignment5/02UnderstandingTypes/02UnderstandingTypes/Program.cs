// HW 2.1 : Write a program that prints the size of each of the C# built-in types to the console.
//namespace _02UnderstandingTypes
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Type     | Bytes | Min Value                           | Max Value");
//            Console.WriteLine("---------|-------|-------------------------------------|------------------------------------");
//            Console.WriteLine($"sbyte    | {sizeof(sbyte),-5} | {sbyte.MinValue,35} | {sbyte.MaxValue,35}");
//            Console.WriteLine($"byte     | {sizeof(byte),-5} | {byte.MinValue,35} | {byte.MaxValue,35}");
//            Console.WriteLine($"short    | {sizeof(short),-5} | {short.MinValue,35} | {short.MaxValue,35}");
//            Console.WriteLine($"ushort   | {sizeof(ushort),-5} | {ushort.MinValue,35} | {ushort.MaxValue,35}");
//            Console.WriteLine($"int      | {sizeof(int),-5} | {int.MinValue,35} | {int.MaxValue,35}");
//            Console.WriteLine($"uint     | {sizeof(uint),-5} | {uint.MinValue,35} | {uint.MaxValue,35}");
//            Console.WriteLine($"long     | {sizeof(long),-5} | {long.MinValue,35} | {long.MaxValue,35}");
//            Console.WriteLine($"ulong    | {sizeof(ulong),-5} | {ulong.MinValue,35} | {ulong.MaxValue,35}");
//            Console.WriteLine($"float    | {sizeof(float),-5} | {float.MinValue.ToString("E", System.Globalization.CultureInfo.InvariantCulture),35} | {float.MaxValue.ToString("E", System.Globalization.CultureInfo.InvariantCulture),35}");
//            Console.WriteLine($"double   | {sizeof(double),-5} | {double.MinValue.ToString("E", System.Globalization.CultureInfo.InvariantCulture),35} | {double.MaxValue.ToString("E", System.Globalization.CultureInfo.InvariantCulture),35}");
//            Console.WriteLine($"decimal  | {sizeof(decimal),-5} | {decimal.MinValue,35} | {decimal.MaxValue,35}");
//
//        }
//    }
//}

// HW 2.2 : Write a program that reads a number of centuries and converts it to years, days, current_hours, minutes, seconds, milliseconds, microseconds and nanoseconds.
//using System.Numerics;
//
//namespace _02UnderstandingTypes
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter numeric of centuries: ");
//            int centuries = int.Parse(Console.ReadLine());
//            int years = centuries * 100;
//            int days = (int)(years * 365.2422);
//            long current_hours = days * 24;
//            long minutes = current_hours * 60;
//            long seconds = minutes * 60;
//            long milliseconds = seconds * 1000;
//            BigInteger microseconds = (BigInteger)milliseconds * 1000;  // BigInteger is used to avoid overflow
//            BigInteger nanoseconds = microseconds * 1000;
//            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {current_hours} current_hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds.ToString()} nanoseconds");
//        }
//    }
//}

// HW 3.1.1 : Write a program that prints all the numbers from 0 to 500 that are divisible by 3.
//namespace _03Operators
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int max = 500;
//            if (max > byte.MaxValue)
//            {
//                Console.WriteLine("Warning: The 'max' value is greater than the maximum value of a byte. There might be an overflow issue.");
//                return;
//            }
//
//            for (byte i = 0; i < max; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}   

// HW 3.1.2 : guess the number game 
//namespace GuessNumber
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int correctNumber = new Random().Next(3) + 1;
//
//            bool flag = true;
//            while (flag){
//                Console.WriteLine("Guess what the number it is?");
//                int guess = int.Parse(Console.ReadLine());
//
//                if (guess < correctNumber)
//                {
//                    Console.WriteLine("Guess low!");
//                }
//                else if (guess > correctNumber)
//                {
//                    Console.WriteLine("Guess high!");
//                }
//                else
//                {
//                    Console.WriteLine("Correct answer!");
//                    flag = false;
//                }
//                if (guess > 3 || guess < 1)
//                {
//                    Console.WriteLine("Your answer is outside of the range of numbers !");
//                }
//            }
//        }
//    }
//}   

// HW 3.2 : print a pyramid 
//namespace PrintAPyramid
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int row = 1; row < 6; row++)
//            {
//                for (int col = 0; col < row*2-1; col++)
//                {
//                    Console.Write("*");
//                }
//                for (int col = 0; col < 5-row; col++)
//                {
//                    Console.Write(" ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}   

// HW 3.3 : same as 3.1.2
//namespace GuessNumber
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int correctNumber = new Random().Next(3) + 1;
//
//            bool flag = true;
//            while (flag){
//                Console.WriteLine("Guess what the number it is?");
//                int guess = int.Parse(Console.ReadLine());
//
//                if (guess < correctNumber)
//                {
//                    Console.WriteLine("Guess low!");
//                }
//                else if (guess > correctNumber)
//                {
//                    Console.WriteLine("Guess high!");
//                }
//                else
//                {
//                    Console.WriteLine("Correct answer!");
//                    flag = false;
//                }
//                if (guess > 3 || guess < 1)
//                {
//                    Console.WriteLine("Your answer is outside of the range of numbers !");
//                }
//            }
//        }
//    }
//}   

// HW 3.4 : write a program input birthdate and calculate the days from birthdate to today and the days to next 10000 days anniversary
//namespace Anniversary
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please input your birthday (format: 'year month date'):");
//            DateTime birthDate;
//            //now input the date
//            birthDate = DateTime.Parse(Console.ReadLine());
//
//            DateTime today = DateTime.Today;
//            int days = (today - birthDate).Days;
//            Console.WriteLine($"You are {days} days old.");
//            int daysToNextAnniversary = 10000 - (days % 10000);
//            Console.WriteLine($"Your next 10000 days anniversary is in {daysToNextAnniversary} days.");
//        }
//    }
//}

// HW 3.5 : greeting according to the time of day
//namespace Greeting { 
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            DateTime now = DateTime.Now;
//            int current_hour = now.Hour;
//            if (current_hour < 12 && current_hour >= 6)
//            {
//                Console.WriteLine("Good Morning");
//            }
//            if (current_hour >= 12 && current_hour < 18)
//            {
//                Console.WriteLine("Good Afternoon");
//            }
//            if (current_hour >= 18 && current_hour < 21)
//            {
//                Console.WriteLine("Good Evening");
//            }
//            if (current_hour >= 21 || current_hour < 6)
//            {
//                Console.WriteLine("Good Night");
//            }
//        }
//    }
//}

// HW 3.6: counting 24 numbers in 4 rows
namespace Counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 4; row++)
            {
                int distance = row + 1;
                for (int col = 0; col <= 24; col += distance)
                {
                    if (col != 24) Console.Write("{0},", col);
                    else Console.Write("{0}\n", col);
                }
            }
        }
    }
}