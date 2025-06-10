using System;
using System.Linq;

namespace _05.TopIntegers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < numbers.Length; i++)
			{
				bool isTop = true;
				for (int j = i + 1; j < numbers.Length; j++)
				{
					int current = numbers[i], compare = numbers[j];
					if (numbers[i] <= numbers[j])
					{
						isTop = false;
						break;
					}
				}
				if (isTop)
				{
					Console.Write(numbers[i]  +" ");
				}
			}
		}
	}
}

// 14 24 3 19 15 17