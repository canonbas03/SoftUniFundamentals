namespace _08.NumTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int rowCount = 1;

			for (int i = 1; i <= number; i++)
			{
				for (int j = 1; j <= rowCount; j++)
				{
					Console.Write(rowCount + " ");
				}
				rowCount++;
				Console.WriteLine("Hel");
			}
		}
	}
}
