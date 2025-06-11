namespace _10.MultiplyEvensByOdds
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = Math.Abs(int.Parse(Console.ReadLine()));
			Console.WriteLine(GetMultipleOfEvenAndOdds(number));
		}

		static int GetMultipleOfEvenAndOdds(int number)
		{
			return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
		}

		static int GetSumOfEvenDigits(int number)
		{
			int totalSum = 0;
			while (number > 0)
			{
				int lastDigit = number % 10;
				if (lastDigit % 2 == 0)
				{
					totalSum += lastDigit;
				}
				number = number / 10;
			}
			return totalSum;
		}

		static int GetSumOfOddDigits(int number)
		{
			int totalSum = 0;
			while (number > 0)
			{
				int lastDigit = number % 10;
				if (lastDigit % 2 != 0)
				{
					totalSum += lastDigit;
				}
				number = number / 10;
			}
			return totalSum;
		}
	}
}
