namespace _06.StrongNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			int workNum = num;
			int calc = 0;

			while (workNum > 0)
			{
				int lastDigit = workNum % 10;

				calc += Factorial(lastDigit);

				workNum /= 10;
			}

			if (num == calc)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}

		}

		static int Factorial(int number)
		{
			if (number == 0 || number == 1) return 1;

			return number * Factorial(number - 1);
		}
	}
}
