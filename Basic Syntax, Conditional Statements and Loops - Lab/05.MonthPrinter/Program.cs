﻿using System;

namespace _05.MonthPrinter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int monthNum = int.Parse(Console.ReadLine());


			switch (monthNum)
			{
				case 1:
					Console.WriteLine("January");
					break;
				case 2:
					Console.WriteLine("February");
					break;
				case 3:
					Console.WriteLine("March");
					break;
				case 4:
					Console.WriteLine("April");
					break;
				case 5:
					Console.WriteLine("May");
					break;
				case 6:
					Console.WriteLine("June");
					break;
				case 7:
					Console.WriteLine("July");
					break;
				case 8:
					Console.WriteLine("August");
					break;
				case 9:
					Console.WriteLine("September");
					break;
				case 10:
					Console.WriteLine("October");
					break;
				case 11:
					Console.WriteLine("November");
					break;
				case 12:
					Console.WriteLine("December");
					break;
				default:
					Console.WriteLine("Error!");
					break;
			}
		}
	}
}
