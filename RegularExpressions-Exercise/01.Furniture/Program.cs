using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            string pattern = @"\>\>(?<Name>[A-Za-z]+)\<\<(?<Price>\d+|\d+\.\d+)\!(?<Quantity>\d+)";
            Regex regex = new Regex(pattern);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Furniture furniture = new Furniture(match.Groups["Name"].Value, double.Parse(match.Groups["Price"].Value), int.Parse(match.Groups["Quantity"].Value));
                    furnitures.Add(furniture);
                }
            }

            double total = default;
            Console.WriteLine("Bought furniture:");
            foreach(Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                total += furniture.GetTotal();
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }

    class Furniture
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Furniture(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return Price * Quantity;
        }

    }
}