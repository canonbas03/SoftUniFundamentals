﻿namespace _08.MathPower
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double baseNumber = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());

			Console.WriteLine(MathPower(baseNumber, power));
		}

		static double MathPower(double baseNumber, int power)
		{
			double total = 1;
			for (int i = 0; i < power; i++)
			{
				total *= baseNumber;
			}

			return total;
		}
	}
}
