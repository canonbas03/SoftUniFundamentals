namespace M03.Games
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> gameDict = new Dictionary<string, double>()
			{
				{"OutFall 4", 39.99},
				{"CS: OG", 15.99},
				{"Zplinter Zell",19.99 },
				{"Honored 2",59.99 },
				{"RoverWatch", 29.99},
				{"RoverWatch Origins Edition", 39.99}
			};

			double balance = double.Parse(Console.ReadLine());

			double totalSpent = 0;

			string command;
			while ((command = Console.ReadLine()) != "Game Time")
			{
				if (!gameDict.ContainsKey(command))
				{
					Console.WriteLine("Not Found");
					continue;
				}
				if (gameDict.ContainsKey(command))
				{
					if((balance - gameDict[command]) >= 0)
					{
						balance -= gameDict[command];
						totalSpent += gameDict[command];
						if (balance > 0)
						{
							Console.WriteLine($"Bought {command}");
						}
						else if (balance == 0)
						{
							Console.WriteLine($"Bought {command}");
							Console.WriteLine("Out of money!");
							Environment.Exit(0);
						}
					}
					else
					{
						Console.WriteLine("Too Expensive");
						continue;
					}
					//continue;
				}
				else
				{
					Console.WriteLine("Not Found");
					continue;
				}
			}
				Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");

		}
	}
}
