using System.Numerics;

namespace _01.Train
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int wagonCount = int.Parse(Console.ReadLine());

			int[] passengers = new int[wagonCount];
			int total = 0;
			for (int i = 0; i < wagonCount; i++)
			{
				passengers[i] = int.Parse(Console.ReadLine());
				total += passengers[i];
			}

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine();
        }
	}
}
