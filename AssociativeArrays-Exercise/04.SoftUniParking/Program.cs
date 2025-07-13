using System.Numerics;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersPlates = new();
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string userName = input[1];

                if (command == "register")
                {
                    string licensePlate = input[2];
                    if (!usersPlates.ContainsKey(userName))
                    {
                        usersPlates[userName] = licensePlate;
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else // unregister
                {
                    if (!usersPlates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        usersPlates.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (KeyValuePair<string, string> pairs in usersPlates)
            {
                Console.WriteLine($"{pairs.Key} => {pairs.Value}");
            }
        }
    }
}
