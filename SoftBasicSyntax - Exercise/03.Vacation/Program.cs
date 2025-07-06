using System.Diagnostics;

namespace _03.Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string dayOfWeek = Console.ReadLine();

			decimal pricePerPerson = 0;
			decimal totalPrice;

			if (groupType == "Students")
			{
				if (dayOfWeek == "Friday")
				{
					pricePerPerson = 8.45m;
				}
				else if (dayOfWeek == "Saturday")
				{
					pricePerPerson = 9.8m;
				}
				else if (dayOfWeek == "Sunday")
				{
					pricePerPerson = 10.46m;
				}
				totalPrice = pricePerPerson * peopleCount;
				if (peopleCount >= 30)
				{
					totalPrice *= 0.85m;
				}
				Console.WriteLine($"Total price: {totalPrice:f2}");
			}
			else if (groupType == "Business")
			{
				if (dayOfWeek == "Friday")
				{
					pricePerPerson = 10.9m;
				}
				else if (dayOfWeek == "Saturday")
				{
					pricePerPerson = 15.6m;
				}
				else if (dayOfWeek == "Sunday")
				{
					pricePerPerson = 16m;
				}

				if (peopleCount >= 100)
				{
					peopleCount -= 10;
				}

				totalPrice = peopleCount * pricePerPerson;
				Console.WriteLine($"Total price: {totalPrice:f2}");
			}
			else if (groupType == "Regular")
			{
				if (dayOfWeek == "Friday")
				{
					pricePerPerson = 15m;
				}
				else if (dayOfWeek == "Saturday")
				{
					pricePerPerson = 20m;
				}
				else if (dayOfWeek == "Sunday")
				{
					pricePerPerson = 22.5m;
				}

				if(peopleCount >= 10 && peopleCount <= 20)
				{
					pricePerPerson *= 0.95m;
				}
				totalPrice = peopleCount * pricePerPerson;
				Console.WriteLine($"Total price: {totalPrice:f2}");
			}

			//Console.WriteLine(pricePerPerson);
		}
	}
}
