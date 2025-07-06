namespace _03.ExactSumOfRNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());

			decimal total = 0;
			for (int i = 0; i < counter; i++)
			{
				decimal number = decimal.Parse(Console.ReadLine());
				total += number;
		
			}
			Console.WriteLine(total);
		}
	}
}
