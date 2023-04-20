namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string url = Console.ReadLine();
            string protocol = "";
            string server = "";
            string resource = "";
            int protocolIndex = url.IndexOf("://");
            if (protocolIndex != -1)
            {
                protocol = url.Substring(0, protocolIndex);
                url = url.Substring(protocolIndex + 3);
            }
            int resourceIndex = url.IndexOf('/');
            if (resourceIndex != -1)
            {
                server = url.Substring(0, resourceIndex);
                resource = url.Substring(resourceIndex + 1);
            }
            else
            {
                server = url;
            }
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}