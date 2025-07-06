using System.Data.SqlTypes;

namespace _07.WaterFlow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int capacity = 255;

			int lineNum = int.Parse(Console.ReadLine());
			int totalLiters = 0;

			for (int i = 0; i < lineNum; i++)
			{
				int liters = int.Parse(Console.ReadLine());
				if(totalLiters + liters <= 255)
				{
					totalLiters += liters;
				}
				else
				{
                    Console.WriteLine("Insufficient capacity!");
                }
			}
            Console.WriteLine(totalLiters);
        }
	}
}
