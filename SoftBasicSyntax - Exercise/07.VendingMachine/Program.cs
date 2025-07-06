using System.Diagnostics;

namespace _07.VendingMachine
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double totalCoins = 0;
			string input;
			while ((input = Console.ReadLine()) != "Start")
			{
				double coinInserted = double.Parse(input);
				List<double> validCoins = new List<double> { 0.1, 0.2, 0.5, 1, 2 };


				if (validCoins.Contains(coinInserted))
				{
					totalCoins += coinInserted;
				}
				else
				{
					Console.WriteLine($"Cannot accept {coinInserted}");
				}
			}

			Dictionary<string, double> productToPrice = new Dictionary<string, double>()
				{
					{ "Nuts", 2 },
					{ "Water", 0.7 },
					{ "Crisps", 1.5 },
					{ "Soda", 0.8 },
					{ "Coke", 1 }
				};
			while ((input = Console.ReadLine()) != "End")
			{
				if (productToPrice.ContainsKey(input))
				{
					if(totalCoins >= productToPrice[input])
					{
						Console.WriteLine($"Purchased {input.ToLower()}");
						totalCoins -= productToPrice[input];
					}
					else
					{
						Console.WriteLine("Sorry, not enough money");
					}
					
				}
				else
				{
					Console.WriteLine("Invalid product");
				}
			}

			Console.WriteLine($"Change: {totalCoins:f2}");
		}
	}
}
