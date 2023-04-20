internal class Program
{
    private static void Main(string[] args)
    {
        //HW 2.0
        string color, astrolotySign, streetAddress;
        Console.WriteLine("Please provide your favorite color:\n");
        color = Console.ReadLine();

        Console.WriteLine("Please provide your astroloty sign:\n");
        astrolotySign = Console.ReadLine();

        Console.WriteLine("Please provide your street address:\n");
        streetAddress = Console.ReadLine();

        Console.WriteLine("our hacker name is " + color + astrolotySign + streetAddress + ".");
    }
}