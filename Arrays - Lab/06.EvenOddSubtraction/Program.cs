namespace _06.EvenOddSubtraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int totalEven = 0;
			int totalOdd = 0;

			foreach (int number in numbers)
			{
				if (number % 2 == 0)
				{
					totalEven += number;
				}
				else
				{
					totalOdd += number;
				}
			}
            Console.WriteLine(totalEven - totalOdd);
        }
	}
}
