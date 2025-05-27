namespace _09.SumOfOddNum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numOfOdd = int.Parse(Console.ReadLine());
			int calc = 0;
			for (int i = 1, broyach = 1; broyach <= numOfOdd; i+=2) 
			{
				Console.WriteLine(i);
				calc += i;
				broyach++;
			}
			Console.WriteLine($"Sum: {calc}");
		}
	}
}
