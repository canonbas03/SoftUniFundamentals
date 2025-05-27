using System;

namespace _03.BackIn30Mins
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());

			int minsToAdd = 30;

			minutes += minsToAdd;

			if(minutes > 59)
			{
				minutes -= 60;
				hours++;
			}
			if(hours > 23)
			{
				hours = 0;
			}

			if(minutes <10)
			{
				Console.WriteLine($"{hours}:{minutes:d2}");
			}
			else Console.WriteLine($"{hours}:{minutes}");
		}
	}
}
