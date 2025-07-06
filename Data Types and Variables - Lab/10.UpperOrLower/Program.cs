namespace _10.UpperOrLower
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char ch = Console.ReadLine()[0];

			if (char.IsUpper(ch))
			{
				Console.WriteLine("upper-case");
			}
			else
			{
				Console.WriteLine("lower-case");

			}
		}
	}
}
