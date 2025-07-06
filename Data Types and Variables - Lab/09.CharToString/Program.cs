namespace _09.CharToString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string finalWord = string.Empty;

			for (int i = 0; i < 3; i++)
			{
				char ch = Console.ReadLine()[0];
				finalWord += ch;
			}
			Console.WriteLine(finalWord);
		}
	}
}
