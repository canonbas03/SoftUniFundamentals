namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumOfCommands = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();
            for (int i = 0; i < NumOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (command[2] == "going!")
                {
                    if (!people.Contains(name))
                    {
                        people.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if(people.Contains(name))
                    {
                        people.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", people));
        }
    }
}
