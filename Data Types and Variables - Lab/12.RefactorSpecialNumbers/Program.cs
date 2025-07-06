namespace _12.RefactorSpecialNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			int total = 0;

			int placeholder = 0;

			bool isSpecial = false;

			for (int number = 1; number <= counter; number++)
			{
				placeholder = number;

				while (number > 0)

				{
					total += number % 10;
					number = number / 10;
				}

				isSpecial = (total == 5) || (total == 7) || (total == 11);
				Console.WriteLine("{0} -> {1}", placeholder, isSpecial);

				total = 0;
				number = placeholder;

			}
		}
	}
}
