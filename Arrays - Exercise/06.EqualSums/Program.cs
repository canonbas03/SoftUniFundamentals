namespace _06.EqualSums
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			bool foundEl = false;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers.Length == 1)
				{
                    Console.WriteLine("0");
					foundEl = true;
					break;
                }
				int sumRight = 0, sumLeft = 0;
				for (int k = 0; k < i; k++)
				{
					sumLeft += numbers[k];
				}
				for (int j = i + 1; j < numbers.Length; j++)
				{
					sumRight += numbers[j];
				}

				if (sumLeft == sumRight)
				{
					foundEl = true;
					Console.WriteLine(i);
					break;
				}
			}
			if (!foundEl)
			{
				Console.WriteLine("no");
			}

		}


	}
}

// 1 2 3 3