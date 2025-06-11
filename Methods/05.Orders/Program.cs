namespace _05.Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			CalculateTotal(product, quantity);
		}
		static void CalculateTotal(string product, int quantity)
		{
			double price = 0;
			if (product == "coffee") price = 1.5;
			else if (product == "water") price = 1;
			else if (product == "coke") price = 1.4;
			else if (product == "snacks") price = 2;

			double total = quantity * price;
            Console.WriteLine($"{total:f2}");
        }
	}
}
