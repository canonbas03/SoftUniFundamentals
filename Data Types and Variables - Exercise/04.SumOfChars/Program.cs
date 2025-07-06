namespace _04.SumOfChars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int asciiSum = 0;

			for (int i = 0; i < number; i++)
			{
				char ch = Console.ReadLine()[0];
				asciiSum+= (int)ch;
			}
			Console.WriteLine($"The sum equals: {asciiSum}");

		}
	}
}
