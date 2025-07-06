namespace _09.SpiceMustFlow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int startYield = int.Parse(Console.ReadLine());

			int day = 0;
			int totalExtracted = 0;
			while (startYield >= 100)
			{
				day++;
				totalExtracted += startYield;
				totalExtracted -= 26;
				startYield -= 10;
			}
			if (totalExtracted >= 26)
			{
				totalExtracted -= 26;
			}

			Console.WriteLine(day);
			Console.WriteLine(totalExtracted);
		}
	}
}
