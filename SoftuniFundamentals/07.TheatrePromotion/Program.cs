using System;

namespace _07.TheatrePromotion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string dayType = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			int ticketPrice = 0;

			if(0<=age &&  age<= 18)
			{
				if(dayType == "Weekday")
				{
					ticketPrice = 12;
				}
				else if (dayType == "Weekend")
				{
					ticketPrice = 15;
				}
				else ticketPrice = 5;
			}
			else if(18<age &&  age<= 64)
			{
				if (dayType == "Weekday")
				{
					ticketPrice = 18;
				}
				else if (dayType == "Weekend")
				{
					ticketPrice = 20;
				}
				else ticketPrice = 12;
			}
			else if(64<age &&  age<= 122)
			{
				if (dayType == "Weekday")
				{
					ticketPrice = 12;
				}
				else if (dayType == "Weekend")
				{
					ticketPrice = 15;
				}
				else ticketPrice = 10;
			}

			if (ticketPrice == 0)
			{
				Console.WriteLine("Error!");
			}
			else Console.WriteLine($"{ticketPrice}$");
        }
	}
}
