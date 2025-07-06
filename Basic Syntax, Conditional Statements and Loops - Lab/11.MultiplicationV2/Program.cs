namespace _11.MultiplicationV2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int multiplier = int.Parse(Console.ReadLine());

			do
			{
				Console.WriteLine($"{number} X {multiplier} = {number*multiplier}");
				multiplier++;
			}
			while ( multiplier < 11 );
		}
	}
}
