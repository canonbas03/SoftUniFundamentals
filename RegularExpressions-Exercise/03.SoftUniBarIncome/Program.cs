using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<Customer>[A-Z][a-z]+)\%[^\|\$\.\%]*\<(?<Product>\w+)\>[^\|\$\.\%\d]*\|(?<Quantity>\d+)\|[^\|\$\.\%\d]*(?<Price>\d+|\d+\.\d+)\$";

            List<Customers> customers = new List<Customers>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Customers customer = new Customers(match.Groups["Customer"].Value, match.Groups["Product"].Value, int.Parse(match.Groups["Quantity"].Value), double.Parse(match.Groups["Price"].Value));
                    customers.Add(customer);
                }
            }

            double total = 0;
            foreach (Customers customer in customers)
            {
                Console.WriteLine($"{customer.Name}: {customer.Product} - {customer.Price * customer.Quantity:f2}");
                total += customer.Price * customer.Quantity;
            }
                Console.WriteLine($"Total income: {total:f2}");
        }
    }

    class Customers
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Customers(string name, string product, int quantity, double price)
        {
            Name = name;
            Product = product;
            Quantity = quantity;
            Price = price;
        }
    }
}
