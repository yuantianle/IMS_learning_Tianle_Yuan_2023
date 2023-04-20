namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> itemList = new List<string>();
            string input;
            bool ifLoop = true;

            while (ifLoop)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

                input = Console.ReadLine();

                if (input.StartsWith("+"))
                {
                    string itemToAdd = input.Substring(1).Trim();
                    itemList.Add(itemToAdd);
                }
                else if (input == "--")
                {
                    itemList.Clear();
                }
                else if (input.StartsWith("-"))
                {
                    string itemToRemove = input.Substring(1).Trim();
                    itemList.Remove(itemToRemove);
                }

                else if (input.ToLower() == "quit")
                {
                    ifLoop = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                    continue;
                }

                Console.WriteLine("Current grocery list:");
                if (itemList.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                else
                {
                    foreach (string item in itemList)
                    {
                        Console.WriteLine("* " + item);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}