namespace _10.MultiplicationTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int element = int.Parse(Console.ReadLine());

			for (int i = 1; i < 11; i++) 
			{
				Console.WriteLine($"{element} X {i} = {element*i}");
			}
		}
	}
}
