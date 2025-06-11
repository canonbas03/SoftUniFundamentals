namespace _04.printTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintTriangle(1, int.Parse(Console.ReadLine()));
		}


		static void PrintTriangle(int start, int end)
		{
			for (int i = start; i < end; i++)
			{
				PrintLine(1, i);
			}

			for (int i = end; i >= start; i--)
			{
				PrintLine(start, i);
			}
		}
		static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
