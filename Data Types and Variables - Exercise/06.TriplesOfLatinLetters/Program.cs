namespace _06.TriplesOfLatinLetters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int index = int.Parse(Console.ReadLine());

			for (int i = 0; i < index; i++)
			{
				for (int j = 0; j < index; j++)
				{
					for (int k = 0; k < index; k++)
					{
						Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
					}
				}
			}
		}
	}
}
