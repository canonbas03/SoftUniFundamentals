﻿namespace _02.PrintInReverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int[] numbers = new int[number];
			for (int i = 0; i < number; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " "); 
            }

        }
	}
}
