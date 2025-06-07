using System;
using System.Threading.Channels;

namespace _07.EqualArrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int totalSum = 0;
			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] == array2[i])
				{
					totalSum += array1[i];
				}
				else
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					Environment.Exit(0);
				}
			}
            Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
        }
	}
}
