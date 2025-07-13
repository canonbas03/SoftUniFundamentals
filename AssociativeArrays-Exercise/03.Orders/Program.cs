
namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsMap = new();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();

                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                decimal quantity = decimal.Parse(arguments[2]);

                if (!productsMap.ContainsKey(name))
                {
                    Product newProduct = new Product(name, price, quantity);
                    productsMap.Add(name, newProduct);
                }
                else
                {
                    productsMap[name].Update(price, quantity);
                }
            }
            foreach (KeyValuePair<string, Product> pair in productsMap)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity += quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        internal void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:f2}";
        }
    }
}
