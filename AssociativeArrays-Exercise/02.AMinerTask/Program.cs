namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourceQuantities = new();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                uint quantity = uint.Parse(Console.ReadLine());

                if (!resourceQuantities.ContainsKey(resource))
                {
                    resourceQuantities[resource] = default;
                }

                resourceQuantities[resource] += quantity;
            }
            foreach (KeyValuePair<string, uint> resources in resourceQuantities)
            {
                Console.WriteLine($"{resources.Key} -> {resources.Value}");
            }

        }
    }
}
