namespace _03.Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Town> towns = new();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arguments = input.Split("||");

                string name = arguments[0];
                int population = int.Parse(arguments[1]);
                int gold = int.Parse(arguments[2]);

                if (!towns.ContainsKey(name))
                {
                    Town town = new Town();
                    town.Name = name;
                    town.Population = population;
                    town.Gold = gold;
                    towns[name] = town;
                }
                else
                {
                    towns[name].Population += population;
                    towns[name].Gold += gold;
                }
            }
            while((input = Console.ReadLine()) !="End")
            {
                string[] arguments = input.Split("=>");
                string action = arguments[0];
                switch (action)
                {
                    case "Plunder":
                        string name = arguments[1];
                        int population = int.Parse (arguments[2]);
                        int gold = int.Parse(arguments[3]);
                        Plunder(name, population, gold, towns);
                        break;
                    case "Prosper":
                        name = arguments[1];
                        gold = int.Parse(arguments[2]);
                        Prosper(name, gold, towns);
                        break;
                }
            }
            if(towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (Town town in towns.Values)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        private static void Prosper(string name, int gold, Dictionary<string, Town> towns)
        {
            if(gold >= 0)
            {
                towns[name].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {towns[name].Gold} gold.");
            }
            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
        }
        private static void Plunder(string name, int population, int gold, Dictionary<string, Town> towns)
        {
            towns[name].Population -= population;
            towns[name].Gold -= gold;

            Console.WriteLine($"{name} plundered! {gold} gold stolen, {population} citizens killed.");
            if(towns[name].Population <= 0 || towns[name].Gold <= 0)
            {
                towns.Remove(name);
                Console.WriteLine($"{name} has been wiped off the map!");
            }
        }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
