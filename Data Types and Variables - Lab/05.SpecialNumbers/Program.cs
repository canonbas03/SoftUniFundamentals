namespace _05.SpecialNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			for (int counter = 1; counter <= number; counter++)
			{
				int numbersSum = 0;
				int placeholder = counter;
				while (placeholder > 0)
				{
					numbersSum += placeholder % 10;
					placeholder /= 10;
				}

				if (numbersSum == 5 || numbersSum == 7 || numbersSum == 11)
				{
					Console.WriteLine($"{counter} -> True");
				}
				else
				{
					Console.WriteLine($"{counter} -> False");
				}
			}
			
		}
	}
}
