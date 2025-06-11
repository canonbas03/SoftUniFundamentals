namespace _07.RepeatSring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());
			Console.WriteLine(WordRepeater(word,count));
		}

		static string WordRepeater(string word, int number)
		{
			string finalWord = string.Empty;
			for (int i = 0; i < number; i++)
			{
				finalWord += word;
			}
			return finalWord;
		}
	}
}
