namespace _09.RageExpenses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int lostGameCount = int.Parse(Console.ReadLine());

			double headseatPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displayPrice = double.Parse(Console.ReadLine());

			double totalExpense = 0;

			int keyboardCount = 0;

			for (int gameNum = 1; gameNum <= lostGameCount; gameNum++)
			{
				if(gameNum % 2 == 0)
				{
					totalExpense += headseatPrice;
				}
				if (gameNum % 3 == 0)
				{
					totalExpense += mousePrice;
				}
				if(gameNum % 2 == 0 && gameNum % 3 == 0)
				{
					totalExpense += keyboardPrice;
					keyboardCount++;
					if(keyboardCount == 2)
					{
						totalExpense += displayPrice;
						keyboardCount = 0;
					}
				}
			}
			Console.WriteLine($"Rage expenses: {totalExpense:f2} lv.");
		}
	}
}

//Every second lost game, Petar trashes his headset.

//Every third lost game, Petar trashes his mouse.

//When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.

//Every second time, when he trashes his keyboard, he also trashes his display.